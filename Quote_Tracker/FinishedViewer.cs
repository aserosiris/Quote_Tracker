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
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

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
            /*
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
            */


            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XLS files (*.xls)|*.xls|XLT files (*.xlt)|*.xlt|XLSX files (*.xlsx)|*.xlsx|XLSM files (*.xlsm)|*.xlsm|XLTX (*.xltx)|*.xltx|XLTM (*.xltm)|*.xltm|ODS (*.ods)|*.ods|OTS (*.ots)|*.ots|CSV (*.csv)|*.csv|TSV (*.tsv)|*.tsv|HTML (*.html)|*.html|MHTML (.mhtml)|*.mhtml|PDF (*.pdf)|*.pdf|XPS (*.xps)|*.xps|BMP (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png|TIFF (*.tif)|*.tif|WMP (*.wdp)|*.wdp";
            saveFileDialog.FilterIndex = 3;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var workbook = ExcelFile.Load("Template.xlsx");

                int workingDays = 8;

                var startDate = DateTime.Now.AddDays(-workingDays);
                var endDate = DateTime.Now;

                var worksheet = workbook.Worksheets[0];

                // Find cells with placeholder text and set their values.
                int row, column;
                if (worksheet.Cells.FindText("[Company Name]", true, true, out row, out column))
                    worksheet.Cells[row, column].Value = client_name_label.Text;
                if (worksheet.Cells.FindText("[Company Address]", true, true, out row, out column))
                    worksheet.Cells[row, column].Value = "";
                if (worksheet.Cells.FindText("[Date]", true, true, out row, out column))
                    worksheet.Cells[row, column].Value = endDate;

                // Copy template row.
                row = 16;
                worksheet.Rows.InsertCopy(row + 1, dataGridView1.Rows.Count - 1, worksheet.Rows[row]);

                for(int i = 0; i< dataGridView1.Rows.Count-1; i++)
                {
                    var currentRow = worksheet.Rows[row + i];
                    //currentRow.Cells[1].SetValue(dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[0].Value.ToString());
                    string item = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    string sku = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string provider = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    int qty = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                    double cog = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                    double sog = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    double total = Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                    currentRow.Cells[1].SetValue(item);
                    currentRow.Cells[2].SetValue(sku);
                    currentRow.Cells[3].SetValue(provider);
                    currentRow.Cells[4].SetValue(qty);
                    currentRow.Cells[5].SetValue(cog);
                    currentRow.Cells[6].SetValue(sog);
                    currentRow.Cells[7].SetValue(total);

                }

                // Calculate formulas in worksheet.
                worksheet.Calculate();

                workbook.Save(saveFileDialog.FileName);
            }

            


        }

        private void Pdf_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
