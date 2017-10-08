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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ok_login_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
                usuario.Username = user_login.Text;
                usuario.Password = txt_password.Text;
                usuario.Perfil = 1;

                Ctrl_Usuario controle = new Ctrl_Usuario();
                if (controle.validarUsuario(usuario))
                {
                    this.Tag = usuario;
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
            }   
            catch (Exception)
            {

                throw;
            }
        }
    }
}
