namespace Quote_Tracker
{
    partial class NewActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewActivity));
            this.label1 = new System.Windows.Forms.Label();
            this.title_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.start_dtp = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.estimated_end_dtp = new System.Windows.Forms.DateTimePicker();
            this.client_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.description_tab = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.quote_tab = new System.Windows.Forms.TabPage();
            this.percent_label = new System.Windows.Forms.Label();
            this.total_label = new System.Windows.Forms.Label();
            this.total_profit_label = new System.Windows.Forms.Label();
            this.total_sale_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.item_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sku_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provider_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cog_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sog_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_row_btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.sog_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cog_textBox = new System.Windows.Forms.TextBox();
            this.qty_textBox = new System.Windows.Forms.TextBox();
            this.provider_textBox = new System.Windows.Forms.TextBox();
            this.sku_textBox = new System.Windows.Forms.TextBox();
            this.item_textBox = new System.Windows.Forms.TextBox();
            this.save_act_btn = new System.Windows.Forms.Button();
            this.upload_quote_btn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.description_tab.SuspendLayout();
            this.quote_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // title_textBox
            // 
            this.title_textBox.Location = new System.Drawing.Point(45, 25);
            this.title_textBox.Name = "title_textBox";
            this.title_textBox.Size = new System.Drawing.Size(191, 20);
            this.title_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Starting Date";
            // 
            // start_dtp
            // 
            this.start_dtp.Location = new System.Drawing.Point(325, 25);
            this.start_dtp.Name = "start_dtp";
            this.start_dtp.Size = new System.Drawing.Size(200, 20);
            this.start_dtp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estimated end Date";
            // 
            // estimated_end_dtp
            // 
            this.estimated_end_dtp.Location = new System.Drawing.Point(546, 28);
            this.estimated_end_dtp.Name = "estimated_end_dtp";
            this.estimated_end_dtp.Size = new System.Drawing.Size(200, 20);
            this.estimated_end_dtp.TabIndex = 5;
            // 
            // client_comboBox
            // 
            this.client_comboBox.FormattingEnabled = true;
            this.client_comboBox.Location = new System.Drawing.Point(45, 60);
            this.client_comboBox.Name = "client_comboBox";
            this.client_comboBox.Size = new System.Drawing.Size(191, 21);
            this.client_comboBox.TabIndex = 6;
            this.client_comboBox.SelectedIndexChanged += new System.EventHandler(this.Client_comboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Client";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.description_tab);
            this.tabControl1.Controls.Add(this.quote_tab);
            this.tabControl1.Location = new System.Drawing.Point(12, 102);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1066, 456);
            this.tabControl1.TabIndex = 8;
            // 
            // description_tab
            // 
            this.description_tab.Controls.Add(this.richTextBox1);
            this.description_tab.Location = new System.Drawing.Point(4, 22);
            this.description_tab.Name = "description_tab";
            this.description_tab.Padding = new System.Windows.Forms.Padding(3);
            this.description_tab.Size = new System.Drawing.Size(1058, 430);
            this.description_tab.TabIndex = 0;
            this.description_tab.Text = "Description";
            this.description_tab.UseVisualStyleBackColor = true;
            this.description_tab.Click += new System.EventHandler(this.Description_tab_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(756, 298);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // quote_tab
            // 
            this.quote_tab.Controls.Add(this.percent_label);
            this.quote_tab.Controls.Add(this.total_label);
            this.quote_tab.Controls.Add(this.total_profit_label);
            this.quote_tab.Controls.Add(this.total_sale_label);
            this.quote_tab.Controls.Add(this.dataGridView1);
            this.quote_tab.Controls.Add(this.add_row_btn);
            this.quote_tab.Controls.Add(this.label10);
            this.quote_tab.Controls.Add(this.sog_textBox);
            this.quote_tab.Controls.Add(this.label9);
            this.quote_tab.Controls.Add(this.label8);
            this.quote_tab.Controls.Add(this.label7);
            this.quote_tab.Controls.Add(this.label6);
            this.quote_tab.Controls.Add(this.label5);
            this.quote_tab.Controls.Add(this.cog_textBox);
            this.quote_tab.Controls.Add(this.qty_textBox);
            this.quote_tab.Controls.Add(this.provider_textBox);
            this.quote_tab.Controls.Add(this.sku_textBox);
            this.quote_tab.Controls.Add(this.item_textBox);
            this.quote_tab.Location = new System.Drawing.Point(4, 22);
            this.quote_tab.Name = "quote_tab";
            this.quote_tab.Padding = new System.Windows.Forms.Padding(3);
            this.quote_tab.Size = new System.Drawing.Size(1058, 430);
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
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_col,
            this.sku_col,
            this.provider_col,
            this.qty_col,
            this.cog_col,
            this.sog_col,
            this.total_col});
            this.dataGridView1.Location = new System.Drawing.Point(3, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1029, 286);
            this.dataGridView1.TabIndex = 15;
            // 
            // item_col
            // 
            this.item_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.item_col.HeaderText = "Item";
            this.item_col.Name = "item_col";
            // 
            // sku_col
            // 
            this.sku_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sku_col.HeaderText = "SKU";
            this.sku_col.Name = "sku_col";
            // 
            // provider_col
            // 
            this.provider_col.HeaderText = "Provider";
            this.provider_col.Name = "provider_col";
            // 
            // qty_col
            // 
            this.qty_col.HeaderText = "Qty";
            this.qty_col.Name = "qty_col";
            // 
            // cog_col
            // 
            this.cog_col.HeaderText = "CoG";
            this.cog_col.Name = "cog_col";
            // 
            // sog_col
            // 
            this.sog_col.HeaderText = "Sog";
            this.sog_col.Name = "sog_col";
            // 
            // total_col
            // 
            this.total_col.HeaderText = "Total";
            this.total_col.Name = "total_col";
            // 
            // add_row_btn
            // 
            this.add_row_btn.Location = new System.Drawing.Point(995, 22);
            this.add_row_btn.Name = "add_row_btn";
            this.add_row_btn.Size = new System.Drawing.Size(47, 32);
            this.add_row_btn.TabIndex = 14;
            this.add_row_btn.Text = "Add";
            this.add_row_btn.UseVisualStyleBackColor = true;
            this.add_row_btn.Click += new System.EventHandler(this.Add_row_btn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(858, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "SoG X Unit";
            // 
            // sog_textBox
            // 
            this.sog_textBox.Location = new System.Drawing.Point(858, 34);
            this.sog_textBox.Name = "sog_textBox";
            this.sog_textBox.Size = new System.Drawing.Size(78, 20);
            this.sog_textBox.TabIndex = 10;
            this.sog_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sog_textBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(753, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "CoG X Unit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(648, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Qty";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(555, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Provider";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "SKU";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Item";
            // 
            // cog_textBox
            // 
            this.cog_textBox.Location = new System.Drawing.Point(756, 34);
            this.cog_textBox.Name = "cog_textBox";
            this.cog_textBox.Size = new System.Drawing.Size(78, 20);
            this.cog_textBox.TabIndex = 4;
            this.cog_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cog_textBox_KeyPress);
            // 
            // qty_textBox
            // 
            this.qty_textBox.Location = new System.Drawing.Point(651, 34);
            this.qty_textBox.Name = "qty_textBox";
            this.qty_textBox.Size = new System.Drawing.Size(79, 20);
            this.qty_textBox.TabIndex = 3;
            this.qty_textBox.TextChanged += new System.EventHandler(this.Qty_textBox_TextChanged);
            this.qty_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Qty_textBox_KeyPress);
            // 
            // provider_textBox
            // 
            this.provider_textBox.Location = new System.Drawing.Point(558, 34);
            this.provider_textBox.Name = "provider_textBox";
            this.provider_textBox.Size = new System.Drawing.Size(87, 20);
            this.provider_textBox.TabIndex = 2;
            // 
            // sku_textBox
            // 
            this.sku_textBox.Location = new System.Drawing.Point(343, 34);
            this.sku_textBox.Name = "sku_textBox";
            this.sku_textBox.Size = new System.Drawing.Size(190, 20);
            this.sku_textBox.TabIndex = 1;
            // 
            // item_textBox
            // 
            this.item_textBox.Location = new System.Drawing.Point(49, 34);
            this.item_textBox.Name = "item_textBox";
            this.item_textBox.Size = new System.Drawing.Size(268, 20);
            this.item_textBox.TabIndex = 0;
            // 
            // save_act_btn
            // 
            this.save_act_btn.Location = new System.Drawing.Point(908, 582);
            this.save_act_btn.Name = "save_act_btn";
            this.save_act_btn.Size = new System.Drawing.Size(75, 23);
            this.save_act_btn.TabIndex = 9;
            this.save_act_btn.Text = "Save";
            this.save_act_btn.UseVisualStyleBackColor = true;
            this.save_act_btn.Click += new System.EventHandler(this.Save_act_btn_Click);
            // 
            // upload_quote_btn
            // 
            this.upload_quote_btn.Location = new System.Drawing.Point(325, 73);
            this.upload_quote_btn.Name = "upload_quote_btn";
            this.upload_quote_btn.Size = new System.Drawing.Size(155, 23);
            this.upload_quote_btn.TabIndex = 10;
            this.upload_quote_btn.Text = "Upload Quote";
            this.upload_quote_btn.UseVisualStyleBackColor = true;
            this.upload_quote_btn.Click += new System.EventHandler(this.Upload_quote_btn_Click);
            // 
            // NewActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 718);
            this.Controls.Add(this.upload_quote_btn);
            this.Controls.Add(this.save_act_btn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.client_comboBox);
            this.Controls.Add(this.estimated_end_dtp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.start_dtp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title_textBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewActivity";
            this.Text = "New Activity";
            this.Load += new System.EventHandler(this.NewActivity_Load);
            this.tabControl1.ResumeLayout(false);
            this.description_tab.ResumeLayout(false);
            this.quote_tab.ResumeLayout(false);
            this.quote_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox title_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker start_dtp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker estimated_end_dtp;
        private System.Windows.Forms.ComboBox client_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage description_tab;
        private System.Windows.Forms.TabPage quote_tab;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox sog_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cog_textBox;
        private System.Windows.Forms.TextBox qty_textBox;
        private System.Windows.Forms.TextBox provider_textBox;
        private System.Windows.Forms.TextBox sku_textBox;
        private System.Windows.Forms.TextBox item_textBox;
        private System.Windows.Forms.Button add_row_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn sku_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn provider_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn cog_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn sog_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_col;
        private System.Windows.Forms.Label total_profit_label;
        private System.Windows.Forms.Label total_sale_label;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Label percent_label;
        private System.Windows.Forms.Button save_act_btn;
        private System.Windows.Forms.Button upload_quote_btn;
    }
}