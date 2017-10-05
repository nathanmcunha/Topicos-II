namespace Visao
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.group_main = new System.Windows.Forms.GroupBox();
            this.group_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 77);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(431, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 79);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(247, 51);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 79);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(62, 271);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 79);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(247, 271);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 79);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // group_main
            // 
            this.group_main.Controls.Add(this.button2);
            this.group_main.Controls.Add(this.button3);
            this.group_main.Controls.Add(this.button6);
            this.group_main.Controls.Add(this.button1);
            this.group_main.Controls.Add(this.button5);
            this.group_main.Controls.Add(this.button4);
            this.group_main.Location = new System.Drawing.Point(63, 37);
            this.group_main.Name = "group_main";
            this.group_main.Size = new System.Drawing.Size(646, 404);
            this.group_main.TabIndex = 6;
            this.group_main.TabStop = false;
            this.group_main.Text = "Principal";
            this.group_main.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 494);
            this.Controls.Add(this.group_main);
            this.Name = "Main";
            this.Text = "Main";
            this.group_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox group_main;

    }
}