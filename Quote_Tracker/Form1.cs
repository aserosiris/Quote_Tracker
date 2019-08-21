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
    public partial class Form1 : Form
    {
        SqlDataReader reader;
        public static string user_name;
        public static int user_id;
        public static string user_role;
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            String result = "";
            //Connection String   
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=192.168.1.32;Initial Catalog=BS_ACTIVITY;User ID=sa;Password=2000lomaland");
                SqlCommand cmd = new SqlCommand("select * from tb_users where email=@uid and password=@password", con);
                con.Open();
                cmd.Parameters.AddWithValue("@uid", email_textBox.Text.ToString() + "@blueskymedsupply.com");
                cmd.Parameters.AddWithValue("@Password", password_textBox.Text.ToString());

                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["password"].ToString().Trim().Equals(password_textBox.Text.ToString(), StringComparison.InvariantCulture))
                    {
                        // UserInfo.empid = reader["EmpId"].ToString();
                        // reader["full_name"].ToString().Trim();

                        result = "1";
                    }
                    else
                        result = "Invalid credentials";
                }
                else
                {
                    result = "Connection failed";

                    reader.Close();
                    cmd.Dispose();
                    con.Close();

                }
            }

            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }

            

            if (result == "1")
            {

                loginFun();
                
            }
            else
            {
                MessageBox.Show("Please enter Correct Username and Password");
            }
        }

        private void loginFun()
        {
            user_name = reader["fullname"].ToString().Trim();
            user_id = Convert.ToInt32(reader["id"]);
            user_role = reader["role"].ToString().Trim();
            mainForm settingsForm = new mainForm();
            settingsForm.Show();
            this.Hide();
        }


}
    }

