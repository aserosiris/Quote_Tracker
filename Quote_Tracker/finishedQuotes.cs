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
    public partial class finishedQuotes : Form
    {
        public finishedQuotes()
        {
            
            InitializeComponent();
        }
        public static string activityIDFinished = "";
        private void FinishedQuotes_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd");
            string result = "";

            if(Form1.user_role == "Admin") {

                string view_query = "SELECT * FROM Activity_overview WHERE  Status = 'Finished'";
                //string view_query2 = "SELECT status, title, description FROM tb_activity WHERE id_user =" + Form1.user_id + " AND status = 'pending' OR status = 'Overdue'";
                //string actQuery = @"UPDATE tb_activity SET status = 'Overdue' WHERE id_user = @userID AND end_date <= @datecomp and status <>'Finished';";

                using (var connection = new SqlConnection(@"Data Source=192.168.1.32;Initial Catalog=BS_ACTIVITY;User ID=sa;Password=2000lomaland"))
                using (var adapter = new SqlDataAdapter(view_query, connection))
                {
                    var table = new DataTable();
                    table.Columns.Add("Created By");
                    table.Columns.Add("Quote Status");
                    table.Columns.Add("id_activity");
                    table.Columns.Add("id");
                    table.Columns.Add("Status");
                    table.Columns.Add("Client Name");
                    table.Columns.Add("Title");
                    table.Columns.Add("Estimated Date of Completion");
                    table.Columns.Add("Items Quoted");
                    


                    adapter.Fill(table);
                    this.dgv_finished.DataSource = table;
                }

            }
            else
            {
                string view_query = "SELECT * FROM Activity_overview WHERE id =" + Form1.user_id + " AND Status = 'Finished'";
                //string view_query2 = "SELECT status, title, description FROM tb_activity WHERE id_user =" + Form1.user_id + " AND status = 'pending' OR status = 'Overdue'";
                string actQuery = @"UPDATE tb_activity SET status = 'Overdue' WHERE id_user = @userID AND end_date <= @datecomp and status <>'Finished';";
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
                            comm.Parameters.Add("@datecomp", SqlDbType.Date).Value = myDateTime.ToString("yyyy-MM-dd");

                            comm.ExecuteNonQuery();



                        }
                    }
                }
                catch (Exception ex)
                {
                    result = ex.Message.ToString();
                    MessageBox.Show(result);
                }

                using (var connection = new SqlConnection(@"Data Source=192.168.1.32;Initial Catalog=BS_ACTIVITY;User ID=sa;Password=2000lomaland"))
                using (var adapter = new SqlDataAdapter(view_query, connection))
                {
                    var table = new DataTable();
                    table.Columns.Add("id_activity");
                    table.Columns.Add("id");
                    table.Columns.Add("Status");
                    table.Columns.Add("Client Name");
                    table.Columns.Add("Title");
                    table.Columns.Add("Estimated Date of Completion");
                    table.Columns.Add("Items Quoted");
                    table.Columns.Add("Quote Status");


                    adapter.Fill(table);
                    this.dgv_finished.DataSource = table;
                }

            }

            
            


        }

        private void Dgv_finished_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_finished.Rows[e.RowIndex];
                activityIDFinished = row.Cells["id_activity"].Value.ToString();
                FinishedViewer done = new FinishedViewer();
                done.Show();
            }
        }
    }


}
