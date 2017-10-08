using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visao
{
    public partial class Main : Form
    {
        public Main()
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
    }
}

