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
using Controle;

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

        private void cbxPais_SelectedIndexChanged(object sender, EventArgs e)
        {
      
 
            
        }
        
  

        private void Cadastrar_Cerveja_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shabbaDataSet5.cerveja' table. You can move, or remove it, as needed.
            this.cervejaTableAdapter.Fill(this.shabbaDataSet5.cerveja);
            // TODO: This line of code loads data into the 'data_set_tipo.tipo' table. You can move, or remove it, as needed.
            this.tipoTableAdapter1.Fill(this.data_set_tipo.tipo);
            // TODO: This line of code loads data into the 'set_pais_cerveja.pais' table. You can move, or remove it, as needed.
            this.paisTableAdapter1.Fill(this.set_pais_cerveja.pais);
            // TODO: This line of code loads data into the 'shabbaDataSet2.tipo' table. You can move, or remove it, as needed.
            this.tipoTableAdapter.Fill(this.shabbaDataSet2.tipo);
            // TODO: This line of code loads data into the 'shabbaDataSet1.pais' table. You can move, or remove it, as needed.
            this.paisTableAdapter.Fill(this.shabbaDataSet1.pais);
            
        }

        private void ok_cerveja_Click(object sender, EventArgs e)
        {


            Cerveja cerveja = new Cerveja();
            Cerveja_Controle cerveja_control = new Cerveja_Controle();
            int id_pais = Convert.ToInt32((cbxPais.SelectedValue.ToString()));
            int id_tipo = Convert.ToInt32((cbxTipoCerveja.SelectedValue.ToString()));
            
            cerveja.Nome = txbCervaNome.Text;
            cerveja.Pais = id_pais;
            cerveja.Qtd = Convert.ToInt32(txbQtd_cerveja.Text);
            cerveja.Tipo = id_tipo;
            cerveja_control.Inserir_Cerveja(cerveja);
            this.cervejaTableAdapter.Fill(this.shabbaDataSet5.cerveja);
            
            
        }

        private void deletar_Click(object sender, EventArgs e)
        {
  
            int id = int.Parse(grid_cervejas.SelectedRows[0].Cells[0].Value.ToString());
            Cerveja_Controle cerveja_control = new Cerveja_Controle();
            cerveja_control.Deletar_Cerveja(id);
            this.cervejaTableAdapter.Fill(this.shabbaDataSet5.cerveja);
           
        }
    
    }
}
