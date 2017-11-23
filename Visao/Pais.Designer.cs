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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.id_text = new System.Windows.Forms.Label();
            this.del_pais = new System.Windows.Forms.Button();
            this.ok_pais = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_nome_pais = new System.Windows.Forms.TextBox();
            this.grid_pais = new System.Windows.Forms.DataGridView();
            this.shabbaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shabbaDataSet = new Visao.ShabbaDataSet();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paisTableAdapter = new Visao.ShabbaDataSetTableAdapters.paisTableAdapter();
            this.shabbaDataSet3 = new Visao.ShabbaDataSet3();
            this.paisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.paisTableAdapter1 = new Visao.ShabbaDataSet3TableAdapters.paisTableAdapter();
            this.dataset_Pais = new Visao.Dataset_Pais();
            this.paisBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.paisTableAdapter2 = new Visao.Dataset_PaisTableAdapters.paisTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_pais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shabbaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shabbaDataSet)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shabbaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_Pais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.id_text);
            this.groupBox1.Controls.Add(this.del_pais);
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
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(47, 35);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 25;
            this.lblId.Text = "0";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // id_text
            // 
            this.id_text.AutoSize = true;
            this.id_text.Location = new System.Drawing.Point(9, 35);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(21, 13);
            this.id_text.TabIndex = 24;
            this.id_text.Text = "ID:";
            // 
            // del_pais
            // 
            this.del_pais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.del_pais.Location = new System.Drawing.Point(769, 130);
            this.del_pais.Name = "del_pais";
            this.del_pais.Size = new System.Drawing.Size(75, 23);
            this.del_pais.TabIndex = 8;
            this.del_pais.Text = "Deletar";
            this.del_pais.UseVisualStyleBackColor = true;
            this.del_pais.Click += new System.EventHandler(this.button1_Click);
            // 
            // ok_pais
            // 
            this.ok_pais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ok_pais.Location = new System.Drawing.Point(197, 88);
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
            this.label1.Location = new System.Drawing.Point(9, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // txtbox_nome_pais
            // 
            this.txtbox_nome_pais.Location = new System.Drawing.Point(59, 51);
            this.txtbox_nome_pais.Name = "txtbox_nome_pais";
            this.txtbox_nome_pais.Size = new System.Drawing.Size(213, 20);
            this.txtbox_nome_pais.TabIndex = 0;
            this.txtbox_nome_pais.TextChanged += new System.EventHandler(this.txtbox_nome_pais_TextChanged);
            // 
            // grid_pais
            // 
            this.grid_pais.AllowUserToAddRows = false;
            this.grid_pais.AllowUserToDeleteRows = false;
            this.grid_pais.AutoGenerateColumns = false;
            this.grid_pais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_pais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nome,
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn});
            this.grid_pais.DataSource = this.paisBindingSource2;
            this.grid_pais.Location = new System.Drawing.Point(27, 216);
            this.grid_pais.Name = "grid_pais";
            this.grid_pais.ReadOnly = true;
            this.grid_pais.Size = new System.Drawing.Size(885, 278);
            this.grid_pais.TabIndex = 1;
            this.grid_pais.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_pais_CellContentClick);
            // 
            // shabbaDataSetBindingSource
            // 
            this.shabbaDataSetBindingSource.DataSource = this.shabbaDataSet;
            this.shabbaDataSetBindingSource.Position = 0;
            // 
            // shabbaDataSet
            // 
            this.shabbaDataSet.DataSetName = "ShabbaDataSet";
            this.shabbaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.fonteToolStripMenuItem,
            this.temaToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(971, 24);
            this.menuStrip2.TabIndex = 11;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Arquivo";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(93, 22);
            this.toolStripMenuItem2.Text = "Sair";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.usuárioToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(69, 20);
            this.toolStripMenuItem3.Text = "Cadastrar";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem4.Text = "Cerveja";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem5.Text = "Whiskey";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem6.Text = "País";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem7.Text = "Tipos";
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
            // paisBindingSource
            // 
            this.paisBindingSource.DataMember = "pais";
            this.paisBindingSource.DataSource = this.shabbaDataSet;
            // 
            // paisTableAdapter
            // 
            this.paisTableAdapter.ClearBeforeFill = true;
            // 
            // shabbaDataSet3
            // 
            this.shabbaDataSet3.DataSetName = "ShabbaDataSet3";
            this.shabbaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paisBindingSource1
            // 
            this.paisBindingSource1.DataMember = "pais";
            this.paisBindingSource1.DataSource = this.shabbaDataSet3;
            // 
            // paisTableAdapter1
            // 
            this.paisTableAdapter1.ClearBeforeFill = true;
            // 
            // dataset_Pais
            // 
            this.dataset_Pais.DataSetName = "Dataset_Pais";
            this.dataset_Pais.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paisBindingSource2
            // 
            this.paisBindingSource2.DataMember = "pais";
            this.paisBindingSource2.DataSource = this.dataset_Pais;
            // 
            // paisTableAdapter2
            // 
            this.paisTableAdapter2.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Visible = false;
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
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Pais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 544);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.grid_pais);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Pais";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Pais";
            this.Load += new System.EventHandler(this.Pais_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_pais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shabbaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shabbaDataSet)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shabbaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_Pais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grid_pais;
        private System.Windows.Forms.TextBox txtbox_nome_pais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ok_pais;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temaToolStripMenuItem;
        private ShabbaDataSet shabbaDataSet;
        private System.Windows.Forms.BindingSource paisBindingSource;
        private ShabbaDataSetTableAdapters.paisTableAdapter paisTableAdapter;
        private System.Windows.Forms.BindingSource shabbaDataSetBindingSource;
        private System.Windows.Forms.Button del_pais;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label id_text;
        private ShabbaDataSet3 shabbaDataSet3;
        private System.Windows.Forms.BindingSource paisBindingSource1;
        private ShabbaDataSet3TableAdapters.paisTableAdapter paisTableAdapter1;
        private Dataset_Pais dataset_Pais;
        private System.Windows.Forms.BindingSource paisBindingSource2;
        private Dataset_PaisTableAdapters.paisTableAdapter paisTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
    }
}