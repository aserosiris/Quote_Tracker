using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quote_Tracker
{


  
    public partial class Edit_Activity : Form
    {
        public Edit_Activity()
        {
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

        private void Edit_Activity_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(mainForm.activityIDEdit);
            DateTime myDateTime = DateTime.Now;
            string result = "";

            string actQuery = @"SELECT * FROM tb_activity WHERE id_activity = @idactivity";
            string client_name = @"SELECT * FROM tb_client_info WHERE Id_client = @id_client";
            string querytotals = @"SELECT qty AS  Qty, cog AS CoG, sog AS SoG, total AS Total FROM tb_quote WHERE id_quote =" + Convert.ToInt32(mainForm.activityIDEdit) + "";


            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=192.168.1.32;Initial Catalog=BS_ACTIVITY;User ID=sa;Password=2000lomaland"))
                {
                    using (SqlCommand comm = new SqlCommand(actQuery, conn))
                    {
                        comm.Connection = conn;
                        conn.Open();

                        comm.Parameters.Add("@idactivity", SqlDbType.Int).Value = Convert.ToInt32(mainForm.activityIDEdit);
                        comm.ExecuteNonQuery();
                        reader = comm.ExecuteReader();
                        reader.Read();

                        client_id = Convert.ToInt32(reader["id_client"]);
                        start_date_label.Text = reader["start_date"].ToString();
                        title_textBox.Text = reader["title"].ToString();
                        richTextBox1.Text = reader["description"].ToString();
                        statusCLB.Items.Add(reader["status"].ToString());
                        statusCLB.SetItemChecked(1, true);

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
                string getQuote = @"SELECT item AS Item, sku AS SKU, provider AS Provider, qty AS  Qty, cog AS CoG, sog AS SoG, total AS Total FROM tb_quote WHERE id_quote ="+ Convert.ToInt32(mainForm.activityIDEdit) +"";
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
            
            foreach(DataGridViewRow row in dataGridView1.Rows)
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

        private void Update_btn_Click(object sender, EventArgs e)
        {

            /*
            string result = "";
            string quoteQuery;
            string idQuery;
            string actQuery = @"INSERT INTO tb_activity  VALUES (@userid, @idclient, @title, @startdate, @enddate, @description, @status );";
            int lastID = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=192.168.1.32;Initial Catalog=BS_ACTIVITY;User ID=sa;Password=2000lomaland"))
                {
                    using (SqlCommand comm = new SqlCommand(actQuery, conn))
                    {
                        comm.Connection = conn;
                        conn.Open();
                        string stat = "pending";

                        comm.Parameters.Add("@userID", SqlDbType.Int).Value = Form1.user_id;
                        //comm.Parameters.Add("@idclient", SqlDbType.Int).Value = clientid;
                        comm.Parameters.Add("@title", SqlDbType.NChar).Value = title_textBox.Text.ToString();
                        //comm.Parameters.Add("@startdate", SqlDbType.Date).Value = start_dtp.Value.Date;
                        comm.Parameters.Add("@enddate", SqlDbType.Date).Value = estimated_end_dtp.Value.Date;
                        comm.Parameters.Add("@description", SqlDbType.Text).Value = richTextBox1.Text.ToString();
                        comm.Parameters.Add("@status", SqlDbType.NChar).Value = stat;
                        comm.ExecuteNonQuery();


                        idQuery = @"SELECT TOP 1 id_activity FROM tb_activity ORDER BY id_activity DESC";
                        comm.CommandText = idQuery;
                        //reader = comm.ExecuteReader();
                        lastID = Convert.ToInt32(comm.ExecuteScalar());


                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            quoteQuery = @"INSERT INTO tb_quote (id_quote, item, sku, provider, qty, cog, sog, total) VALUES (" +
                                lastID + ", '"
                                + dataGridView1.Rows[i].Cells[0].Value + "', '"
                                + dataGridView1.Rows[i].Cells[1].Value + "', '"
                                + dataGridView1.Rows[i].Cells[2].Value + "', "
                                + Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) + ", "
                                + Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value) + ", "
                                + Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value) + ", "
                                + Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value) + ");";
                            comm.CommandText = quoteQuery;
                            comm.ExecuteNonQuery();
                        }


                    }
                }
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
                MessageBox.Show(result);
            }
            */

            mainForm obj = (mainForm)Application.OpenForms["mainForm"];

            obj.reloadData();


            MessageBox.Show("Activity Saved!");
            this.Close();
        }


       

        private void Add_row_btn_Click(object sender, EventArgs e)
        {
            string result = "";
            string newItemQuote = @"INSERT INTO tb_quote (id_quote, item, sku, provider, qty, cog, sog, total) VALUES (@id_quote, @item, @sku, @provider, @qty, @cog, @sog, @total)";
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=192.168.1.32;Initial Catalog=BS_ACTIVITY;User ID=sa;Password=2000lomaland"))
                {
                    using (SqlCommand comm = new SqlCommand(newItemQuote, conn))
                    {
                        comm.Connection = conn;
                        conn.Open();
                        string stat = "pending";

                        comm.Parameters.Add("@id_quote", SqlDbType.Int).Value = Convert.ToInt32(mainForm.activityIDEdit);
                        comm.Parameters.Add("@item", SqlDbType.NChar).Value = item_textBox.Text.ToString();
                        comm.Parameters.Add("@sku", SqlDbType.NChar).Value = sku_textBox.Text.ToString();
                        comm.Parameters.Add("@provider", SqlDbType.NChar).Value = provider_textBox.Text.ToString();
                        comm.Parameters.Add("@qty", SqlDbType.Int).Value = Convert.ToInt32(qty_textBox.Text);
                        comm.Parameters.Add("@cog", SqlDbType.Decimal).Value = Convert.ToDecimal(cog_textBox.Text);
                        comm.Parameters.Add("@sog", SqlDbType.Decimal).Value = Convert.ToDecimal(sog_textBox.Text);
                        comm.Parameters.Add("@total", SqlDbType.Decimal).Value = Convert.ToDecimal(sog_textBox.Text)* Convert.ToInt32(qty_textBox.Text);
                        comm.ExecuteNonQuery();

                        item_textBox.Clear();
                        sku_textBox.Clear();
                        provider_textBox.Clear();
                        qty_textBox.Clear();
                        cog_textBox.Clear();
                        sog_textBox.Clear();




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
                string getQuote = @"SELECT item AS Item, sku AS SKU, provider AS Provider, qty AS  Qty, cog AS CoG, sog AS SoG, total AS Total FROM tb_quote WHERE id_quote =" + Convert.ToInt32(mainForm.activityIDEdit) + "";
                using (SqlConnection conn = new SqlConnection(@"Data Source=192.168.1.32;Initial Catalog=BS_ACTIVITY;User ID=sa;Password=2000lomaland"))
                {
                    using (var adapter = new SqlDataAdapter(getQuote, conn))
                    {
                        DataTable tableRefresh = new DataTable();
                        adapter.Fill(tableRefresh);
                        BindingSource bSource = new BindingSource();
                        bSource.DataSource = tableRefresh;


                        dataGridView1.DataSource = bSource;
                        conn.Close();


                    }
                }
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
                MessageBox.Show(result);
            }
            cogItem = 0;
            sumProfit = 0;
            totalProf = 0;
            f = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                cogItem += Convert.ToDouble(dataGridView1.Rows[f].Cells[3].Value) * Convert.ToDouble(dataGridView1.Rows[f].Cells[4].Value);
                total_sale_label.Text = "Total CoG: $" + cogItem.ToString();

                //adds the row total to sumprofit
                sumProfit += Convert.ToDouble(dataGridView1.Rows[f].Cells[6].Value);
                total_label.Text = "Total: $" + sumProfit.ToString();

                //subtract to obtain the total earnings
                totalProf = sumProfit - cogItem;
                total_profit_label.Text = "Total Profit: $" + totalProf.ToString();

                //calculate average markup for quote
                percentAve = ((totalProf / cogItem) * 100);
                percent_label.Text = "MarkUp Average: " + Math.Round(percentAve, 2).ToString() + "%";



                f++;
            }

        }

        //METHODS TO HANDLE USER INPUT TO ONLY ALLOW NUMERIC INPUT WITH ONE "." 

        private void Qty_textBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Cog_textBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Sog_textBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        //END OF NUMERIC VALIDATION
    }

}
