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
            this.label1 = new System.Windows.Forms.Label();
            this.activity_new_btn = new System.Windows.Forms.Button();
            this.edit_activity_btn = new System.Windows.Forms.Button();
            this.view_finished_btn = new System.Windows.Forms.Button();
            this.activities_dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.activities_dgv)).BeginInit();
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
            // edit_activity_btn
            // 
            this.edit_activity_btn.Location = new System.Drawing.Point(159, 32);
            this.edit_activity_btn.Name = "edit_activity_btn";
            this.edit_activity_btn.Size = new System.Drawing.Size(141, 23);
            this.edit_activity_btn.TabIndex = 2;
            this.edit_activity_btn.Text = "Edit Existing";
            this.edit_activity_btn.UseVisualStyleBackColor = true;
            this.edit_activity_btn.Click += new System.EventHandler(this.Edit_activity_btn_Click);
            // 
            // view_finished_btn
            // 
            this.view_finished_btn.Location = new System.Drawing.Point(306, 32);
            this.view_finished_btn.Name = "view_finished_btn";
            this.view_finished_btn.Size = new System.Drawing.Size(141, 23);
            this.view_finished_btn.TabIndex = 3;
            this.view_finished_btn.Text = "View Finished";
            this.view_finished_btn.UseVisualStyleBackColor = true;
            // 
            // activities_dgv
            // 
            this.activities_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activities_dgv.Location = new System.Drawing.Point(16, 92);
            this.activities_dgv.Name = "activities_dgv";
            this.activities_dgv.Size = new System.Drawing.Size(756, 309);
            this.activities_dgv.TabIndex = 4;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.activities_dgv);
            this.Controls.Add(this.view_finished_btn);
            this.Controls.Add(this.edit_activity_btn);
            this.Controls.Add(this.activity_new_btn);
            this.Controls.Add(this.label1);
            this.Name = "mainForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activities_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button activity_new_btn;
        private System.Windows.Forms.Button edit_activity_btn;
        private System.Windows.Forms.Button view_finished_btn;
        private System.Windows.Forms.DataGridView activities_dgv;
    }
}