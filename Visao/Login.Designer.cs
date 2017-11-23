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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.user_login = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.ok_login = new System.Windows.Forms.Button();
            this.msg_login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // user_login
            // 
            this.user_login.Location = new System.Drawing.Point(64, 109);
            this.user_login.Name = "user_login";
            this.user_login.Size = new System.Drawing.Size(232, 20);
            this.user_login.TabIndex = 0;
            this.user_login.Text = "nathanmcunha";
            this.user_login.TextChanged += new System.EventHandler(this.user_login_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(64, 173);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_password.Size = new System.Drawing.Size(232, 20);
            this.txt_password.TabIndex = 1;
            this.txt_password.Text = "12345";
            this.txt_password.TextChanged += new System.EventHandler(this.txt_senha_TextChanged);
            // 
            // ok_login
            // 
            this.ok_login.Location = new System.Drawing.Point(64, 276);
            this.ok_login.Name = "ok_login";
            this.ok_login.Size = new System.Drawing.Size(75, 23);
            this.ok_login.TabIndex = 2;
            this.ok_login.Text = "Login";
            this.ok_login.UseVisualStyleBackColor = true;
            this.ok_login.Click += new System.EventHandler(this.ok_login_Click);
            // 
            // msg_login
            // 
            this.msg_login.AutoSize = true;
            this.msg_login.Location = new System.Drawing.Point(61, 242);
            this.msg_login.Name = "msg_login";
            this.msg_login.Size = new System.Drawing.Size(0, 13);
            this.msg_login.TabIndex = 3;
            this.msg_login.Click += new System.EventHandler(this.msg_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Controle de Estoque Bebidas Shabbá";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::Visao.Properties.Resources.asaddasdasdas;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(332, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 332);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 459);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msg_login);
            this.Controls.Add(this.ok_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.user_login);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button ok_login;
        private System.Windows.Forms.Label msg_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}