using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;

namespace Quote_Tracker
{
    public partial class FinishedViewer : Form
    {
        public FinishedViewer()
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            InitializeComponent();
        }
        public static string val;
        SqlDataReader reader;
        int client_id;
        double sumProfit = 0;
        double cogItem = 0;
        double cogTotal = 0;
        double totalProf = 0;
        int qtyOrder = 0;
        int i = 0;
        int f = 0;
        double percentAve = 0;
        DataTable table = new DataTable();
        int activityID = Convert.ToInt32(finishedQuotes.activityIDFinished);

        private void FinishedViewer_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(mainForm.activityIDEdit);
            DateTime myDateTime = DateTime.Now;
            string result = "";

            string actQuery = @"SELECT * FROM tb_activity WHERE id_activity = @idactivity";
            string client_name = @"SELECT * FROM tb_client_info WHERE Id_client = @id_client";
            string querytotals = @"SELECT qty AS  Qty, cog AS CoG, sog AS SoG, total AS Total FROM tb_quote WHERE id_quote =" + Convert.ToInt32(finishedQuotes.activityIDFinished) + "";


            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=192.168.1.32;Initial Catalog=BS_ACTIVITY;User ID=sa;Password=2000lomaland"))
                {
                    using (SqlCommand comm = new SqlCommand(actQuery, conn))
                    {
                        comm.Connection = conn;
                        conn.Open();

                        comm.Parameters.Add("@idactivity", SqlDbType.Int).Value = Convert.ToInt32(finishedQuotes.activityIDFinished);
                        comm.ExecuteNonQuery();
                        reader = comm.ExecuteReader();
                        reader.Read();

                        client_id = Convert.ToInt32(reader["id_client"]);
                        start_date_label.Text = reader["start_date"].ToString();
                        endDateTextBox.Text = reader["end_date"].ToString();
                        title_textBox.Text = reader["title"].ToString();
                       

                    }
                }
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
                MessageBox.Show(result);
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=192.168.1.32;Initial Catalog=BS_ACTIVITY;User ID=sa;Password=2000lomaland"))
                {
                    using (SqlCommand comm = new SqlCommand(client_name, conn))
                    {
                        comm.Connection = conn;
                        conn.Open();

                        comm.Parameters.Add("@id_client", SqlDbType.Int).Value = client_id;
                        comm.ExecuteNonQuery();
                        reader = comm.ExecuteReader();
                        reader.Read();

                        client_name_label.Text = reader["client_name"].ToString().Trim();


                    }
                }
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
                MessageBox.Show(result);
            }

            try
            {
                string getQuote = @"SELECT item AS Item, sku AS SKU, provider AS Provider, qty AS  Qty, cog AS CoG, sog AS SoG, total AS Total FROM tb_quote WHERE id_quote =" + Convert.ToInt32(finishedQuotes.activityIDFinished) + "";
                using (SqlConnection conn = new SqlConnection(@"Data Source=192.168.1.32;Initial Catalog=BS_ACTIVITY;User ID=sa;Password=2000lomaland"))
                {
                    using (var adapter = new SqlDataAdapter(getQuote, conn))
                    {


                        table.Columns.Add("Item");
                        table.Columns.Add("SKU");
                        table.Columns.Add("Provider");
                        table.Columns.Add("Qty");
                        table.Columns.Add("CoG");
                        table.Columns.Add("SoG");
                        table.Columns.Add("Total");


                        adapter.Fill(table);
                        this.dataGridView1.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
                MessageBox.Show(result);
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //multiply qty  by cog and add the result to cogItem
                cogItem += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value) * Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                total_sale_label.Text = "Total CoG: $" + cogItem.ToString();

                //adds the row total to sumprofit
                sumProfit += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                total_label.Text = "Total: $" + sumProfit.ToString();

                //subtract to obtain the total earnings
                totalProf = sumProfit - cogItem;
                total_profit_label.Text = "Total Profit: $" + totalProf.ToString();

                //calculate average markup for quote
                percentAve = ((totalProf / cogItem) * 100);
                percent_label.Text = "MarkUp Average: " + Math.Round(percentAve, 2).ToString() + "%";



                i++;

            }
        }

        private void Export_btn_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XLS files (*.xls)|*.xls|XLT files (*.xlt)|*.xlt|XLSX files (*.xlsx)|*.xlsx|XLSM files (*.xlsm)|*.xlsm|XLTX (*.xltx)|*.xltx|XLTM (*.xltm)|*.xltm|ODS (*.ods)|*.ods|OTS (*.ots)|*.ots|CSV (*.csv)|*.csv|TSV (*.tsv)|*.tsv|HTML (*.html)|*.html|MHTML (.mhtml)|*.mhtml|PDF (*.pdf)|*.pdf|XPS (*.xps)|*.xps|BMP (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png|TIFF (*.tif)|*.tif|WMP (*.wdp)|*.wdp";
            saveFileDialog.FilterIndex = 3;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var workbook = new ExcelFile();
                var worksheet = workbook.Worksheets.Add("Sheet1");

                // From DataGridView to ExcelFile.
                DataGridViewConverter.ImportFromDataGridView(worksheet, this.dataGridView1, new ImportFromDataGridViewOptions() { ColumnHeaders = true });

                workbook.Save(saveFileDialog.FileName);
            }
        }
    }
}
