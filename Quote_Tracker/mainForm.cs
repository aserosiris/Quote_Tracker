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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        public static string activityIDEdit = "";
        public static int id_activity_row = 0;
        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd");
            string result = "";
            label1.Text = "Welcome " + Form1.user_name;
            string view_query = "SELECT * FROM Activity_overview WHERE id =" + Form1.user_id + " AND Status = 'pending' OR Status = 'Overdue'";

            string actQuery = @"UPDATE tb_activity SET status = 'Overdue' WHERE id_user = @userID AND end_date <= @datecomp;";
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


                adapter.Fill(table);
                this.activities_dgv.DataSource = table;
            }
        }

        public void reloadData()
        {
            string view_query = "SELECT * FROM Activity_overview WHERE id =" + Form1.user_id + " AND Status = 'pending' OR Status = 'Overdue'";
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


                DataTable tableRefresh = new DataTable();
                adapter.Fill(tableRefresh);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = tableRefresh;
                activities_dgv.DataSource = bSource;
                connection.Close();
            }
            


            
        }

        private void Activity_new_btn_Click(object sender, EventArgs e)
        {
            NewActivity makeNew = new NewActivity();
            makeNew.Show();
        }

        private void Edit_activity_btn_Click(object sender, EventArgs e)
        {
            Edit_Activity goEdit = new Edit_Activity();
            goEdit.Show();
        }

        private void Activities_dgv_SelectionChanged(object sender, EventArgs e)
        {

            //id_activity_row = Convert.ToInt32(activityIDEdit);


        }

        private void Activities_dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Activities_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.activities_dgv.Rows[e.RowIndex];
                activityIDEdit = row.Cells["id_activity"].Value.ToString();
                Edit_Activity goEdit = new Edit_Activity();
                goEdit.Show();

            }

        }
    }
}
