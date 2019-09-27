namespace Quote_Tracker
{
    partial class pswd_Reset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pswd_Reset));
            this.user_name_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.current_pwd_txtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.new_pwd_txtbox = new System.Windows.Forms.TextBox();
            this.confirm_pwd_txtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reset_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_name_txtBox
            // 
            this.user_name_txtBox.Location = new System.Drawing.Point(81, 79);
            this.user_name_txtBox.Name = "user_name_txtBox";
            this.user_name_txtBox.Size = new System.Drawing.Size(230, 20);
            this.user_name_txtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(77, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // current_pwd_txtBox
            // 
            this.current_pwd_txtBox.Location = new System.Drawing.Point(81, 149);
            this.current_pwd_txtBox.Name = "current_pwd_txtBox";
            this.current_pwd_txtBox.PasswordChar = '*';
            this.current_pwd_txtBox.Size = new System.Drawing.Size(230, 20);
            this.current_pwd_txtBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(77, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current Password";
            // 
            // new_pwd_txtbox
            // 
            this.new_pwd_txtbox.Location = new System.Drawing.Point(81, 215);
            this.new_pwd_txtbox.Name = "new_pwd_txtbox";
            this.new_pwd_txtbox.PasswordChar = '*';
            this.new_pwd_txtbox.Size = new System.Drawing.Size(230, 20);
            this.new_pwd_txtbox.TabIndex = 4;
            // 
            // confirm_pwd_txtBox
            // 
            this.confirm_pwd_txtBox.Location = new System.Drawing.Point(81, 268);
            this.confirm_pwd_txtBox.Name = "confirm_pwd_txtBox";
            this.confirm_pwd_txtBox.PasswordChar = '*';
            this.confirm_pwd_txtBox.Size = new System.Drawing.Size(230, 20);
            this.confirm_pwd_txtBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(77, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(77, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirm Password";
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(134, 312);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(126, 23);
            this.reset_btn.TabIndex = 8;
            this.reset_btn.Text = "Reset Password";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // pswd_Reset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 426);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirm_pwd_txtBox);
            this.Controls.Add(this.new_pwd_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.current_pwd_txtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_name_txtBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pswd_Reset";
            this.Text = "Reset Password";
            this.Load += new System.EventHandler(this.Pswd_Reset_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_name_txtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox current_pwd_txtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox new_pwd_txtbox;
        private System.Windows.Forms.TextBox confirm_pwd_txtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button reset_btn;
    }
}