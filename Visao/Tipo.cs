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
using Tipo_Model = Modelo.Tipo;
using Controle;


namespace Visao
{
    public partial class Tipo : Form
    {
        public Tipo()
        {
            InitializeComponent();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_tipo_Click(object sender, EventArgs e)
        {
            Tipo_Model tipo = new Tipo_Model();
            Tipo_Controle tipo_control = new Tipo_Controle();
            tipo.Nome = txtbox_nome_tipo.Text;
            tipo_control.Inserir_Tipo(tipo);
            this.tipoTableAdapter.Fill(this.shabbaDataSet4.tipo);
            //CarregarGrid();
        }

        private void txtbox_nome_tipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpBox_tipo_Enter(object sender, EventArgs e)
        {

        }
        private void Tipo_Load(object sender, EventArgs e)
        {
           // CarregarGrid();

        }
        public void CarregarGrid()
        {

            try
            {
                grid_tipo.Rows.Clear();

                Tipo_Controle controleTipo = new Tipo_Controle();
                List<Tipo_Model> lista = controleTipo.BuscarTodosTipos();

                foreach (Tipo_Model pais in lista)
                {
                    grid_tipo.Rows.Add(pais.Id, pais.Nome);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        private void grid_tipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tipo_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shabbaDataSet4.tipo' table. You can move, or remove it, as needed.
            this.tipoTableAdapter.Fill(this.shabbaDataSet4.tipo);

        }
    
    }
}
