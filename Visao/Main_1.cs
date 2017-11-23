using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Visao
{
    public partial class Main_1 : Form
    {
        public Main_1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cad_Pais(object sender, EventArgs e)
        {
            Pais form = new Pais();
            form.ShowDialog();
        }

        private void cad_Usuarios(object sender, EventArgs e)
        {
            Cadastrar_Usuario form = new Cadastrar_Usuario();
            form.ShowDialog();
        }

        private void cad_Cerveja(object sender, EventArgs e)
        {
           Cadastrar_Cerveja form = new Cadastrar_Cerveja();
            form.ShowDialog();
        }

        private void cad_Whiskey(object sender, EventArgs e)
        {
            Whiskey form = new Whiskey();
            form.ShowDialog();
        }

        private void cad_Tipos(object sender, EventArgs e)
        {
            Tipo form = new Tipo();
            form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
           
            EfetuarLogin();
        }

        private void EfetuarLogin()
        {
            Login form = new Login();

            if (!(form.ShowDialog() == DialogResult.Yes))
            {
                this.Close();
            }

            Usuario user = (Usuario)form.Tag;


            if (user.Perfil == 2)
            {
                gerencial.Enabled = false;
            }
        }
        private void groupBox1_Enter_1(object sender, EventArgs e)
        {
        
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cervejaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar_Cerveja form = new Cadastrar_Cerveja();
            form.ShowDialog();
        }

        private void whiskeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Whiskey form = new Whiskey();
            form.ShowDialog();
        }

        private void paísToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pais form = new Pais();
            form.ShowDialog();
        }

        private void tiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo form = new Tipo();
            form.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbtime.Text = DateTime.Now.ToString();
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            lbtime.Font = fontDialog1.Font;
            bemvindo.Font = fontDialog1.Font;
           
        }

        private void temaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                this.BackColor = colorDialog1.Color;

            }

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}

