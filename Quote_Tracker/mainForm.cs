using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome " + Form1.user_name;
        }

        private void Activity_new_btn_Click(object sender, EventArgs e)
        {
            NewActivity makeNew = new NewActivity();
            makeNew.Show();
        }
    }
}
