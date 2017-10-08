namespace Visao
{
    partial class Cadastrar_Cerveja
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
            this.group_cervejas = new System.Windows.Forms.GroupBox();
            this.ok_cerveja = new System.Windows.Forms.Button();
            this.cbxTipoCerveja = new System.Windows.Forms.ComboBox();
            this.cbxPais = new System.Windows.Forms.ComboBox();
            this.txbQtd_cerveja = new System.Windows.Forms.TextBox();
            this.txt_volume_cerveja = new System.Windows.Forms.TextBox();
            this.txbCervaNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.group_cadas_cervejas = new System.Windows.Forms.GroupBox();
            this.grid_cervejas = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_cervejas.SuspendLayout();
            this.group_cadas_cervejas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cervejas)).BeginInit();
            this.SuspendLayout();
            // 
            // group_cervejas
            // 
            this.group_cervejas.Controls.Add(this.ok_cerveja);
            this.group_cervejas.Controls.Add(this.cbxTipoCerveja);
            this.group_cervejas.Controls.Add(this.cbxPais);
            this.group_cervejas.Controls.Add(this.txbQtd_cerveja);
            this.group_cervejas.Controls.Add(this.txt_volume_cerveja);
            this.group_cervejas.Controls.Add(this.txbCervaNome);
            this.group_cervejas.Controls.Add(this.label1);
            this.group_cervejas.Controls.Add(this.label5);
            this.group_cervejas.Controls.Add(this.label4);
            this.group_cervejas.Controls.Add(this.label3);
            this.group_cervejas.Controls.Add(this.label2);
            this.group_cervejas.Location = new System.Drawing.Point(20, 40);
            this.group_cervejas.Name = "group_cervejas";
            this.group_cervejas.Size = new System.Drawing.Size(902, 169);
            this.group_cervejas.TabIndex = 8;
            this.group_cervejas.TabStop = false;
            this.group_cervejas.Text = "Cadastrar Cervejas";
            this.group_cervejas.Enter += new System.EventHandler(this.group_cervejas_Enter);
            // 
            // ok_cerveja
            // 
            this.ok_cerveja.Location = new System.Drawing.Point(344, 138);
            this.ok_cerveja.Name = "ok_cerveja";
            this.ok_cerveja.Size = new System.Drawing.Size(75, 23);
            this.ok_cerveja.TabIndex = 5;
            this.ok_cerveja.Text = "Cadastrar";
            this.ok_cerveja.UseVisualStyleBackColor = true;
            // 
            // cbxTipoCerveja
            // 
            this.cbxTipoCerveja.FormattingEnabled = true;
            this.cbxTipoCerveja.Items.AddRange(new object[] {
            "Weiss ",
            "Trapist ",
            "Lager ",
            "Pilsen ",
            "Bock "});
            this.cbxTipoCerveja.Location = new System.Drawing.Point(83, 106);
            this.cbxTipoCerveja.Name = "cbxTipoCerveja";
            this.cbxTipoCerveja.Size = new System.Drawing.Size(336, 21);
            this.cbxTipoCerveja.TabIndex = 12;
            this.cbxTipoCerveja.SelectedIndexChanged += new System.EventHandler(this.cbxTipoCerveja_SelectedIndexChanged);
            // 
            // cbxPais
            // 
            this.cbxPais.FormattingEnabled = true;
            this.cbxPais.Items.AddRange(new object[] {
            "Brasil",
            "Eua ",
            "Belgica ",
            "Alemanha ",
            "Jamaica ",
            "Inglaterra",
            "Escocia ",
            "Irlanda ",
            " "});
            this.cbxPais.Location = new System.Drawing.Point(83, 79);
            this.cbxPais.Name = "cbxPais";
            this.cbxPais.Size = new System.Drawing.Size(336, 21);
            this.cbxPais.TabIndex = 11;
            // 
            // txbQtd_cerveja
            // 
            this.txbQtd_cerveja.Location = new System.Drawing.Point(83, 135);
            this.txbQtd_cerveja.Name = "txbQtd_cerveja";
            this.txbQtd_cerveja.Size = new System.Drawing.Size(57, 20);
            this.txbQtd_cerveja.TabIndex = 10;
            // 
            // txt_volume_cerveja
            // 
            this.txt_volume_cerveja.Location = new System.Drawing.Point(83, 51);
            this.txt_volume_cerveja.Name = "txt_volume_cerveja";
            this.txt_volume_cerveja.Size = new System.Drawing.Size(336, 20);
            this.txt_volume_cerveja.TabIndex = 7;
            // 
            // txbCervaNome
            // 
            this.txbCervaNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txbCervaNome.Location = new System.Drawing.Point(83, 25);
            this.txbCervaNome.Name = "txbCervaNome";
            this.txbCervaNome.Size = new System.Drawing.Size(336, 20);
            this.txbCervaNome.TabIndex = 6;
            this.txbCervaNome.TextChanged += new System.EventHandler(this.txbCervaNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "País";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Volume";
            // 
            // group_cadas_cervejas
            // 
            this.group_cadas_cervejas.Controls.Add(this.grid_cervejas);
            this.group_cadas_cervejas.Location = new System.Drawing.Point(20, 215);
            this.group_cadas_cervejas.Name = "group_cadas_cervejas";
            this.group_cadas_cervejas.Size = new System.Drawing.Size(902, 280);
            this.group_cadas_cervejas.TabIndex = 6;
            this.group_cadas_cervejas.TabStop = false;
            this.group_cadas_cervejas.Text = "Cervejas";
            // 
            // grid_cervejas
            // 
            this.grid_cervejas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_cervejas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Volume,
            this.Pais,
            this.Tipo,
            this.Quantidade});
            this.grid_cervejas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_cervejas.Location = new System.Drawing.Point(3, 16);
            this.grid_cervejas.Name = "grid_cervejas";
            this.grid_cervejas.Size = new System.Drawing.Size(896, 261);
            this.grid_cervejas.TabIndex = 1;
            this.grid_cervejas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_cervejas_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Volume
            // 
            this.Volume.HeaderText = "Volume";
            this.Volume.Name = "Volume";
            this.Volume.ReadOnly = true;
            // 
            // Pais
            // 
            this.Pais.HeaderText = "País";
            this.Pais.Name = "Pais";
            this.Pais.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Quantidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cadastrar_Cerveja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 544);
            this.Controls.Add(this.group_cervejas);
            this.Controls.Add(this.group_cadas_cervejas);
            this.Name = "Cadastrar_Cerveja";
            this.Text = "Form1";
            this.group_cervejas.ResumeLayout(false);
            this.group_cervejas.PerformLayout();
            this.group_cadas_cervejas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_cervejas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_cervejas;
        private System.Windows.Forms.Button ok_cerveja;
        private System.Windows.Forms.ComboBox cbxTipoCerveja;
        private System.Windows.Forms.ComboBox cbxPais;
        private System.Windows.Forms.TextBox txbQtd_cerveja;
        private System.Windows.Forms.TextBox txt_volume_cerveja;
        private System.Windows.Forms.TextBox txbCervaNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox group_cadas_cervejas;
        private System.Windows.Forms.DataGridView grid_cervejas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais;
        private System.Windows.Forms.DataGridViewComboBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;

    }
}

