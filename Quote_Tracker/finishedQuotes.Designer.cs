namespace Quote_Tracker
{
    partial class finishedQuotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(finishedQuotes));
            this.tabControlFinished = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_finished = new System.Windows.Forms.DataGridView();
            this.tabControlFinished.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_finished)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlFinished
            // 
            this.tabControlFinished.Controls.Add(this.tabPage2);
            this.tabControlFinished.Location = new System.Drawing.Point(38, 74);
            this.tabControlFinished.Name = "tabControlFinished";
            this.tabControlFinished.SelectedIndex = 0;
            this.tabControlFinished.Size = new System.Drawing.Size(1003, 552);
            this.tabControlFinished.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_finished);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(995, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quote";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_finished
            // 
            this.dgv_finished.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_finished.Location = new System.Drawing.Point(22, 48);
            this.dgv_finished.Name = "dgv_finished";
            this.dgv_finished.Size = new System.Drawing.Size(924, 430);
            this.dgv_finished.TabIndex = 0;
            this.dgv_finished.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_finished_CellDoubleClick);
            // 
            // finishedQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 678);
            this.Controls.Add(this.tabControlFinished);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "finishedQuotes";
            this.Text = "finishedQuotes";
            this.Load += new System.EventHandler(this.FinishedQuotes_Load);
            this.tabControlFinished.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_finished)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlFinished;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_finished;
    }
}