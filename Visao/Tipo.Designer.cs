namespace Visao
{
    partial class Tipo
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
            this.grid_tipo = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBox_tipo = new System.Windows.Forms.GroupBox();
            this.ok_tipo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_nome_tipo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tipo)).BeginInit();
            this.grpBox_tipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_tipo
            // 
            this.grid_tipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_tipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome});
            this.grid_tipo.Location = new System.Drawing.Point(30, 209);
            this.grid_tipo.Name = "grid_tipo";
            this.grid_tipo.Size = new System.Drawing.Size(902, 293);
            this.grid_tipo.TabIndex = 3;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // grpBox_tipo
            // 
            this.grpBox_tipo.Controls.Add(this.ok_tipo);
            this.grpBox_tipo.Controls.Add(this.label1);
            this.grpBox_tipo.Controls.Add(this.txtbox_nome_tipo);
            this.grpBox_tipo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.grpBox_tipo.Location = new System.Drawing.Point(30, 34);
            this.grpBox_tipo.Name = "grpBox_tipo";
            this.grpBox_tipo.Size = new System.Drawing.Size(902, 169);
            this.grpBox_tipo.TabIndex = 2;
            this.grpBox_tipo.TabStop = false;
            this.grpBox_tipo.Text = "Paises";
            // 
            // ok_tipo
            // 
            this.ok_tipo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ok_tipo.Location = new System.Drawing.Point(194, 63);
            this.ok_tipo.Name = "ok_tipo";
            this.ok_tipo.Size = new System.Drawing.Size(75, 23);
            this.ok_tipo.TabIndex = 7;
            this.ok_tipo.Text = "Cadastrar";
            this.ok_tipo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // txtbox_nome_tipo
            // 
            this.txtbox_nome_tipo.Location = new System.Drawing.Point(56, 26);
            this.txtbox_nome_tipo.Name = "txtbox_nome_tipo";
            this.txtbox_nome_tipo.Size = new System.Drawing.Size(213, 20);
            this.txtbox_nome_tipo.TabIndex = 0;
            // 
            // Tipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 544);
            this.Controls.Add(this.grid_tipo);
            this.Controls.Add(this.grpBox_tipo);
            this.Name = "Tipo";
            this.Text = "Tipo";
            ((System.ComponentModel.ISupportInitialize)(this.grid_tipo)).EndInit();
            this.grpBox_tipo.ResumeLayout(false);
            this.grpBox_tipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.GroupBox grpBox_tipo;
        private System.Windows.Forms.Button ok_tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_nome_tipo;
    }
}