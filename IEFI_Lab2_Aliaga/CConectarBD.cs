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
    //internal class CConectarBD
    //{
    //    OleDbConnection CNN;
    //    OleDbCommand cmdSocios;
    //    OleDbCommand cmdPaises;
    //    OleDbDataAdapter DASocios;
    //    OleDbDataAdapter DAPaises;
    //    OleDbDataReader DR;
    //    DataSet DS;
    //    String TablaSocios = "SOCIOS";
    //    String TablaPaises = "Paises";

    //    string Coneccion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EL_CLUB.accdb";


    //    //sql conerccion
    //    //static string conexionstring = "server= localhost ; database= "

    //    public CConectarBD() 
    //    {
    //        try
    //        {
    //            CNN = new OleDbConnection();
    //            CNN.ConnectionString = Coneccion;
    //            CNN.Open();
    //            DS = new DataSet();
    //            // tabla socios
    //            cmdSocios = new OleDbCommand();
    //            cmdSocios.Connection = CNN;
    //            cmdSocios.CommandType = CommandType.TableDirect;
    //            cmdSocios.CommandText = TablaSocios;
    //            DASocios = new OleDbDataAdapter(cmdSocios);
    //            DR = cmdSocios.ExecuteReader();
    //            OleDbCommandBuilder cbS = new OleDbCommandBuilder(DASocios);
    //            // tabla paises
    //            DAPaises = new OleDbDataAdapter("SELECT NombrePais FROM Paises", CNN);
    //            OleDbCommandBuilder cbP = new OleDbCommandBuilder(DAPaises);

    //            CNN.Close();
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("Error: " + ex.Message);
    //        }
    //    }


    //    public void CargarCombo(ComboBox paises)
    //    {
    //        try
    //        {
    //            CNN.Open(); // Abrir la conexión antes de cargar el ComboBox

    //            DAPaises.Fill(DS, "Paises");

    //            paises.DataSource = DS.Tables["Paises"];
    //            paises.DisplayMember = "NombrePais";

    //            CNN.Close();
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("Error al cargar los datos: " + ex.Message);
    //        }

    //    }

    //    // Método para registrar un nuevo socio en la base de datos
    //    public void RegistrarSocio(string nombre, string apellido, string lugarNacimiento, int edad, bool sexo, decimal ingreso, int puntaje)
    //    {
    //        string connectionString = Coneccion;
    //        string insertQuery = "INSERT INTO Socios (NOMBRE, APELLIDO, LUGAR_NACIMIENTO, EDAD, SEXO, INGRESO, PUNTAJE) VALUES (?, ?, ?, ?, ?, ?, ?)";

    //        OleDbConnection connection = null;
    //        OleDbCommand command = null;

    //        try
    //        {
    //            connection = new OleDbConnection(connectionString);
    //            command = new OleDbCommand(insertQuery, connection);

    //            // Parámetros del comando para evitar problemas de seguridad y tipo de datos
    //            command.Parameters.Add("@NOMBRE", OleDbType.VarChar).Value = nombre;
    //            command.Parameters.Add("@APELLIDO", OleDbType.VarChar).Value = apellido;
    //            command.Parameters.Add("@LUGAR_NACIMIENTO", OleDbType.VarChar).Value = lugarNacimiento;
    //            command.Parameters.Add("@EDAD", OleDbType.Integer).Value = edad;
    //            command.Parameters.Add("@SEXO", OleDbType.Boolean).Value = sexo;
    //            command.Parameters.Add("@INGRESO", OleDbType.Currency).Value = ingreso;
    //            command.Parameters.Add("@PUNTAJE", OleDbType.Integer).Value = puntaje;

    //            connection.Open();
    //            int rowsAffected = command.ExecuteNonQuery();
    //            if (rowsAffected > 0)
    //            {
    //                MessageBox.Show("Socio registrado correctamente.");
    //                // Aquí puedes realizar otras acciones después de registrar al socio
    //            }
    //            else
    //            {
    //                MessageBox.Show("No se pudo registrar al socio.");
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("Error al registrar al socio: " + ex.Message);
    //        }
    //        finally
    //        {
    //            // Cerrar y liberar manualmente los objetos de conexión y comando
    //            if (command != null)
    //            {
    //                command.Dispose();
    //                command = null;
    //            }
    //            if (connection != null)
    //            {
    //                if (connection.State != ConnectionState.Closed)
    //                {
    //                    connection.Close();
    //                }
    //                connection.Dispose();
    //                connection = null;
    //            }
    //        }
    //    }
    //    public void RegistrarPais(string nombrePais)
    //    {
    //        string selectQuery = "SELECT COUNT(*) FROM Paises WHERE NombrePais = ?";
    //        string insertQuery = "INSERT INTO Paises (NombrePais) VALUES (?)";

    //        OleDbConnection connection = null;
    //        OleDbCommand command = null;

    //        try
    //        {
    //            connection = new OleDbConnection(Coneccion);
    //            connection.Open();

    //            // Verificar si el país ya está registrado en la base de datos
    //            command = new OleDbCommand(selectQuery, connection);
    //            command.Parameters.AddWithValue("@NombrePais", nombrePais);

    //            int existingCount = (int)command.ExecuteScalar();
    //            if (existingCount > 0)
    //            {
    //                MessageBox.Show("El país ya ha sido registrado anteriormente.");
    //                return; // Salir del método sin realizar el registro
    //            }

    //            // Insertar el nuevo país en la base de datos
    //            command = new OleDbCommand(insertQuery, connection);
    //            command.Parameters.AddWithValue("@NombrePais", nombrePais);

    //            int rowsAffected = command.ExecuteNonQuery();
    //            if (rowsAffected > 0)
    //            {
    //                MessageBox.Show("País registrado correctamente.");
    //            }
    //            else
    //            {
    //                MessageBox.Show("No se pudo registrar el país.");
    //            }

    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Error al registrar el país: " + ex.Message);
    //            throw; // Vuelve a lanzar la excepción para propagarla hacia arriba
    //        }
    //        finally
    //        {
    //            // Cerrar la conexión y liberar los recursos
    //            if (command != null)
    //            {
    //                command.Dispose();
    //            }
    //            if (connection != null)
    //            {
    //                if (connection.State != ConnectionState.Closed)
    //                {
    //                    connection.Close();
    //                }
    //                connection.Dispose();
    //            }
    //        }
    //    }


    internal class CConectarBD
    {
        private string Coneccion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EL_CLUB.accdb";
        private OleDbConnection connection;

        public CConectarBD()
        {
            connection = new OleDbConnection(Coneccion);
        }

        public void CargarCombo(ComboBox paises)
        {
            try
            {
                connection.Open();

                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT NombrePais FROM Paises", connection);
                DataTable dtPaises = new DataTable();
                adapter.Fill(dtPaises);

                paises.DataSource = dtPaises;
                paises.DisplayMember = "NombrePais";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        public void RegistrarSocio(string nombre, string apellido, string lugarNacimiento, int edad, bool sexo, decimal ingreso, int puntaje)
        {
            string selectQuery = "SELECT COUNT(*) FROM Socios WHERE NOMBRE = ? AND APELLIDO = ?";
            string insertQuery = "INSERT INTO Socios (NOMBRE, APELLIDO, LUGAR_NACIMIENTO, EDAD, SEXO, INGRESO, PUNTAJE) VALUES (?, ?, ?, ?, ?, ?, ?)";

            OleDbCommand command = null;

            try
            {
                connection.Open();

                // Verificar si ya existe un socio con el mismo nombre y apellido
                command = new OleDbCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@NOMBRE", nombre);
                command.Parameters.AddWithValue("@APELLIDO", apellido);

                int existingCount = (int)command.ExecuteScalar();
                if (existingCount > 0)
                {
                    MessageBox.Show("Ya existe un socio con el mismo nombre y apellido.");
                    return; // Salir del método si el socio ya existe
                }
                else
                {
                    // Insertar el nuevo socio en la base de datos
                    command = new OleDbCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@NOMBRE", nombre);
                    command.Parameters.AddWithValue("@APELLIDO", apellido);
                    command.Parameters.AddWithValue("@LUGAR_NACIMIENTO", lugarNacimiento);
                    command.Parameters.AddWithValue("@EDAD", edad);
                    command.Parameters.AddWithValue("@SEXO", sexo);
                    command.Parameters.AddWithValue("@INGRESO", ingreso);
                    command.Parameters.AddWithValue("@PUNTAJE", puntaje);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Socio registrado correctamente.");
                        return; // Salir del método después de mostrar el MessageBox
                    }
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar al socio: " + ex.Message);
            }
            finally
            {
                if (command != null)
                {
                    command.Dispose();
                    command = null;
                }

                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            MessageBox.Show("No se pudo registrar al socio.");
        }


        public void RegistrarPais(string nombrePais)
        {
            string selectQuery = "SELECT COUNT(*) FROM Paises WHERE NombrePais = ?";
            string insertQuery = "INSERT INTO Paises (NombrePais) VALUES (?)";

            OleDbCommand selectCommand = null;
            OleDbCommand insertCommand = null;

            try
            {
                connection.Open();

                selectCommand = new OleDbCommand(selectQuery, connection);
                selectCommand.Parameters.AddWithValue("@NombrePais", nombrePais);

                int existingCount = (int)selectCommand.ExecuteScalar();
                if (existingCount > 0)
                {
                    MessageBox.Show("El país ya ha sido registrado anteriormente.");
                    return; // Salir del método sin realizar el registro
                }

                insertCommand = new OleDbCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@NombrePais", nombrePais);

                int rowsAffected = insertCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("País registrado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el país.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el país: " + ex.Message);
            }
            finally
            {
                if (selectCommand != null)
                {
                    selectCommand.Dispose();
                    selectCommand = null;
                }
                if (insertCommand != null)
                {
                    insertCommand.Dispose();
                    insertCommand = null;
                }

                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }
    }

}
