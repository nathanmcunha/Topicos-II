namespace Visao
{
    partial class Main_1
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
            this.cad_cerveja_main = new System.Windows.Forms.Button();
            this.cad_pais_main = new System.Windows.Forms.Button();
            this.cad_whiskey_main = new System.Windows.Forms.Button();
            this.cad_tipos_main = new System.Windows.Forms.Button();
            this.cad_usuarios_main = new System.Windows.Forms.Button();
            this.group_main = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cervejaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiskeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paísToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.group_main.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cad_cerveja_main
            // 
            this.cad_cerveja_main.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cad_cerveja_main.Location = new System.Drawing.Point(36, 41);
            this.cad_cerveja_main.Name = "cad_cerveja_main";
            this.cad_cerveja_main.Size = new System.Drawing.Size(122, 79);
            this.cad_cerveja_main.TabIndex = 0;
            this.cad_cerveja_main.Text = "Cadastrar Cerveja";
            this.cad_cerveja_main.UseVisualStyleBackColor = true;
            this.cad_cerveja_main.Click += new System.EventHandler(this.cad_Cerveja);
            // 
            // cad_pais_main
            // 
            this.cad_pais_main.Location = new System.Drawing.Point(214, 218);
            this.cad_pais_main.Name = "cad_pais_main";
            this.cad_pais_main.Size = new System.Drawing.Size(122, 79);
            this.cad_pais_main.TabIndex = 2;
            this.cad_pais_main.Text = "Cadastrar País";
            this.cad_pais_main.UseVisualStyleBackColor = true;
            this.cad_pais_main.Click += new System.EventHandler(this.cad_Pais);
            // 
            // cad_whiskey_main
            // 
            this.cad_whiskey_main.Location = new System.Drawing.Point(214, 41);
            this.cad_whiskey_main.Name = "cad_whiskey_main";
            this.cad_whiskey_main.Size = new System.Drawing.Size(122, 79);
            this.cad_whiskey_main.TabIndex = 3;
            this.cad_whiskey_main.Text = "Cadastrar Whiskey";
            this.cad_whiskey_main.UseVisualStyleBackColor = true;
            this.cad_whiskey_main.Click += new System.EventHandler(this.cad_Whiskey);
            // 
            // cad_tipos_main
            // 
            this.cad_tipos_main.Location = new System.Drawing.Point(36, 218);
            this.cad_tipos_main.Name = "cad_tipos_main";
            this.cad_tipos_main.Size = new System.Drawing.Size(122, 79);
            this.cad_tipos_main.TabIndex = 4;
            this.cad_tipos_main.Text = "Cadastrar Tipos";
            this.cad_tipos_main.UseVisualStyleBackColor = true;
            this.cad_tipos_main.Click += new System.EventHandler(this.cad_Tipos);
            // 
            // cad_usuarios_main
            // 
            this.cad_usuarios_main.Location = new System.Drawing.Point(52, 41);
            this.cad_usuarios_main.Name = "cad_usuarios_main";
            this.cad_usuarios_main.Size = new System.Drawing.Size(122, 79);
            this.cad_usuarios_main.TabIndex = 5;
            this.cad_usuarios_main.Text = "Cadastrar Usuários";
            this.cad_usuarios_main.UseVisualStyleBackColor = true;
            this.cad_usuarios_main.Click += new System.EventHandler(this.cad_Usuarios);
            // 
            // group_main
            // 
            this.group_main.Controls.Add(this.cad_pais_main);
            this.group_main.Controls.Add(this.cad_cerveja_main);
            this.group_main.Controls.Add(this.cad_tipos_main);
            this.group_main.Controls.Add(this.cad_whiskey_main);
            this.group_main.Location = new System.Drawing.Point(27, 131);
            this.group_main.Name = "group_main";
            this.group_main.Size = new System.Drawing.Size(411, 356);
            this.group_main.TabIndex = 6;
            this.group_main.TabStop = false;
            this.group_main.Text = "Estoque";
            this.group_main.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cad_usuarios_main);
            this.groupBox1.Location = new System.Drawing.Point(508, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 356);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerencial";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Seja Bem Vindo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(971, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
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
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // Main_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.group_main);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_1";
            this.Text = "Controle de Estoque";
            this.Load += new System.EventHandler(this.Main_Load);
            this.group_main.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cad_cerveja_main;
        private System.Windows.Forms.Button cad_pais_main;
        private System.Windows.Forms.Button cad_whiskey_main;
        private System.Windows.Forms.Button cad_tipos_main;
        private System.Windows.Forms.Button cad_usuarios_main;
        private System.Windows.Forms.GroupBox group_main;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cervejaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiskeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paísToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
    }
}