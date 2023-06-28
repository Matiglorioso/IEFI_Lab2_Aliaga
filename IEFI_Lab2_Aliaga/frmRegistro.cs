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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }
        CConectarBD cnn = new CConectarBD();
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                txtApellido.Text = "";
                txtEdad.Text = "";
                txtIngreso.Text = "";
                txtNombre.Text = "";
                txtPuntaje.Text = "";
                cmbLugar.SelectedIndex = 0;
                optMasculino.Checked = true;
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
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string lugarNacimiento = cmbLugar.SelectedValue.ToString();
                int edad = int.Parse(txtEdad.Text);
                bool sexo = optMasculino.Checked;
                decimal ingreso = decimal.Parse(txtIngreso.Text);
                int puntaje = int.Parse(txtPuntaje.Text);
               if(ValidarDatos())
                {
                    cnn.RegistrarSocio(nombre, apellido, lugarNacimiento, edad, sexo, ingreso, puntaje);

                    // No es necesario verificar el valor de retorno, ya que el método no devuelve un valor
                    MessageBox.Show("Socio registrado correctamente.");

                    txtApellido.Text = "";
                    txtEdad.Text = "";
                    txtIngreso.Text = "";
                    txtNombre.Text = "";
                    txtPuntaje.Text = "";
                    cmbLugar.SelectedIndex = 0;
                }
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public bool ValidarDatos()
        {
            // Realizar todas las validaciones necesarias
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese su nombre.");
                return false;
            }

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Por favor, ingrese su apellido.");
                return false;
            }

            if (cmbLugar.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione su país de nacimiento.");
                return false;
            }

            if (int.Parse(txtEdad.Text) < 50)
            {
                MessageBox.Show("La edad debe ser igual o mayor a 50.");
                return false;
            }

            if (int.Parse(txtIngreso.Text) < 1000)
            {
                MessageBox.Show("El ingreso debe ser igual o mayor a 1000.");
                return false;
            }

            if (decimal.Parse(txtPuntaje.Text) < 129.5m)
            {
                MessageBox.Show("El puntaje debe ser igual o mayor a 129.5.");
                return false;
            }

            // Si todas las validaciones son exitosas, los datos son válidos
            return true;
        }

    }
}
