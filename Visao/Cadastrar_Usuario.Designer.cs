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
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_box_usuarios = new System.Windows.Forms.GroupBox();
            this.radio_gerencial = new System.Windows.Forms.RadioButton();
            this.radio_comum = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_senha = new System.Windows.Forms.TextBox();
            this.ok_usuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_nome_usuario = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.grid_usuarios)).BeginInit();
            this.group_box_usuarios.SuspendLayout();
            this.menuStrip2.SuspendLayout();
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
            // txtbox_nome_usuario
            // 
            this.txtbox_nome_usuario.Location = new System.Drawing.Point(60, 32);
            this.txtbox_nome_usuario.Name = "txtbox_nome_usuario";
            this.txtbox_nome_usuario.Size = new System.Drawing.Size(213, 20);
            this.txtbox_nome_usuario.TabIndex = 0;
            this.txtbox_nome_usuario.TextChanged += new System.EventHandler(this.txtbox_nome_pais_TextChanged);
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
            this.temaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.temaToolStripMenuItem.Text = "Tema";
            // 
            // Cadastrar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 544);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.grid_usuarios);
            this.Controls.Add(this.group_box_usuarios);
            this.Name = "Cadastrar_Usuario";
            this.Text = "Cadastrar_Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.grid_usuarios)).EndInit();
            this.group_box_usuarios.ResumeLayout(false);
            this.group_box_usuarios.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_usuarios;
        private System.Windows.Forms.GroupBox group_box_usuarios;
        private System.Windows.Forms.Button ok_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perfil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_nome_usuario;
        private System.Windows.Forms.RadioButton radio_gerencial;
        private System.Windows.Forms.RadioButton radio_comum;
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
    }
}