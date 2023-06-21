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
        OleDbConnection CNN;
        OleDbCommand cmdSocios;
        OleDbCommand cmdPaises;
        OleDbDataAdapter DASocios;
        OleDbDataAdapter DAPaises;
        OleDbDataReader DR;
        DataSet DS;
        String TablaSocios = "SOCIOS";
        String TablaPaises = "Paises";

        string Coneccion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EL_CLUB.accdb";


        //sql conerccion
        //static string conexionstring = "server= localhost ; database= "

        public CConectarBD() 
        {
            try
            {
                CNN = new OleDbConnection();
                CNN.ConnectionString = Coneccion;
                CNN.Open();
                DS = new DataSet();
                // tabla socios
                cmdSocios = new OleDbCommand();
                cmdSocios.Connection = CNN;
                cmdSocios.CommandType = CommandType.TableDirect;
                cmdSocios.CommandText = TablaSocios;
                DASocios = new OleDbDataAdapter(cmdSocios);
                DR = cmdSocios.ExecuteReader();
                OleDbCommandBuilder cbS = new OleDbCommandBuilder(DASocios);
                // tabla paises
                DAPaises = new OleDbDataAdapter("SELECT NombrePais FROM Paises", CNN);
                OleDbCommandBuilder cbP = new OleDbCommandBuilder(DAPaises);

                CNN.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void CargarCombo1(ComboBox paises)
        {

            while(DR.Read())
            {
                paises.Items.Add(DR[3]);
            }
        }

        public void CargarCombo(ComboBox paises)
        {
            try
            {
                CNN.Open(); // Abrir la conexión antes de cargar el ComboBox

                DAPaises.Fill(DS, "Paises");

                paises.DataSource = DS.Tables["Paises"];
                paises.DisplayMember = "NombrePais";

                CNN.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }

        }
        public void Grabar(string nombre, string apellido, string pais, bool sexo, int edad, float ingreso, int puntaje)
        {
            try
            {
                CNN.ConnectionString = Coneccion;
                CNN.Open();

                cmdSocios.Connection = CNN;
                cmdSocios.CommandType = CommandType.TableDirect;
                cmdSocios.CommandText = TablaSocios;

                DASocios = new OleDbDataAdapter(cmdSocios);
                DataSet DS = new DataSet();
                DASocios.Fill(DS, TablaSocios);

                DataTable tabla = DS.Tables[TablaSocios];
                DataRow dr = tabla.NewRow();

                dr["NOMBRE"] = nombre;
                dr["APELLIDO"] = apellido;
                dr["LUGAR_NACIMIENTO"] = pais;
                dr["EDAD"] = edad;
                dr["SEXO"] = sexo;
                dr["INGRESO"] = ingreso;
                dr["PUNTAJE"] = puntaje;
                tabla.Rows.Add(dr);
                OleDbCommandBuilder cb = new OleDbCommandBuilder(DASocios);
                DASocios.Update(DS, TablaSocios);
                CNN.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void Grabar1(string nombre, string apellido, string pais, int edad, float ingreso, int puntaje)
        {
            string cadena = "Insert into SOCIOS ([NOMBRE], [APELLIDO], [LUGAR_NACIMIENTO], [EDAD], [INGRESO], [PUNTAJE]" +
                " values ('"+nombre+"','"+apellido+ "','"+pais+"','"+edad+"','"+ingreso+"','"+puntaje+"')";
            SqlCommand comando = new SqlCommand(cadena);
            comando.ExecuteNonQuery();
        }
        public void CargarPais(string pais)
        {
            cmdSocios.Connection = CNN;
            cmdSocios.Connection.Open();

            cmdSocios.CommandType = CommandType.Text;
            cmdSocios.CommandText = "SELECT NombrePais FROM Paises WHERE NombrePais = ?";
            cmdSocios.Parameters.AddWithValue("@Pais", pais);
            DR = cmdSocios.ExecuteReader();

            if(DR.HasRows)
            {
                MessageBox.Show("El pais ingresado ya existe");
                return;
            }
            DR.Close();
            cmdSocios.CommandText = "INSERT INTO Paises (NombrePais) VALUES (?)";
            cmdSocios.Parameters.AddWithValue("@Pais", pais);

            cmdSocios.ExecuteNonQuery();
            cmdSocios.Connection.Close();
        }
    }
}
