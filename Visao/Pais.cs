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
using Pais_Model = Modelo.Pais;
using Controle;

namespace Visao
{
    public partial class Pais : Form
    {
        public Pais()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ok_pais_Click(object sender, EventArgs e)
        {

            Pais_Model pais = new Pais_Model();
            Pais_Controle pais_control = new Pais_Controle();
            pais.Nome = txtbox_nome_pais.Text;
            pais_control.Inserir_Pais(pais);
            this.paisTableAdapter2.Fill(this.dataset_Pais.pais);
            //CarregarGrid();

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

        private void txtbox_nome_pais_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pais_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset_Pais.pais' table. You can move, or remove it, as needed.
            this.paisTableAdapter2.Fill(this.dataset_Pais.pais);
            // TODO: This line of code loads data into the 'shabbaDataSet3.pais' table. You can move, or remove it, as needed.
            //this.paisTableAdapter1.Fill(this.shabbaDataSet3.pais);
            //CarregarGrid();

        }

        private void grid_pais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Int16.Parse(grid_pais.SelectedRows[0].Cells[0].Value.ToString());

                Pais_Controle controle = new Pais_Controle();
                Pais_Model pais = controle.BuscarPorPaisID(id);

                CarregarFormDePais(pais);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        public void CarregarGrid()
        {
            try
            {
                grid_pais.Rows.Clear();

                Pais_Controle controleGar = new Pais_Controle();
                List<Pais_Model> lista = controleGar.BuscarTodosPaises();

                foreach (Pais_Model garcom in lista)
                {
                    grid_pais.Rows.Add(garcom.Id, garcom.Nome);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }
        
      

        private void CarregarFormDePais(Pais_Model pais)
        {
            try
            {
                lblId.Text = pais.Id.ToString();
                txtbox_nome_pais.Text = pais.Nome;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
                frmConfirmacao form = new frmConfirmacao();
                form.Tag = "Confirma deleção de Pais?";
                if (form.ShowDialog() == DialogResult.Yes)
                {
                    if (Convert.ToInt32(lblId.Text) > 0)
                    {
                        int id = Int16.Parse(grid_pais.SelectedRows[0].Cells[0].Value.ToString());
                        Pais_Controle controle = new Pais_Controle();

                        controle.DeletarPais(id);

                        //LimparFormulario();

                        CarregarGrid();

                        MessageBox.Show("Pais excluído com sucesso!!!");
                    }
                    else
                    {
                        MessageBox.Show("Nenhum garçom Pais!!!");
                    }
                }
            }

        private void lblId_Click(object sender, EventArgs e)
        {

        }
       
        }

    }

