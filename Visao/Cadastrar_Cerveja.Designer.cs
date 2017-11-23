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
            this.components = new System.ComponentModel.Container();
            this.group_cervejas = new System.Windows.Forms.GroupBox();
            this.ok_cerveja = new System.Windows.Forms.Button();
            this.cbxTipoCerveja = new System.Windows.Forms.ComboBox();
            this.tipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shabbaDataSet2 = new Visao.ShabbaDataSet2();
            this.cbxPais = new System.Windows.Forms.ComboBox();
            this.paisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shabbaDataSet1 = new Visao.ShabbaDataSet1();
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
            this.paisTableAdapter = new Visao.ShabbaDataSet1TableAdapters.paisTableAdapter();
            this.tipoTableAdapter = new Visao.ShabbaDataSet2TableAdapters.tipoTableAdapter();
            this.set_pais_cerveja = new Visao.set_pais_cerveja();
            this.paisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.paisTableAdapter1 = new Visao.set_pais_cervejaTableAdapters.paisTableAdapter();
            this.data_set_tipo = new Visao.data_set_tipo();
            this.tipoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tipoTableAdapter1 = new Visao.data_set_tipoTableAdapters.tipoTableAdapter();
            this.shabbaDataSet5 = new Visao.ShabbaDataSet5();
            this.cervejaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cervejaTableAdapter = new Visao.ShabbaDataSet5TableAdapters.cervejaTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletar = new System.Windows.Forms.Button();
            this.group_cervejas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shabbaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shabbaDataSet1)).BeginInit();
            this.group_cadas_cervejas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cervejas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.set_pais_cerveja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_set_tipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shabbaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cervejaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // group_cervejas
            // 
            this.group_cervejas.Controls.Add(this.deletar);
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
            this.ok_cerveja.Click += new System.EventHandler(this.ok_cerveja_Click);
            // 
            // cbxTipoCerveja
            // 
            this.cbxTipoCerveja.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tipoBindingSource, "id", true));
            this.cbxTipoCerveja.DataSource = this.tipoBindingSource1;
            this.cbxTipoCerveja.DisplayMember = "nome";
            this.cbxTipoCerveja.FormattingEnabled = true;
            this.cbxTipoCerveja.Location = new System.Drawing.Point(83, 106);
            this.cbxTipoCerveja.Name = "cbxTipoCerveja";
            this.cbxTipoCerveja.Size = new System.Drawing.Size(336, 21);
            this.cbxTipoCerveja.TabIndex = 12;
            this.cbxTipoCerveja.ValueMember = "id";
            this.cbxTipoCerveja.SelectedIndexChanged += new System.EventHandler(this.cbxTipoCerveja_SelectedIndexChanged);
            // 
            // tipoBindingSource
            // 
            this.tipoBindingSource.DataMember = "tipo";
            this.tipoBindingSource.DataSource = this.shabbaDataSet2;
            // 
            // shabbaDataSet2
            // 
            this.shabbaDataSet2.DataSetName = "ShabbaDataSet2";
            this.shabbaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxPais
            // 
            this.cbxPais.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.paisBindingSource, "id", true));
            this.cbxPais.DataSource = this.paisBindingSource1;
            this.cbxPais.DisplayMember = "nome";
            this.cbxPais.FormattingEnabled = true;
            this.cbxPais.Location = new System.Drawing.Point(83, 79);
            this.cbxPais.Name = "cbxPais";
            this.cbxPais.Size = new System.Drawing.Size(336, 21);
            this.cbxPais.TabIndex = 11;
            this.cbxPais.ValueMember = "id";
            this.cbxPais.SelectedIndexChanged += new System.EventHandler(this.cbxPais_SelectedIndexChanged);
            // 
            // paisBindingSource
            // 
            this.paisBindingSource.DataMember = "pais";
            this.paisBindingSource.DataSource = this.shabbaDataSet1;
            // 
            // shabbaDataSet1
            // 
            this.shabbaDataSet1.DataSetName = "ShabbaDataSet1";
            this.shabbaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.grid_cervejas.AutoGenerateColumns = false;
            this.grid_cervejas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_cervejas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.paisDataGridViewTextBoxColumn,
            this.qtdDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn});
            this.grid_cervejas.DataSource = this.cervejaBindingSource;
            this.grid_cervejas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_cervejas.Location = new System.Drawing.Point(3, 16);
            this.grid_cervejas.Name = "grid_cervejas";
            this.grid_cervejas.Size = new System.Drawing.Size(896, 261);
            this.grid_cervejas.TabIndex = 1;
            this.grid_cervejas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_cervejas_CellContentClick);
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
            this.menuStrip1.Size = new System.Drawing.Size(971, 24);
            this.menuStrip1.TabIndex = 10;
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
            this.temaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.temaToolStripMenuItem.Text = "Tema";
            // 
            // paisTableAdapter
            // 
            this.paisTableAdapter.ClearBeforeFill = true;
            // 
            // tipoTableAdapter
            // 
            this.tipoTableAdapter.ClearBeforeFill = true;
            // 
            // set_pais_cerveja
            // 
            this.set_pais_cerveja.DataSetName = "set_pais_cerveja";
            this.set_pais_cerveja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paisBindingSource1
            // 
            this.paisBindingSource1.DataMember = "pais";
            this.paisBindingSource1.DataSource = this.set_pais_cerveja;
            // 
            // paisTableAdapter1
            // 
            this.paisTableAdapter1.ClearBeforeFill = true;
            // 
            // data_set_tipo
            // 
            this.data_set_tipo.DataSetName = "data_set_tipo";
            this.data_set_tipo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoBindingSource1
            // 
            this.tipoBindingSource1.DataMember = "tipo";
            this.tipoBindingSource1.DataSource = this.data_set_tipo;
            // 
            // tipoTableAdapter1
            // 
            this.tipoTableAdapter1.ClearBeforeFill = true;
            // 
            // shabbaDataSet5
            // 
            this.shabbaDataSet5.DataSetName = "ShabbaDataSet5";
            this.shabbaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cervejaBindingSource
            // 
            this.cervejaBindingSource.DataMember = "cerveja";
            this.cervejaBindingSource.DataSource = this.shabbaDataSet5;
            // 
            // cervejaTableAdapter
            // 
            this.cervejaTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // paisDataGridViewTextBoxColumn
            // 
            this.paisDataGridViewTextBoxColumn.DataPropertyName = "pais";
            this.paisDataGridViewTextBoxColumn.HeaderText = "pais";
            this.paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            // 
            // qtdDataGridViewTextBoxColumn
            // 
            this.qtdDataGridViewTextBoxColumn.DataPropertyName = "qtd";
            this.qtdDataGridViewTextBoxColumn.HeaderText = "qtd";
            this.qtdDataGridViewTextBoxColumn.Name = "qtdDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // deletar
            // 
            this.deletar.Location = new System.Drawing.Point(798, 140);
            this.deletar.Name = "deletar";
            this.deletar.Size = new System.Drawing.Size(75, 23);
            this.deletar.TabIndex = 13;
            this.deletar.Text = "Deletar";
            this.deletar.UseVisualStyleBackColor = true;
            this.deletar.Click += new System.EventHandler(this.deletar_Click);
            // 
            // Cadastrar_Cerveja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 544);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.group_cervejas);
            this.Controls.Add(this.group_cadas_cervejas);
            this.Name = "Cadastrar_Cerveja";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Cadastrar_Cerveja_Load);
            this.group_cervejas.ResumeLayout(false);
            this.group_cervejas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shabbaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shabbaDataSet1)).EndInit();
            this.group_cadas_cervejas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_cervejas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.set_pais_cerveja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_set_tipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shabbaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cervejaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ShabbaDataSet1 shabbaDataSet1;
        private System.Windows.Forms.BindingSource paisBindingSource;
        private ShabbaDataSet1TableAdapters.paisTableAdapter paisTableAdapter;
        private ShabbaDataSet2 shabbaDataSet2;
        private System.Windows.Forms.BindingSource tipoBindingSource;
        private ShabbaDataSet2TableAdapters.tipoTableAdapter tipoTableAdapter;
        private set_pais_cerveja set_pais_cerveja;
        private System.Windows.Forms.BindingSource paisBindingSource1;
        private set_pais_cervejaTableAdapters.paisTableAdapter paisTableAdapter1;
        private data_set_tipo data_set_tipo;
        private System.Windows.Forms.BindingSource tipoBindingSource1;
        private data_set_tipoTableAdapters.tipoTableAdapter tipoTableAdapter1;
        private ShabbaDataSet5 shabbaDataSet5;
        private System.Windows.Forms.BindingSource cervejaBindingSource;
        private ShabbaDataSet5TableAdapters.cervejaTableAdapter cervejaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button deletar;
    }
}

