namespace Quote_Tracker
{
    partial class FinishedViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinishedViewer));
            this.endDateTextBox = new System.Windows.Forms.Label();
            this.Export_btn = new System.Windows.Forms.Button();
            this.start_date_label = new System.Windows.Forms.Label();
            this.client_name_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.title_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quote_tab = new System.Windows.Forms.TabPage();
            this.percent_label = new System.Windows.Forms.Label();
            this.total_label = new System.Windows.Forms.Label();
            this.total_profit_label = new System.Windows.Forms.Label();
            this.total_sale_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pdf_btn = new System.Windows.Forms.Button();
            this.quote_status_CB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.order_deliver_dtp = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.order_status_CB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.delivery_dtp = new System.Windows.Forms.DateTimePicker();
            this.quote_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.AutoSize = true;
            this.endDateTextBox.Location = new System.Drawing.Point(571, 59);
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.Size = new System.Drawing.Size(50, 13);
            this.endDateTextBox.TabIndex = 35;
            this.endDateTextBox.Text = "End date";
            // 
            // Export_btn
            // 
            this.Export_btn.Location = new System.Drawing.Point(1018, 620);
            this.Export_btn.Name = "Export_btn";
            this.Export_btn.Size = new System.Drawing.Size(142, 23);
            this.Export_btn.TabIndex = 32;
            this.Export_btn.Text = "Export to Excel";
            this.Export_btn.UseVisualStyleBackColor = true;
            this.Export_btn.Click += new System.EventHandler(this.Export_btn_Click);
            // 
            // start_date_label
            // 
            this.start_date_label.AutoSize = true;
            this.start_date_label.Location = new System.Drawing.Point(350, 59);
            this.start_date_label.Name = "start_date_label";
            this.start_date_label.Size = new System.Drawing.Size(55, 13);
            this.start_date_label.TabIndex = 31;
            this.start_date_label.Text = "Start Date";
            // 
            // client_name_label
            // 
            this.client_name_label.AutoSize = true;
            this.client_name_label.Location = new System.Drawing.Point(70, 95);
            this.client_name_label.Name = "client_name_label";
            this.client_name_label.Size = new System.Drawing.Size(64, 13);
            this.client_name_label.TabIndex = 30;
            this.client_name_label.Text = "Client Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Date Ended";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Starting Date";
            // 
            // title_textBox
            // 
            this.title_textBox.Location = new System.Drawing.Point(73, 52);
            this.title_textBox.Name = "title_textBox";
            this.title_textBox.Size = new System.Drawing.Size(191, 20);
            this.title_textBox.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Title";
            // 
            // quote_tab
            // 
            this.quote_tab.Controls.Add(this.percent_label);
            this.quote_tab.Controls.Add(this.total_label);
            this.quote_tab.Controls.Add(this.total_profit_label);
            this.quote_tab.Controls.Add(this.total_sale_label);
            this.quote_tab.Controls.Add(this.dataGridView1);
            this.quote_tab.Location = new System.Drawing.Point(4, 22);
            this.quote_tab.Name = "quote_tab";
            this.quote_tab.Padding = new System.Windows.Forms.Padding(3);
            this.quote_tab.Size = new System.Drawing.Size(1192, 436);
            this.quote_tab.TabIndex = 1;
            this.quote_tab.Text = "Quote";
            this.quote_tab.UseVisualStyleBackColor = true;
            // 
            // percent_label
            // 
            this.percent_label.AutoSize = true;
            this.percent_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.percent_label.Location = new System.Drawing.Point(854, 407);
            this.percent_label.Name = "percent_label";
            this.percent_label.Size = new System.Drawing.Size(23, 20);
            this.percent_label.TabIndex = 18;
            this.percent_label.Text = "%";
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.total_label.Location = new System.Drawing.Point(854, 367);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(44, 20);
            this.total_label.TabIndex = 17;
            this.total_label.Text = "Total";
            // 
            // total_profit_label
            // 
            this.total_profit_label.AutoSize = true;
            this.total_profit_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.total_profit_label.Location = new System.Drawing.Point(698, 407);
            this.total_profit_label.Name = "total_profit_label";
            this.total_profit_label.Size = new System.Drawing.Size(81, 20);
            this.total_profit_label.TabIndex = 16;
            this.total_profit_label.Text = "TotalProfit";
            // 
            // total_sale_label
            // 
            this.total_sale_label.AutoSize = true;
            this.total_sale_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.total_sale_label.Location = new System.Drawing.Point(698, 367);
            this.total_sale_label.Name = "total_sale_label";
            this.total_sale_label.Size = new System.Drawing.Size(80, 20);
            this.total_sale_label.TabIndex = 9;
            this.total_sale_label.Text = "TotalCOG";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1162, 286);
            this.dataGridView1.TabIndex = 15;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.quote_tab);
            this.tabControl1.Location = new System.Drawing.Point(41, 152);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 462);
            this.tabControl1.TabIndex = 24;
            // 
            // pdf_btn
            // 
            this.pdf_btn.Location = new System.Drawing.Point(1018, 649);
            this.pdf_btn.Name = "pdf_btn";
            this.pdf_btn.Size = new System.Drawing.Size(140, 23);
            this.pdf_btn.TabIndex = 36;
            this.pdf_btn.Text = "Export to PDF";
            this.pdf_btn.UseVisualStyleBackColor = true;
            this.pdf_btn.Click += new System.EventHandler(this.Pdf_btn_Click);
            // 
            // quote_status_CB
            // 
            this.quote_status_CB.FormattingEnabled = true;
            this.quote_status_CB.Items.AddRange(new object[] {
            "Pending Approval by Admin",
            "Sent to Customer",
            "Approved/Accepted by Customer",
            "Denied by Customer",
            "Return For Changes"});
            this.quote_status_CB.Location = new System.Drawing.Point(753, 39);
            this.quote_status_CB.Name = "quote_status_CB";
            this.quote_status_CB.Size = new System.Drawing.Size(230, 21);
            this.quote_status_CB.TabIndex = 37;
            this.quote_status_CB.SelectedIndexChanged += new System.EventHandler(this.quote_status_CB_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(757, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Quote Status";
            // 
            // order_deliver_dtp
            // 
            this.order_deliver_dtp.Location = new System.Drawing.Point(753, 87);
            this.order_deliver_dtp.Name = "order_deliver_dtp";
            this.order_deliver_dtp.Size = new System.Drawing.Size(200, 20);
            this.order_deliver_dtp.TabIndex = 39;
            this.order_deliver_dtp.ValueChanged += new System.EventHandler(this.order_deliver_dtp_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(757, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Order Submitted";
            // 
            // order_status_CB
            // 
            this.order_status_CB.FormattingEnabled = true;
            this.order_status_CB.Items.AddRange(new object[] {
            "Expected Delivery Date",
            "Date Delivered",
            "Not Applicable"});
            this.order_status_CB.Location = new System.Drawing.Point(1018, 39);
            this.order_status_CB.Name = "order_status_CB";
            this.order_status_CB.Size = new System.Drawing.Size(192, 21);
            this.order_status_CB.TabIndex = 41;
            this.order_status_CB.SelectedIndexChanged += new System.EventHandler(this.order_status_CB_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1015, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Order Status";
            // 
            // delivery_dtp
            // 
            this.delivery_dtp.Location = new System.Drawing.Point(1018, 87);
            this.delivery_dtp.Name = "delivery_dtp";
            this.delivery_dtp.Size = new System.Drawing.Size(200, 20);
            this.delivery_dtp.TabIndex = 43;
            this.delivery_dtp.ValueChanged += new System.EventHandler(this.delivery_dtp_ValueChanged);
            // 
            // FinishedViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 704);
            this.Controls.Add(this.delivery_dtp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.order_status_CB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.order_deliver_dtp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quote_status_CB);
            this.Controls.Add(this.pdf_btn);
            this.Controls.Add(this.endDateTextBox);
            this.Controls.Add(this.Export_btn);
            this.Controls.Add(this.start_date_label);
            this.Controls.Add(this.client_name_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FinishedViewer";
            this.Text = "FinishedViewer";
            this.Load += new System.EventHandler(this.FinishedViewer_Load);
            this.quote_tab.ResumeLayout(false);
            this.quote_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label endDateTextBox;
        private System.Windows.Forms.Button Export_btn;
        private System.Windows.Forms.Label start_date_label;
        private System.Windows.Forms.Label client_name_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox title_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage quote_tab;
        private System.Windows.Forms.Label percent_label;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Label total_profit_label;
        private System.Windows.Forms.Label total_sale_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button pdf_btn;
        private System.Windows.Forms.ComboBox quote_status_CB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker order_deliver_dtp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox order_status_CB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker delivery_dtp;
    }
}