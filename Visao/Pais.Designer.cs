namespace Visao
{
    partial class Pais
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ok_pais = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_nome_pais = new System.Windows.Forms.TextBox();
            this.grid_pais = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_pais)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ok_pais);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtbox_nome_pais);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Location = new System.Drawing.Point(27, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paises";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ok_pais
            // 
            this.ok_pais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ok_pais.Location = new System.Drawing.Point(197, 69);
            this.ok_pais.Name = "ok_pais";
            this.ok_pais.Size = new System.Drawing.Size(75, 23);
            this.ok_pais.TabIndex = 7;
            this.ok_pais.Text = "Cadastrar";
            this.ok_pais.UseVisualStyleBackColor = true;
            this.ok_pais.Click += new System.EventHandler(this.ok_pais_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // txtbox_nome_pais
            // 
            this.txtbox_nome_pais.Location = new System.Drawing.Point(59, 32);
            this.txtbox_nome_pais.Name = "txtbox_nome_pais";
            this.txtbox_nome_pais.Size = new System.Drawing.Size(213, 20);
            this.txtbox_nome_pais.TabIndex = 0;
            // 
            // grid_pais
            // 
            this.grid_pais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_pais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome});
            this.grid_pais.Location = new System.Drawing.Point(27, 216);
            this.grid_pais.Name = "grid_pais";
            this.grid_pais.Size = new System.Drawing.Size(885, 278);
            this.grid_pais.TabIndex = 1;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Pais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 544);
            this.Controls.Add(this.grid_pais);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Pais";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Pais";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_pais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grid_pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.TextBox txtbox_nome_pais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ok_pais;

    }
}