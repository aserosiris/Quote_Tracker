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
        string quote_status;
        int status_quote;
        string order_date;
        string order_status;
        string orderSetString;
        string orderDeliveredString;
        string deliveryStatus;
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
                        quote_status = reader["quote_status"].ToString();
                        order_date = reader["submit_date"].ToString();
                        order_status = reader["order_status"].ToString();
                        orderSetString = reader["submit_date"].ToString();
                        orderDeliveredString = reader["delivery_order"].ToString();
                       // order_deliver_dtp.Value = Convert.ToDateTime(orderSetString);
                        //delivery_dtp.Value = Convert.ToDateTime(orderDeliveredString);



                    }
                }
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();

            }

            //SET DATE ON DATE TIME PICKER

            order_deliver_dtp.Value = Convert.ToDateTime(order_date.Substring(0, 10));
            delivery_dtp.Value = Convert.ToDateTime(orderDeliveredString);
            //

            if(String.Equals(order_status.Trim(), "Expected Delivery Date"))
            {
                order_status_CB.SelectedIndex = 0;
            }
            else if(String.Equals(order_status.Trim(), "Date Delivered"))
            {
                order_status_CB.SelectedIndex = 1;
            }
            else
            {
                order_status_CB.SelectedIndex = 2;
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
                string getQuote = @"SELECT item AS Item, sku AS SKU, provider AS Provider,unit AS Unit, qty AS  Qty, cog AS CoG, sog AS SoG, total AS Total FROM tb_quote WHERE id_quote =" + Convert.ToInt32(finishedQuotes.activityIDFinished) + "";
                using (SqlConnection conn = new SqlConnection(@"Data Source=192.168.1.32;Initial Catalog=BS_ACTIVITY;User ID=sa;Password=2000lomaland"))
                {
                    using (var adapter = new SqlDataAdapter(getQuote, conn))
                    {


                        table.Columns.Add("Item");
                        table.Columns.Add("SKU");
                        table.Columns.Add("Provider");
                        table.Columns.Add("Unit");
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
                cogItem += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value) * Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                total_sale_label.Text = "Total CoG: $" + cogItem.ToString();

                //adds the row total to sumprofit
                sumProfit += Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
                total_label.Text = "Total: $" + sumProfit.ToString();

                //subtract to obtain the total earnings
                totalProf = sumProfit - cogItem;
                total_profit_label.Text = "Total Profit: $" + totalProf.ToString();

                //calculate average markup for quote
                percentAve = ((totalProf / cogItem) * 100);
                percent_label.Text = "MarkUp Average: " + Math.Round(percentAve, 2).ToString() + "%";



                i++;

            }

            if (String.Equals(quote_status.Trim(), "Pending Approval by Admin"))
            {
                status_quote = 0;
                order_deliver_dtp.Enabled = false;
                order_status_CB.Enabled = false;
                delivery_dtp.Enabled = false;
            }
            else if (String.Equals(quote_status.Trim(), "Sent to Customer"))
            {
                status_quote = 1;
                order_deliver_dtp.Enabled = false;
                order_status_CB.Enabled = false;
                delivery_dtp.Enabled = false;
            }
            else if (String.Equals(quote_status.Trim(), "Approved/Accepted by Customer"))
            {
                status_quote = 2;
            }
            else if (String.Equals(quote_status.Trim(), "Denied by Customer"))
            {
                status_quote = 2;
                order_deliver_dtp.Enabled = false;
                order_status_CB.Enabled = false;
                delivery_dtp.Enabled = false;
            }
            else if (String.Equals(quote_status.Trim(), "Return For Changes"))
            {
                status_quote = 4;
                order_deliver_dtp.Enabled = false;
                order_status_CB.Enabled = false;
                delivery_dtp.Enabled = false;
            }
            else
            {
                status_quote = 0;
                order_deliver_dtp.Enabled = false;
                order_status_CB.Enabled = false;
                delivery_dtp.Enabled = false;
            }

            quote_status_CB.SelectedIndex = status_quote;


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

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    var currentRow = worksheet.Rows[row + i];
                    //currentRow.Cells[1].SetValue(dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[0].Value.ToString());
                    string item = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    string sku = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string provider = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    string units = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    int qty = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                    double cog = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    double sog = Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                    double total = Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
                    currentRow.Cells[1].SetValue(item);
                    currentRow.Cells[2].SetValue(sku);
                    currentRow.Cells[3].SetValue(provider);
                    currentRow.Cells[4].SetValue(units);
                    currentRow.Cells[5].SetValue(qty);
                    currentRow.Cells[6].SetValue(cog);
                    currentRow.Cells[7].SetValue(sog);
                    currentRow.Cells[8].SetValue(total);

                }

                // Calculate formulas in worksheet.
                worksheet.Calculate();

                workbook.Save(saveFileDialog.FileName);
            }




        }

        private void Pdf_btn_Click(object sender, EventArgs e)
        {

        }

        private void quote_status_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string newStatus = (String)quote_status_CB.SelectedItem;

            if (String.Equals(newStatus, quote_status))
            {

            }
            else
            {
                string result = "";
                string updateQry = @"UPDATE tb_activity SET quote_status=@quote_status WHERE id_activity=" + activityID + " ";
                string statChange;
                try
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=192.168.1.32;Initial Catalog=BS_ACTIVITY;User ID=sa;Password=2000lomaland"))
                    {
                        using (SqlCommand comm = new SqlCommand(updateQry, conn))
                        {
                            comm.Connection = conn;
                            conn.Open();

                            comm.Parameters.Add("@quote_status", SqlDbType.NChar).Value = newStatus;
                            comm.ExecuteNonQuery();


                        }
                    }
                }
                catch (Exception ex)
                {
                    result = ex.Message.ToString();
                    MessageBox.Show(result);
                }

            }
            if (String.Equals(newStatus, "Approved/Accepted by Customer"))
            {
                order_deliver_dtp.Enabled = true;
                order_status_CB.Enabled = true;

            }
            else
            {
                order_deliver_dtp.Enabled = false;
                order_status_CB.Enabled = false;
                delivery_dtp.Enabled = false;
            }


        }

        private void order_deliver_dtp_ValueChanged(object sender, EventArgs e)
        {
            string result = "";
            string updateQry = @"UPDATE tb_activity SET submit_date=@submitDate WHERE id_activity=" + activityID + " ";
            string statChange;
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=192.168.1.32;Initial Catalog=BS_ACTIVITY;User ID=sa;Password=2000lomaland"))
                {
                    using (SqlCommand comm = new SqlCommand(updateQry, conn))
                    {
                        comm.Connection = conn;
                        conn.Open();

                        comm.Parameters.Add("@submitDate", SqlDbType.Date).Value = order_deliver_dtp.Value.Date;
                        comm.ExecuteNonQuery();


                    }
                }
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
                MessageBox.Show(result);
            }
        }

        private void order_status_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string newOrderStatus = (String)order_status_CB.SelectedItem;

            if (String.Equals(newOrderStatus, order_status))
            {

            }
            else
            {
                string result = "";
                string updateQry = @"UPDATE tb_activity SET order_status=@order_status WHERE id_activity=" + activityID + " ";
                string statChange;
                try
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=192.168.1.32;Initial Catalog=BS_ACTIVITY;User ID=sa;Password=2000lomaland"))
                    {
                        using (SqlCommand comm = new SqlCommand(updateQry, conn))
                        {
                            comm.Connection = conn;
                            conn.Open();

                            comm.Parameters.Add("@order_status", SqlDbType.NChar).Value = newOrderStatus;
                            comm.ExecuteNonQuery();


                        }
                    }
                }
                catch (Exception ex)
                {
                    result = ex.Message.ToString();
                    MessageBox.Show(result);
                }

            }
            if (String.Equals(newOrderStatus, "Expected Delivery Date") || String.Equals(newOrderStatus, "Date Delivered"))
            {
               // order_deliver_dtp.Enabled = true;
                //order_status_CB.Enabled = true;
                delivery_dtp.Enabled = true;

            }

        }

        private void delivery_dtp_ValueChanged(object sender, EventArgs e)
        {
            string result = "";
            string updateQry = @"UPDATE tb_activity SET delivery_order=@deliveryOrder WHERE id_activity=" + activityID + " ";
            string statChange;
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=192.168.1.32;Initial Catalog=BS_ACTIVITY;User ID=sa;Password=2000lomaland"))
                {
                    using (SqlCommand comm = new SqlCommand(updateQry, conn))
                    {
                        comm.Connection = conn;
                        conn.Open();

                        comm.Parameters.Add("@deliveryOrder", SqlDbType.Date).Value = delivery_dtp.Value.Date; 
                        comm.ExecuteNonQuery();


                    }
                }
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
                MessageBox.Show(result);
            }
        }
    }
}
  
