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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CConectarBD cnn = new CConectarBD();
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                cmbLugar.Items.Clear();
                cnn.CargarCombo(cmbLugar);
     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string Nombre = txtNombre.Text;
                string Apellido = txtApellido.Text;
                string LugarNacimiento = cmbLugar.SelectedValue.ToString();
                int Edad = int.Parse(txtEdad.Text);
                float Ingreso = float.Parse(txtIngreso.Text);
                int Puntaje = int.Parse(txtPuntaje.Text);
                cnn.Grabar1(Nombre, Apellido, LugarNacimiento, Edad, Ingreso, Puntaje);
                txtApellido.Text = "";
                txtEdad.Text = "";
                txtIngreso.Text = "";
                txtNombre.Text = "";
                txtPuntaje.Text = "";
                cmbLugar.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
