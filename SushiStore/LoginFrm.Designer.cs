namespace SushiStore
{
    partial class LoginFrm
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.TbxUser = new System.Windows.Forms.TextBox();
            this.TbxPass = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(406, 47);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // TbxUser
            // 
            this.TbxUser.Location = new System.Drawing.Point(158, 50);
            this.TbxUser.Name = "TbxUser";
            this.TbxUser.Size = new System.Drawing.Size(186, 20);
            this.TbxUser.TabIndex = 1;
            // 
            // TbxPass
            // 
            this.TbxPass.Location = new System.Drawing.Point(158, 77);
            this.TbxPass.Name = "TbxPass";
            this.TbxPass.Size = new System.Drawing.Size(186, 20);
            this.TbxPass.TabIndex = 2;
            this.TbxPass.UseSystemPasswordChar = true;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(59, 53);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(63, 13);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "User Name:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(59, 80);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(56, 13);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Password:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(406, 77);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 159);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.TbxPass);
            this.Controls.Add(this.TbxUser);
            this.Controls.Add(this.btnLogin);
            this.Name = "LoginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox TbxUser;
        private System.Windows.Forms.TextBox TbxPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnExit;
    }
}