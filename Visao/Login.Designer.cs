namespace Visao
{
    partial class Login
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
            this.user_login = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.ok_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_login
            // 
            this.user_login.Location = new System.Drawing.Point(129, 94);
            this.user_login.Name = "user_login";
            this.user_login.Size = new System.Drawing.Size(232, 20);
            this.user_login.TabIndex = 0;
            this.user_login.TextChanged += new System.EventHandler(this.user_login_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(129, 154);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(232, 20);
            this.txt_password.TabIndex = 1;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_senha_TextChanged);
            // 
            // ok_login
            // 
            this.ok_login.Location = new System.Drawing.Point(129, 230);
            this.ok_login.Name = "ok_login";
            this.ok_login.Size = new System.Drawing.Size(75, 23);
            this.ok_login.TabIndex = 2;
            this.ok_login.Text = "Login";
            this.ok_login.UseVisualStyleBackColor = true;
            this.ok_login.Click += new System.EventHandler(this.ok_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 346);
            this.Controls.Add(this.ok_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.user_login);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button ok_login;
    }
}