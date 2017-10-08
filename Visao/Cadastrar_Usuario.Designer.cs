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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_nome_usuario = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_usuarios)).BeginInit();
            this.group_box_usuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_usuarios
            // 
            this.grid_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Senha});
            this.grid_usuarios.Location = new System.Drawing.Point(30, 209);
            this.grid_usuarios.Name = "grid_usuarios";
            this.grid_usuarios.Size = new System.Drawing.Size(884, 290);
            this.grid_usuarios.TabIndex = 3;
            this.grid_usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_usuarios_CellContentClick);
            // 
            // group_box_usuarios
            // 
            this.group_box_usuarios.Controls.Add(this.ok_usuario);
            this.group_box_usuarios.Controls.Add(this.label1);
            this.group_box_usuarios.Controls.Add(this.txtbox_nome_usuario);
            this.group_box_usuarios.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.group_box_usuarios.Location = new System.Drawing.Point(30, 34);
            this.group_box_usuarios.Name = "group_box_usuarios";
            this.group_box_usuarios.Size = new System.Drawing.Size(884, 169);
            this.group_box_usuarios.TabIndex = 2;
            this.group_box_usuarios.TabStop = false;
            this.group_box_usuarios.Text = "Paises";
            // 
            // ok_usuario
            // 
            this.ok_usuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ok_usuario.Location = new System.Drawing.Point(198, 69);
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
            // Cadastrar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 544);
            this.Controls.Add(this.grid_usuarios);
            this.Controls.Add(this.group_box_usuarios);
            this.Name = "Cadastrar_Usuario";
            this.Text = "Cadastrar_Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.grid_usuarios)).EndInit();
            this.group_box_usuarios.ResumeLayout(false);
            this.group_box_usuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_usuarios;
        private System.Windows.Forms.GroupBox group_box_usuarios;
        private System.Windows.Forms.Button ok_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_nome_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
    }
}