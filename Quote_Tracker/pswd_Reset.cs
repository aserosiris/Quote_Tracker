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
    public partial class pswd_Reset : Form
    {
        public pswd_Reset()
        {
            InitializeComponent();
        }

        SqlDataReader reader;
        public static string user_name;
        public static int user_id;
        public static string user_role;

        private void Pswd_Reset_Load(object sender, EventArgs e)
        {

        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            String result = "";
            try
            {

                
            SqlConnection con = new SqlConnection(@"Data Source=192.168.1.32;Initial Catalog=BS_ACTIVITY;User ID=sa;Password=2000lomaland");
            SqlCommand cmd = new SqlCommand("select * from tb_users where email=@uid and password=@password", con);
            con.Open();
            cmd.Parameters.AddWithValue("@uid", user_name_txtBox.Text.ToString() + "@blueskymedsupply.com");
            cmd.Parameters.AddWithValue("@Password", current_pwd_txtBox.Text.ToString());

            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (reader["password"].ToString().Trim().Equals(current_pwd_txtBox.Text.ToString(), StringComparison.InvariantCulture))
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

                reset();

            }
            else
            {
                MessageBox.Show("Please enter Correct Username and Password");
            }

        }

        private void reset()
        {
            String result = "";
            if (new_pwd_txtbox.Text.ToString() != confirm_pwd_txtBox.Text.ToString())
            {
                MessageBox.Show("New Password is does not mach");
            }
            else
            {
                try
                {


                    SqlConnection con = new SqlConnection(@"Data Source=192.168.1.32;Initial Catalog=BS_ACTIVITY;User ID=sa;Password=2000lomaland");
                    SqlCommand cmd = new SqlCommand("UPDATE tb_users SET password=@password where email=@uid ", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@Password", new_pwd_txtbox.Text.ToString());
                    cmd.Parameters.AddWithValue("@uid", user_name_txtBox.Text.ToString() + "@blueskymedsupply.com");


                    reader = cmd.ExecuteReader();
                }

                catch (Exception ex)
                {
                    result = ex.Message.ToString();
                }
                MessageBox.Show("Password Changed!");

                this.Close();

            }
        }
    }
}
