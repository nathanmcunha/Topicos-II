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
    public partial class frmConfirmacao : Form
    {
        public frmConfirmacao()
        {
            InitializeComponent();
        }

        private void frmConfirmacao_Load(object sender, EventArgs e)
        {
            lblMsg.Text = this.Tag.ToString();
        }

        
    }
}
