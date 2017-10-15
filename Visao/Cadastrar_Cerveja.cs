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
    public partial class Cadastrar_Cerveja : Form
    {
        public Cadastrar_Cerveja()
        {
            InitializeComponent();
        }

        private void cbxTipoCerveja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbCervaNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void group_cervejas_Enter(object sender, EventArgs e)
        {

        }

        private void grid_cervejas_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
