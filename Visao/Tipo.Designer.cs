﻿namespace Visao
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cervejaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiskeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paísToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tipo)).BeginInit();
            this.grpBox_tipo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
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
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
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
            // Tipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 544);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grid_tipo);
            this.Controls.Add(this.grpBox_tipo);
            this.Name = "Tipo";
            this.Text = "Tipo";
            ((System.ComponentModel.ISupportInitialize)(this.grid_tipo)).EndInit();
            this.grpBox_tipo.ResumeLayout(false);
            this.grpBox_tipo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.GroupBox grpBox_tipo;
        private System.Windows.Forms.Button ok_tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_nome_tipo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cervejaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiskeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paísToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposToolStripMenuItem;
    }
}