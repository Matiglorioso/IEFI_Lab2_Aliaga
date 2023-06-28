﻿using System;
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
    public partial class frmAgregarPais : Form
    {
        public frmAgregarPais()
        {
            InitializeComponent();
        }
        CConectarBD x = new CConectarBD();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            x.RegistrarPais(txtAddPais.Text);
            txtAddPais.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal fr = new frmPrincipal();
            fr.ShowDialog();
            this.Close();
        }
    }
}
