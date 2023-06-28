using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEFI_Lab2_Aliaga
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void registrarNuevoSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistro frm = new frmRegistro();
            frm.ShowDialog();
        }

        private void registrarNuevopaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarPais frmp = new frmAgregarPais();
            frmp.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
