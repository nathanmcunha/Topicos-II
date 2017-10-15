namespace Visao
{
    partial class Cadastrar_Usuario
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
            this.grid_usuarios = new System.Windows.Forms.DataGridView();
            this.group_box_usuarios = new System.Windows.Forms.GroupBox();
            this.ok_usuario = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cervejaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiskeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paísToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbox_nome_usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_senha = new System.Windows.Forms.TextBox();
            this.radio_comum = new System.Windows.Forms.RadioButton();
            this.radio_gerencial = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid_usuarios)).BeginInit();
            this.group_box_usuarios.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_usuarios
            // 
            this.grid_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Senha,
            this.Perfil});
            this.grid_usuarios.Location = new System.Drawing.Point(30, 209);
            this.grid_usuarios.Name = "grid_usuarios";
            this.grid_usuarios.Size = new System.Drawing.Size(884, 290);
            this.grid_usuarios.TabIndex = 3;
            this.grid_usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_usuarios_CellContentClick);
            // 
            // group_box_usuarios
            // 
            this.group_box_usuarios.Controls.Add(this.radio_gerencial);
            this.group_box_usuarios.Controls.Add(this.radio_comum);
            this.group_box_usuarios.Controls.Add(this.label2);
            this.group_box_usuarios.Controls.Add(this.txb_senha);
            this.group_box_usuarios.Controls.Add(this.ok_usuario);
            this.group_box_usuarios.Controls.Add(this.label1);
            this.group_box_usuarios.Controls.Add(this.txtbox_nome_usuario);
            this.group_box_usuarios.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.group_box_usuarios.Location = new System.Drawing.Point(30, 34);
            this.group_box_usuarios.Name = "group_box_usuarios";
            this.group_box_usuarios.Size = new System.Drawing.Size(884, 169);
            this.group_box_usuarios.TabIndex = 2;
            this.group_box_usuarios.TabStop = false;
            this.group_box_usuarios.Text = "Usuário";
            // 
            // ok_usuario
            // 
            this.ok_usuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ok_usuario.Location = new System.Drawing.Point(198, 140);
            this.ok_usuario.Name = "ok_usuario";
            this.ok_usuario.Size = new System.Drawing.Size(75, 23);
            this.ok_usuario.TabIndex = 7;
            this.ok_usuario.Text = "Cadastrar";
            this.ok_usuario.UseVisualStyleBackColor = true;
            this.ok_usuario.Click += new System.EventHandler(this.ok_usuario_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastrarToolStripMenuItem});
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
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cervejaToolStripMenuItem,
            this.whiskeyToolStripMenuItem,
            this.paísToolStripMenuItem,
            this.tiposToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // cervejaToolStripMenuItem
            // 
            this.cervejaToolStripMenuItem.Name = "cervejaToolStripMenuItem";
            this.cervejaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cervejaToolStripMenuItem.Text = "Cerveja";
            this.cervejaToolStripMenuItem.Click += new System.EventHandler(this.cervejaToolStripMenuItem_Click);
            // 
            // whiskeyToolStripMenuItem
            // 
            this.whiskeyToolStripMenuItem.Name = "whiskeyToolStripMenuItem";
            this.whiskeyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.whiskeyToolStripMenuItem.Text = "Whiskey";
            this.whiskeyToolStripMenuItem.Click += new System.EventHandler(this.whiskeyToolStripMenuItem_Click);
            // 
            // paísToolStripMenuItem
            // 
            this.paísToolStripMenuItem.Name = "paísToolStripMenuItem";
            this.paísToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.paísToolStripMenuItem.Text = "País";
            this.paísToolStripMenuItem.Click += new System.EventHandler(this.paísToolStripMenuItem_Click);
            // 
            // tiposToolStripMenuItem
            // 
            this.tiposToolStripMenuItem.Name = "tiposToolStripMenuItem";
            this.tiposToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tiposToolStripMenuItem.Text = "Tipos";
            this.tiposToolStripMenuItem.Click += new System.EventHandler(this.tiposToolStripMenuItem_Click);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Senha
            // 
            this.Senha.HeaderText = "Senha";
            this.Senha.Name = "Senha";
            // 
            // Perfil
            // 
            this.Perfil.HeaderText = "Perfil";
            this.Perfil.Name = "Perfil";
            // 
            // txtbox_nome_usuario
            // 
            this.txtbox_nome_usuario.Location = new System.Drawing.Point(60, 32);
            this.txtbox_nome_usuario.Name = "txtbox_nome_usuario";
            this.txtbox_nome_usuario.Size = new System.Drawing.Size(213, 20);
            this.txtbox_nome_usuario.TabIndex = 0;
            this.txtbox_nome_usuario.TextChanged += new System.EventHandler(this.txtbox_nome_pais_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Senha";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txb_senha
            // 
            this.txb_senha.Location = new System.Drawing.Point(60, 58);
            this.txb_senha.Name = "txb_senha";
            this.txb_senha.Size = new System.Drawing.Size(213, 20);
            this.txb_senha.TabIndex = 8;
            this.txb_senha.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radio_comum
            // 
            this.radio_comum.AutoSize = true;
            this.radio_comum.Location = new System.Drawing.Point(13, 100);
            this.radio_comum.Name = "radio_comum";
            this.radio_comum.Size = new System.Drawing.Size(60, 17);
            this.radio_comum.TabIndex = 10;
            this.radio_comum.TabStop = true;
            this.radio_comum.Text = "Comum";
            this.radio_comum.UseVisualStyleBackColor = true;
            this.radio_comum.CheckedChanged += new System.EventHandler(this.radio_comum_CheckedChanged);
            // 
            // radio_gerencial
            // 
            this.radio_gerencial.AutoSize = true;
            this.radio_gerencial.Location = new System.Drawing.Point(139, 100);
            this.radio_gerencial.Name = "radio_gerencial";
            this.radio_gerencial.Size = new System.Drawing.Size(70, 17);
            this.radio_gerencial.TabIndex = 11;
            this.radio_gerencial.TabStop = true;
            this.radio_gerencial.Text = "Gerencial";
            this.radio_gerencial.UseVisualStyleBackColor = true;
            this.radio_gerencial.CheckedChanged += new System.EventHandler(this.radio_gerencial_CheckedChanged);
            // 
            // Cadastrar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 544);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grid_usuarios);
            this.Controls.Add(this.group_box_usuarios);
            this.Name = "Cadastrar_Usuario";
            this.Text = "Cadastrar_Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.grid_usuarios)).EndInit();
            this.group_box_usuarios.ResumeLayout(false);
            this.group_box_usuarios.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_usuarios;
        private System.Windows.Forms.GroupBox group_box_usuarios;
        private System.Windows.Forms.Button ok_usuario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cervejaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiskeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paísToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perfil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_nome_usuario;
        private System.Windows.Forms.RadioButton radio_gerencial;
        private System.Windows.Forms.RadioButton radio_comum;
    }
}