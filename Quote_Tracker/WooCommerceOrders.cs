using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Quote_Tracker
{
    public partial class WooCommerceOrders : Form
    {
        public WooCommerceOrders()
        {
            InitializeComponent();
        }

        //-Variables--------------------------
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        int client_id;
        double sumProfit = 0;
        double cogItem = 0;
        double cogTotal = 0;
        double totalProf = 0;
        int qtyOrder = 0;
        int i = 0;
        int f = 0;
        double percentAve = 0;
        //--------------------------------------------

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WooCommerceOrders_Load(object sender, EventArgs e)
        {
            

            //--------------------------------------------------------------

            Select();


            //-------------Adding month total
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //multiply qty  by cog and add the result to cogItem
                cogItem += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                total_lb.Text = "$" + cogItem.ToString();

                //adds the row total to sumprofit
                //sumProfit += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                //total_label.Text = "Total: $" + sumProfit.ToString();

                //subtract to obtain the total earnings
                //totalProf = sumProfit - cogItem;
                //total_profit_label.Text = "Total Profit: $" + totalProf.ToString();

                //calculate average markup for quote
                //percentAve = ((totalProf / cogItem) * 100);
                //percent_label.Text = "MarkUp Average: " + Math.Round(percentAve, 2).ToString() + "%";

                i++;

            

            }


        }



        private bool OpenConnection()
        {
            try
            {
                connection.Open();
               // MessageBox.Show("You are now connected!");
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenConnection();
        }

        public void Select()
        {
            string OrderID = "SELECT " +
                "p.ID AS 'Order ID'," +
                "p.post_date AS 'Purchase Date'," +
                "MAX( CASE WHEN pm.meta_key = '_billing_email'       AND p.ID = pm.post_id THEN pm.meta_value END ) AS 'Email Address'," +
                "MAX( CASE WHEN pm.meta_key = '_billing_first_name'  AND p.ID = pm.post_id THEN pm.meta_value END ) AS 'First Name'," +
                "MAX( CASE WHEN pm.meta_key = '_billing_last_name'   AND p.ID = pm.post_id THEN pm.meta_value END ) AS 'Last Name'," +
                "CASE p.post_status " +
                "WHEN 'wc-pending'    THEN 'Pending Payment' " +
                "WHEN 'wc-processing' THEN 'Processing' " +
                "WHEN 'wc-on-hold'    THEN 'On Hold' " +
                "WHEN 'wc-completed'  THEN 'Completed' " +
                "WHEN 'wc-cancelled'  THEN 'Cancelled' " +
                "WHEN 'wc-refunded'   THEN 'Refunded' " +
                "WHEN 'wc-failed'     THEN 'Failed' " +
                "ELSE 'Unknown' " +
                "END AS 'Purchase Status'," +
                "MAX( CASE WHEN pm.meta_key = '_order_total'         AND p.ID = pm.post_id THEN pm.meta_value END ) AS 'Order Total'," +
                "MAX( CASE WHEN pm.meta_key = '_paid_date'           AND p.ID = pm.post_id THEN pm.meta_value END ) AS 'Paid Date'," +
                "( SELECT GROUP_CONCAT(CONCAT(m.meta_value, ' x ', i.order_item_name) separator '</br>' ) " +
                "FROM wp_woocommerce_order_items i " +
                "JOIN wp_woocommerce_order_itemmeta m ON i.order_item_id = m.order_item_id AND meta_key = '_qty' " +
                "WHERE i.order_id = p.ID AND i.order_item_type = 'line_item') AS 'Items Ordered' " +
                "FROM  wp_posts AS p " +
                "JOIN  wp_postmeta AS pm ON p.ID = pm.post_id " +
                "JOIN  wp_woocommerce_order_items AS oi ON p.ID = oi.order_id " +
                "WHERE post_type = 'shop_order' AND post_date BETWEEN '2019-08-31' AND '2019-10-01' " +
                "GROUP BY p.ID";

            if (this.OpenConnection() == true)
            {

                /*
                MySqlCommand cmd = new MySqlCommand(OrderID, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dataGridView1.DataSource = dataReader;
                dataGridView1
                */

                MySqlDataAdapter adapter= new MySqlDataAdapter(OrderID, connection);
                DataSet DS = new DataSet();
                adapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];


                //close Connection
                this.CloseConnection();


            }
        }

    }
}
