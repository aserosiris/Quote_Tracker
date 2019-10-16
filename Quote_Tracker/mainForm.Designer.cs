namespace Quote_Tracker
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.activity_new_btn = new System.Windows.Forms.Button();
            this.view_finished_btn = new System.Windows.Forms.Button();
            this.activities_dgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_activities = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.wc_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.activities_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_activities)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // activity_new_btn
            // 
            this.activity_new_btn.Location = new System.Drawing.Point(12, 32);
            this.activity_new_btn.Name = "activity_new_btn";
            this.activity_new_btn.Size = new System.Drawing.Size(141, 23);
            this.activity_new_btn.TabIndex = 1;
            this.activity_new_btn.Text = "New Activity";
            this.activity_new_btn.UseVisualStyleBackColor = true;
            this.activity_new_btn.Click += new System.EventHandler(this.Activity_new_btn_Click);
            // 
            // view_finished_btn
            // 
            this.view_finished_btn.Location = new System.Drawing.Point(171, 32);
            this.view_finished_btn.Name = "view_finished_btn";
            this.view_finished_btn.Size = new System.Drawing.Size(141, 23);
            this.view_finished_btn.TabIndex = 3;
            this.view_finished_btn.Text = "View Finished";
            this.view_finished_btn.UseVisualStyleBackColor = true;
            this.view_finished_btn.Click += new System.EventHandler(this.View_finished_btn_Click);
            // 
            // activities_dgv
            // 
            this.activities_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activities_dgv.Location = new System.Drawing.Point(16, 92);
            this.activities_dgv.Name = "activities_dgv";
            this.activities_dgv.Size = new System.Drawing.Size(756, 309);
            this.activities_dgv.TabIndex = 4;
            this.activities_dgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Activities_dgv_CellContentDoubleClick);
            this.activities_dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Activities_dgv_CellDoubleClick);
            this.activities_dgv.SelectionChanged += new System.EventHandler(this.Activities_dgv_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pending Quotes";
            // 
            // dgv_activities
            // 
            this.dgv_activities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_activities.Location = new System.Drawing.Point(16, 447);
            this.dgv_activities.Name = "dgv_activities";
            this.dgv_activities.Size = new System.Drawing.Size(756, 281);
            this.dgv_activities.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Activities";
            // 
            // wc_btn
            // 
            this.wc_btn.Location = new System.Drawing.Point(642, 32);
            this.wc_btn.Name = "wc_btn";
            this.wc_btn.Size = new System.Drawing.Size(116, 23);
            this.wc_btn.TabIndex = 8;
            this.wc_btn.Text = "WooCommerce";
            this.wc_btn.UseVisualStyleBackColor = true;
            this.wc_btn.Click += new System.EventHandler(this.Wc_btn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 764);
            this.Controls.Add(this.wc_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_activities);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.activities_dgv);
            this.Controls.Add(this.view_finished_btn);
            this.Controls.Add(this.activity_new_btn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activities_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_activities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button activity_new_btn;
        private System.Windows.Forms.Button view_finished_btn;
        private System.Windows.Forms.DataGridView activities_dgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_activities;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button wc_btn;
    }
}