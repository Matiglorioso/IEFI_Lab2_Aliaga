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
    public partial class frmPrinipakl : Form
    {
        public frmPrinipakl()
        {
            InitializeComponent();
        }

        private void registrarNuevoSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void registrarNuevopaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarPais frmp = new frmAgregarPais();
            frmp.ShowDialog();
        }
    }
}
