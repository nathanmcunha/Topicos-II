namespace Visao
{
    partial class Whiskey
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
            this.components = new System.ComponentModel.Container();
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
            this.group_cadas_whiskey = new System.Windows.Forms.GroupBox();
            this.grid_whiskeys = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cervejaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiskeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paísToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.group_whiskeys.SuspendLayout();
            this.group_cadas_whiskey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_whiskeys)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.group_whiskeys.Location = new System.Drawing.Point(29, 53);
            this.group_whiskeys.Name = "group_whiskeys";
            this.group_whiskeys.Size = new System.Drawing.Size(917, 184);
            this.group_whiskeys.TabIndex = 11;
            this.group_whiskeys.TabStop = false;
            this.group_whiskeys.Text = "Cadastrar Whiskeys";
            this.group_whiskeys.Enter += new System.EventHandler(this.group_whiskeys_Enter);
            // 
            // ok_whiskey
            // 
            this.ok_whiskey.Location = new System.Drawing.Point(349, 143);
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
            this.combo_tipo_whiskey.Location = new System.Drawing.Point(88, 111);
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
            this.combo_pais_whiskey.Location = new System.Drawing.Point(88, 84);
            this.combo_pais_whiskey.Name = "combo_pais_whiskey";
            this.combo_pais_whiskey.Size = new System.Drawing.Size(336, 21);
            this.combo_pais_whiskey.TabIndex = 11;
            this.combo_pais_whiskey.SelectedIndexChanged += new System.EventHandler(this.combo_pais_whiskey_SelectedIndexChanged);
            // 
            // text_qtd_whiskey
            // 
            this.text_qtd_whiskey.Location = new System.Drawing.Point(88, 140);
            this.text_qtd_whiskey.Name = "text_qtd_whiskey";
            this.text_qtd_whiskey.Size = new System.Drawing.Size(57, 20);
            this.text_qtd_whiskey.TabIndex = 10;
            // 
            // text_volume_whiskey
            // 
            this.text_volume_whiskey.Location = new System.Drawing.Point(88, 56);
            this.text_volume_whiskey.Name = "text_volume_whiskey";
            this.text_volume_whiskey.Size = new System.Drawing.Size(336, 20);
            this.text_volume_whiskey.TabIndex = 7;
            // 
            // text_nome_whiskey
            // 
            this.text_nome_whiskey.Location = new System.Drawing.Point(88, 30);
            this.text_nome_whiskey.Name = "text_nome_whiskey";
            this.text_nome_whiskey.Size = new System.Drawing.Size(336, 20);
            this.text_nome_whiskey.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Quantidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tipo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "País";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Volume";
            // 
            // group_cadas_whiskey
            // 
            this.group_cadas_whiskey.Controls.Add(this.grid_whiskeys);
            this.group_cadas_whiskey.Location = new System.Drawing.Point(29, 243);
            this.group_cadas_whiskey.Name = "group_cadas_whiskey";
            this.group_cadas_whiskey.Size = new System.Drawing.Size(917, 316);
            this.group_cadas_whiskey.TabIndex = 10;
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
            this.grid_whiskeys.Size = new System.Drawing.Size(911, 297);
            this.grid_whiskeys.TabIndex = 2;
            this.grid_whiskeys.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_whiskeys_CellContentClick);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastrarToolStripMenuItem,
            this.fonteToolStripMenuItem,
            this.temaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cervejaToolStripMenuItem,
            this.whiskeyToolStripMenuItem,
            this.paísToolStripMenuItem,
            this.tiposToolStripMenuItem,
            this.usuárioToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // cervejaToolStripMenuItem
            // 
            this.cervejaToolStripMenuItem.Name = "cervejaToolStripMenuItem";
            this.cervejaToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.cervejaToolStripMenuItem.Text = "Cerveja";
            // 
            // whiskeyToolStripMenuItem
            // 
            this.whiskeyToolStripMenuItem.Name = "whiskeyToolStripMenuItem";
            this.whiskeyToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.whiskeyToolStripMenuItem.Text = "Whiskey";
            // 
            // paísToolStripMenuItem
            // 
            this.paísToolStripMenuItem.Name = "paísToolStripMenuItem";
            this.paísToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.paísToolStripMenuItem.Text = "País";
            // 
            // tiposToolStripMenuItem
            // 
            this.tiposToolStripMenuItem.Name = "tiposToolStripMenuItem";
            this.tiposToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.tiposToolStripMenuItem.Text = "Tipos";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // fonteToolStripMenuItem
            // 
            this.fonteToolStripMenuItem.Name = "fonteToolStripMenuItem";
            this.fonteToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.fonteToolStripMenuItem.Text = "Fonte";
            // 
            // temaToolStripMenuItem
            // 
            this.temaToolStripMenuItem.Name = "temaToolStripMenuItem";
            this.temaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.temaToolStripMenuItem.Text = "Tema";
            // 
            // Whiskey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 587);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.group_whiskeys);
            this.Controls.Add(this.group_cadas_whiskey);
            this.Name = "Whiskey";
            this.Text = "Whiskey";
            this.group_whiskeys.ResumeLayout(false);
            this.group_whiskeys.PerformLayout();
            this.group_cadas_whiskey.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_whiskeys)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox group_cadas_whiskey;
        private System.Windows.Forms.DataGridView grid_whiskeys;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cervejaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiskeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paísToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temaToolStripMenuItem;
    }
}