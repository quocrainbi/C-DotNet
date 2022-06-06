namespace ThiDotNet
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbNameLogin = new System.Windows.Forms.TextBox();
            this.LbNameLogin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbPwdLogin = new System.Windows.Forms.TextBox();
            this.lbPwdLogin = new System.Windows.Forms.Label();
            this.bntLogin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bntExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbNameLogin);
            this.panel1.Controls.Add(this.LbNameLogin);
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 41);
            this.panel1.TabIndex = 0;
            // 
            // txbNameLogin
            // 
            this.txbNameLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameLogin.Location = new System.Drawing.Point(134, 7);
            this.txbNameLogin.Name = "txbNameLogin";
            this.txbNameLogin.Size = new System.Drawing.Size(185, 26);
            this.txbNameLogin.TabIndex = 1;
            this.txbNameLogin.Text = "admin";
            // 
            // LbNameLogin
            // 
            this.LbNameLogin.AutoSize = true;
            this.LbNameLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNameLogin.Location = new System.Drawing.Point(12, 10);
            this.LbNameLogin.Name = "LbNameLogin";
            this.LbNameLogin.Size = new System.Drawing.Size(116, 19);
            this.LbNameLogin.TabIndex = 0;
            this.LbNameLogin.Text = "Tên đăng nhập :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbPwdLogin);
            this.panel2.Controls.Add(this.lbPwdLogin);
            this.panel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 41);
            this.panel2.TabIndex = 1;
            // 
            // txbPwdLogin
            // 
            this.txbPwdLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPwdLogin.Location = new System.Drawing.Point(134, 7);
            this.txbPwdLogin.Name = "txbPwdLogin";
            this.txbPwdLogin.Size = new System.Drawing.Size(185, 26);
            this.txbPwdLogin.TabIndex = 2;
            this.txbPwdLogin.Text = "admin";
            this.txbPwdLogin.UseSystemPasswordChar = true;
            // 
            // lbPwdLogin
            // 
            this.lbPwdLogin.AutoSize = true;
            this.lbPwdLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPwdLogin.Location = new System.Drawing.Point(41, 10);
            this.lbPwdLogin.Name = "lbPwdLogin";
            this.lbPwdLogin.Size = new System.Drawing.Size(87, 19);
            this.lbPwdLogin.TabIndex = 0;
            this.lbPwdLogin.Text = "Mật Khẩu :";
            // 
            // bntLogin
            // 
            this.bntLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLogin.Location = new System.Drawing.Point(68, 9);
            this.bntLogin.Name = "bntLogin";
            this.bntLogin.Size = new System.Drawing.Size(95, 32);
            this.bntLogin.TabIndex = 3;
            this.bntLogin.Text = "Đăng Nhập";
            this.bntLogin.UseVisualStyleBackColor = true;
            this.bntLogin.Click += new System.EventHandler(this.bntLogin_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bntExit);
            this.panel3.Controls.Add(this.bntLogin);
            this.panel3.Location = new System.Drawing.Point(0, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(335, 44);
            this.panel3.TabIndex = 2;
            // 
            // bntExit
            // 
            this.bntExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExit.Location = new System.Drawing.Point(169, 9);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(95, 32);
            this.bntExit.TabIndex = 4;
            this.bntExit.Text = "Thoát ";
            this.bntExit.UseVisualStyleBackColor = true;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // fLogin
            // 
            this.AcceptButton = this.bntLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 130);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbNameLogin;
        private System.Windows.Forms.TextBox txbNameLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbPwdLogin;
        private System.Windows.Forms.Label lbPwdLogin;
        private System.Windows.Forms.Button bntLogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bntExit;
    }
}

