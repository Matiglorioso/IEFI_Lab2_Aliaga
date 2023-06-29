using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IEFI_Lab2_Aliaga
{
    internal class CConectarBD
    {
        private string Coneccion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EL_CLUB.accdb";
        private OleDbConnection cnn;
        OleDbCommand cmd;

        public CConectarBD()
        {
            cnn = new OleDbConnection(Coneccion);
        }

        public void CargarCombo(ComboBox paises)
        {
            try
            {
                cnn.Open();

                OleDbDataAdapter DAPaises = new OleDbDataAdapter("SELECT NombrePais FROM Paises", cnn);
                DataTable DTPaises = new DataTable();
                DAPaises.Fill(DTPaises);

                paises.DataSource = DTPaises;
                paises.DisplayMember = "NombrePais";
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }

        }

        public void RegistrarSocio(string nombre, string apellido, string lugarNacimiento, int edad, bool sexo, decimal ingreso, int puntaje)
        {
            string selectQuery = "SELECT COUNT(*) FROM Socios WHERE NOMBRE = ? AND APELLIDO = ?";
            string insertQuery = "INSERT INTO Socios (NOMBRE, APELLIDO, LUGAR_NACIMIENTO, EDAD, SEXO, INGRESO, PUNTAJE) VALUES (?, ?, ?, ?, ?, ?, ?)";


            try
            {
                cnn.Open();

                // Verificar si ya existe un socio con el mismo nombre y apellido
                cmd = new OleDbCommand(selectQuery, cnn);
                cmd.Parameters.AddWithValue("@NOMBRE", nombre);
                cmd.Parameters.AddWithValue("@APELLIDO", apellido);

                int i = (int)cmd.ExecuteScalar();
                if (i > 0)
                {
                    MessageBox.Show("Ya existe un socio con el mismo nombre y apellido.");
                    return; // Salir del método si el socio ya existe
                }
                else
                {
                    // Insertar el nuevo socio en la base de datos
                    cmd = new OleDbCommand(insertQuery, cnn);
                    cmd.Parameters.AddWithValue("@NOMBRE", nombre);
                    cmd.Parameters.AddWithValue("@APELLIDO", apellido);
                    cmd.Parameters.AddWithValue("@LUGAR_NACIMIENTO", lugarNacimiento);
                    cmd.Parameters.AddWithValue("@EDAD", edad);
                    cmd.Parameters.AddWithValue("@SEXO", sexo);
                    cmd.Parameters.AddWithValue("@INGRESO", ingreso);
                    cmd.Parameters.AddWithValue("@PUNTAJE", puntaje);

                    int fila = cmd.ExecuteNonQuery();
                    if (fila > 0)
                    {
                        MessageBox.Show("Socio registrado correctamente.");

                    }
                    cnn.Close();
                    cmd.Dispose();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar al socio: " + ex.Message);
            }          

        }


        public void RegistrarPais(string nombrePais)
        {
            string selectQuery = "SELECT COUNT(*) FROM Paises WHERE NombrePais = ?";
            string insertQuery = "INSERT INTO Paises (NombrePais) VALUES (?)";

            OleDbCommand selectcmd = null;

            try
            {
                cnn.Open();

                cmd = new OleDbCommand(selectQuery, cnn);
                selectcmd.Parameters.AddWithValue("@NombrePais", nombrePais);

                int i = (int)selectcmd.ExecuteScalar();
                if (i > 0)
                {
                    MessageBox.Show("El país ya ha sido registrado anteriormente.");
                    return; // Salir del método sin realizar el registro
                }

                cmd = new OleDbCommand(insertQuery, cnn);
                cmd.Parameters.AddWithValue("@NombrePais", nombrePais);

                int fila = cmd.ExecuteNonQuery();
                if (fila > 0)
                {
                    MessageBox.Show("País registrado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el país.");
                }
                cnn.Close() ;
                selectcmd.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el país: " + ex.Message);
            }
            
        }
    }

}
