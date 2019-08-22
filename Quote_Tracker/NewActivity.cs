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

namespace Quote_Tracker
{
    public partial class NewActivity : Form
    {
        public NewActivity()
        {
            InitializeComponent();
        }
        //Variables
        SqlConnection conn = new SqlConnection(@"Data Source=192.168.1.32;Initial Catalog=BS_ACTIVITY;User ID=sa;Password=2000lomaland");
        double sumProfit = 0;
        double cogItem = 0;
        double totalProf = 0;
        int i = 0;
        double percentAve = 0;
        int clientid;

            private void Client_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = client_comboBox.SelectedValue.ToString();

             clientid = Convert.ToInt32(client_comboBox.SelectedIndex) + 1;


        }

        private void NewActivity_Load(object sender, EventArgs e)
        {
            
            conn.Open();
            SqlCommand sc = new SqlCommand("select Id_client, client_name from tb_client_info", conn);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("client_name", typeof(string));
            dt.Columns.Add("Id_client", typeof(int));
            dt.Load(reader);
            client_comboBox.ValueMember = "Id_client";
            client_comboBox.DisplayMember = "client_name";
            client_comboBox.DataSource = dt;

            conn.Close();
        }

        private void Description_tab_Click(object sender, EventArgs e)
        {

        }

        private void Add_row_btn_Click(object sender, EventArgs e)
        {

            
            DataTable quote = new DataTable();
            quote.Columns.Add("Item");
            quote.Columns.Add("SKU");
            quote.Columns.Add("Provider");
            quote.Columns.Add("Qty");
            quote.Columns.Add("CoG");
            quote.Columns.Add("SoG");
            quote.Columns.Add("Total");

           


            if (item_textBox.Text != "" && sku_textBox.Text != "" && provider_textBox.Text != "" && qty_textBox.Text != "" && cog_textBox.Text != "" && sog_textBox.Text != "")
            {

                DataRow row = quote.NewRow();
                row["Item"] = item_textBox.Text;
                row["SKU"] = sku_textBox.Text;
                row["Provider"] = provider_textBox.Text;
                row["Qty"] = qty_textBox.Text;
                row["CoG"] = cog_textBox.Text;
                row["SoG"] = sog_textBox.Text;
                row["Total"] = (Convert.ToDouble(sog_textBox.Text) * Convert.ToDouble(qty_textBox.Text));
                //row["Total"] = total_textBox.Text;

                quote.Rows.Add(row);

                foreach (DataRow dRow in quote.Rows)
                {
                    int num = dataGridView1.Rows.Add();
                    dataGridView1.Rows[num].Cells[0].Value = dRow["Item"].ToString();
                    dataGridView1.Rows[num].Cells[1].Value = dRow["SKU"].ToString();
                    dataGridView1.Rows[num].Cells[2].Value = dRow["Provider"].ToString();
                    dataGridView1.Rows[num].Cells[3].Value = dRow["Qty"].ToString();
                    dataGridView1.Rows[num].Cells[4].Value = dRow["CoG"].ToString();
                    dataGridView1.Rows[num].Cells[5].Value = dRow["SoG"].ToString();
                    dataGridView1.Rows[num].Cells[6].Value = dRow["Total"].ToString();

                }

                item_textBox.Clear();
                sku_textBox.Clear();
                provider_textBox.Clear();
                qty_textBox.Clear();
                cog_textBox.Clear();
                sog_textBox.Clear();

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
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
          
           

        }

        private void Qty_textBox_TextChanged(object sender, EventArgs e)
        {
          
        }
        //METHODS TO HANDLE USER INPUT TO ONLY ALLOW NUMERIC INPUT WITH ONE "." 
        private void Qty_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Cog_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Sog_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
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
        private void Save_act_btn_Click(object sender, EventArgs e)
        {
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
                        comm.Parameters.Add("@idclient", SqlDbType.Int).Value = clientid;
                        comm.Parameters.Add("@title", SqlDbType.NChar).Value = title_textBox.Text.ToString();
                        comm.Parameters.Add("@startdate", SqlDbType.Date).Value = start_dtp.Value.Date;
                        comm.Parameters.Add("@enddate", SqlDbType.Date).Value = estimated_end_dtp.Value.Date;
                        comm.Parameters.Add("@description", SqlDbType.Text).Value = richTextBox1.Text.ToString();
                        comm.Parameters.Add("@status", SqlDbType.NChar).Value = stat;
                        comm.ExecuteNonQuery();


                        idQuery = @"SELECT TOP 1 id_activity FROM tb_activity ORDER BY id_activity DESC";
                        comm.CommandText = idQuery;
                        //reader = comm.ExecuteReader();
                        lastID = Convert.ToInt32(comm.ExecuteScalar());


                        for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                        {
                            quoteQuery = @"INSERT INTO tb_quote (id_quote, item, sku, provider, qty, cog, sog, total) VALUES ("+
                                lastID +", '"
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
            catch(Exception ex)
            {
                result = ex.Message.ToString();
                MessageBox.Show(result);
            }

            MessageBox.Show("Activity Saved!");
            this.Close();
        }

        
    }

   
}
