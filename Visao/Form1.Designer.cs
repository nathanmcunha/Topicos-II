namespace Visao
{
    partial class Form1
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
            this.group_whiskeys = new System.Windows.Forms.GroupBox();
            this.ok_whiskey = new System.Windows.Forms.Button();
            this.combo_tipo_whiskey = new System.Windows.Forms.ComboBox();
            this.combo_pais_whiskey = new System.Windows.Forms.ComboBox();
            this.text_qtd_whiskey = new System.Windows.Forms.TextBox();
            this.text_volume_whiskey = new System.Windows.Forms.TextBox();
            this.text_nome_whiskey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.group_cervejas = new System.Windows.Forms.GroupBox();
            this.ok_cerveja = new System.Windows.Forms.Button();
            this.cbxTipoCerveja = new System.Windows.Forms.ComboBox();
            this.cbxPais = new System.Windows.Forms.ComboBox();
            this.txbQtd = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txbCervaNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.group_cadas_whiskey = new System.Windows.Forms.GroupBox();
            this.grid_whiskeys = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_cadas_cervejas = new System.Windows.Forms.GroupBox();
            this.grid_cervejas = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_whiskeys.SuspendLayout();
            this.group_cervejas.SuspendLayout();
            this.group_cadas_whiskey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_whiskeys)).BeginInit();
            this.group_cadas_cervejas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cervejas)).BeginInit();
            this.SuspendLayout();
            // 
            // group_whiskeys
            // 
            this.group_whiskeys.Controls.Add(this.ok_whiskey);
            this.group_whiskeys.Controls.Add(this.combo_tipo_whiskey);
            this.group_whiskeys.Controls.Add(this.combo_pais_whiskey);
            this.group_whiskeys.Controls.Add(this.text_qtd_whiskey);
            this.group_whiskeys.Controls.Add(this.text_volume_whiskey);
            this.group_whiskeys.Controls.Add(this.text_nome_whiskey);
            this.group_whiskeys.Controls.Add(this.label6);
            this.group_whiskeys.Controls.Add(this.label7);
            this.group_whiskeys.Controls.Add(this.label8);
            this.group_whiskeys.Controls.Add(this.label9);
            this.group_whiskeys.Controls.Add(this.label10);
            this.group_whiskeys.Location = new System.Drawing.Point(511, 40);
            this.group_whiskeys.Name = "group_whiskeys";
            this.group_whiskeys.Size = new System.Drawing.Size(447, 169);
            this.group_whiskeys.TabIndex = 9;
            this.group_whiskeys.TabStop = false;
            this.group_whiskeys.Text = "Cadastrar Whiskeys";
            // 
            // ok_whiskey
            // 
            this.ok_whiskey.Location = new System.Drawing.Point(348, 140);
            this.ok_whiskey.Name = "ok_whiskey";
            this.ok_whiskey.Size = new System.Drawing.Size(75, 23);
            this.ok_whiskey.TabIndex = 5;
            this.ok_whiskey.Text = "Cadastrar";
            this.ok_whiskey.UseVisualStyleBackColor = true;
            // 
            // combo_tipo_whiskey
            // 
            this.combo_tipo_whiskey.FormattingEnabled = true;
            this.combo_tipo_whiskey.Items.AddRange(new object[] {
            "Weiss ",
            "Trapist ",
            "Lager ",
            "Pilsen ",
            "Bock "});
            this.combo_tipo_whiskey.Location = new System.Drawing.Point(87, 108);
            this.combo_tipo_whiskey.Name = "combo_tipo_whiskey";
            this.combo_tipo_whiskey.Size = new System.Drawing.Size(336, 21);
            this.combo_tipo_whiskey.TabIndex = 12;
            // 
            // combo_pais_whiskey
            // 
            this.combo_pais_whiskey.FormattingEnabled = true;
            this.combo_pais_whiskey.Items.AddRange(new object[] {
            "Brasil",
            "Eua ",
            "Belgica ",
            "Alemanha ",
            "Jamaica ",
            "Inglaterra",
            "Escocia ",
            "Irlanda ",
            " "});
            this.combo_pais_whiskey.Location = new System.Drawing.Point(87, 81);
            this.combo_pais_whiskey.Name = "combo_pais_whiskey";
            this.combo_pais_whiskey.Size = new System.Drawing.Size(336, 21);
            this.combo_pais_whiskey.TabIndex = 11;
            // 
            // text_qtd_whiskey
            // 
            this.text_qtd_whiskey.Location = new System.Drawing.Point(87, 137);
            this.text_qtd_whiskey.Name = "text_qtd_whiskey";
            this.text_qtd_whiskey.Size = new System.Drawing.Size(57, 20);
            this.text_qtd_whiskey.TabIndex = 10;
            // 
            // text_volume_whiskey
            // 
            this.text_volume_whiskey.Location = new System.Drawing.Point(87, 53);
            this.text_volume_whiskey.Name = "text_volume_whiskey";
            this.text_volume_whiskey.Size = new System.Drawing.Size(336, 20);
            this.text_volume_whiskey.TabIndex = 7;
            // 
            // text_nome_whiskey
            // 
            this.text_nome_whiskey.Location = new System.Drawing.Point(87, 27);
            this.text_nome_whiskey.Name = "text_nome_whiskey";
            this.text_nome_whiskey.Size = new System.Drawing.Size(336, 20);
            this.text_nome_whiskey.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Quantidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tipo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "País";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Volume";
            // 
            // group_cervejas
            // 
            this.group_cervejas.Controls.Add(this.ok_cerveja);
            this.group_cervejas.Controls.Add(this.cbxTipoCerveja);
            this.group_cervejas.Controls.Add(this.cbxPais);
            this.group_cervejas.Controls.Add(this.txbQtd);
            this.group_cervejas.Controls.Add(this.textBox2);
            this.group_cervejas.Controls.Add(this.txbCervaNome);
            this.group_cervejas.Controls.Add(this.label1);
            this.group_cervejas.Controls.Add(this.label5);
            this.group_cervejas.Controls.Add(this.label4);
            this.group_cervejas.Controls.Add(this.label3);
            this.group_cervejas.Controls.Add(this.label2);
            this.group_cervejas.Location = new System.Drawing.Point(20, 40);
            this.group_cervejas.Name = "group_cervejas";
            this.group_cervejas.Size = new System.Drawing.Size(447, 169);
            this.group_cervejas.TabIndex = 8;
            this.group_cervejas.TabStop = false;
            this.group_cervejas.Text = "Cadastrar Cervejas";
            // 
            // ok_cerveja
            // 
            this.ok_cerveja.Location = new System.Drawing.Point(348, 140);
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
            this.cbxTipoCerveja.Location = new System.Drawing.Point(87, 108);
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
            this.cbxPais.Location = new System.Drawing.Point(87, 81);
            this.cbxPais.Name = "cbxPais";
            this.cbxPais.Size = new System.Drawing.Size(336, 21);
            this.cbxPais.TabIndex = 11;
            // 
            // txbQtd
            // 
            this.txbQtd.Location = new System.Drawing.Point(87, 137);
            this.txbQtd.Name = "txbQtd";
            this.txbQtd.Size = new System.Drawing.Size(57, 20);
            this.txbQtd.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(87, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(336, 20);
            this.textBox2.TabIndex = 7;
            // 
            // txbCervaNome
            // 
            this.txbCervaNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txbCervaNome.Location = new System.Drawing.Point(87, 27);
            this.txbCervaNome.Name = "txbCervaNome";
            this.txbCervaNome.Size = new System.Drawing.Size(336, 20);
            this.txbCervaNome.TabIndex = 6;
            this.txbCervaNome.TextChanged += new System.EventHandler(this.txbCervaNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "País";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Volume";
            // 
            // group_cadas_whiskey
            // 
            this.group_cadas_whiskey.Controls.Add(this.grid_whiskeys);
            this.group_cadas_whiskey.Location = new System.Drawing.Point(512, 215);
            this.group_cadas_whiskey.Name = "group_cadas_whiskey";
            this.group_cadas_whiskey.Size = new System.Drawing.Size(449, 280);
            this.group_cadas_whiskey.TabIndex = 7;
            this.group_cadas_whiskey.TabStop = false;
            this.group_cadas_whiskey.Text = "Wiskeys";
            // 
            // grid_whiskeys
            // 
            this.grid_whiskeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_whiskeys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewComboBoxColumn2});
            this.grid_whiskeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_whiskeys.Location = new System.Drawing.Point(3, 16);
            this.grid_whiskeys.Name = "grid_whiskeys";
            this.grid_whiskeys.Size = new System.Drawing.Size(443, 261);
            this.grid_whiskeys.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Volume";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "País";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.HeaderText = "Tipo";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.HeaderText = "Quantidade";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.ReadOnly = true;
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // group_cadas_cervejas
            // 
            this.group_cadas_cervejas.Controls.Add(this.grid_cervejas);
            this.group_cadas_cervejas.Location = new System.Drawing.Point(20, 215);
            this.group_cadas_cervejas.Name = "group_cadas_cervejas";
            this.group_cadas_cervejas.Size = new System.Drawing.Size(447, 280);
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
            this.grid_cervejas.Size = new System.Drawing.Size(441, 261);
            this.grid_cervejas.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 534);
            this.Controls.Add(this.group_whiskeys);
            this.Controls.Add(this.group_cervejas);
            this.Controls.Add(this.group_cadas_whiskey);
            this.Controls.Add(this.group_cadas_cervejas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.group_whiskeys.ResumeLayout(false);
            this.group_whiskeys.PerformLayout();
            this.group_cervejas.ResumeLayout(false);
            this.group_cervejas.PerformLayout();
            this.group_cadas_whiskey.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_whiskeys)).EndInit();
            this.group_cadas_cervejas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_cervejas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_whiskeys;
        private System.Windows.Forms.Button ok_whiskey;
        private System.Windows.Forms.ComboBox combo_tipo_whiskey;
        private System.Windows.Forms.ComboBox combo_pais_whiskey;
        private System.Windows.Forms.TextBox text_qtd_whiskey;
        private System.Windows.Forms.TextBox text_volume_whiskey;
        private System.Windows.Forms.TextBox text_nome_whiskey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox group_cervejas;
        private System.Windows.Forms.Button ok_cerveja;
        private System.Windows.Forms.ComboBox cbxTipoCerveja;
        private System.Windows.Forms.ComboBox cbxPais;
        private System.Windows.Forms.TextBox txbQtd;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txbCervaNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox group_cadas_whiskey;
        private System.Windows.Forms.DataGridView grid_whiskeys;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.GroupBox group_cadas_cervejas;
        private System.Windows.Forms.DataGridView grid_cervejas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais;
        private System.Windows.Forms.DataGridViewComboBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;

    }
}

