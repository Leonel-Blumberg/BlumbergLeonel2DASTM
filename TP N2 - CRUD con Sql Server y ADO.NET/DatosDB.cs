using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using TP_N2___CRUD_con_Sql_Server_y_ADO.NET.Clases;

namespace TP_N2___CRUD_con_Sql_Server_y_ADO.NET
{
    public class DatosDB
    {
        private readonly string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=CRUDWindowsForm;" + "Integrated Security=True;" + "TrustServerCertificate=True";

        public bool VerificarConexion()
        {
            try
            {
                SqlConnection connection = new(connectionString);
                connection.Open();
            }
            catch { return false; }

            return true;
        }

        public List<Persona> GetDatos()
        {
            List<Persona> listaPersonas = [];

            string consulta = "select * from Personas";

            using SqlConnection connection = new(connectionString);
            SqlCommand command = new(consulta, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Persona persona = new()
                    {
                        ID = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Edad = reader.GetInt32(2)
                    };

                    listaPersonas.Add(persona);
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new DBException("Error al obtener los datos de la base de datos: " + ex.Message);
            }

            return listaPersonas;
        }

        public Persona GetID(int ID)
        {
            string consulta = "select ID,Nombre,Edad from Personas" + " where ID=@id";

            using SqlConnection connection = new(connectionString);

            SqlCommand command = new(consulta, connection);
            command.Parameters.AddWithValue("@id", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                Persona persona = new()
                {
                    ID = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Edad = reader.GetInt32(2)
                };

                reader.Close();
                connection.Close();

                return persona;
            }
            catch (Exception ex)
            {
                throw new DBException("Error al obtener los datos de la base de datos: " + ex.Message);
            }
        }

        public void AgregarPersona(string Nombre, int Edad)
        {
            string consulta = "insert into Personas(Nombre, Edad) values" + "(@nombre, @edad) ";

            using SqlConnection connection = new(connectionString);

            SqlCommand command = new(consulta, connection);
            command.Parameters.AddWithValue("@nombre", Nombre);
            command.Parameters.AddWithValue("@edad", Edad);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new DBException("Error al obtener los datos de la base de datos: " + ex.Message);
            }
        }

        public void EditarPersona(string Nombre, int Edad, int ID)
        {
            string consulta = "update Personas set Nombre=@nombre, Edad=@edad" + " where ID=@id ";

            using SqlConnection connection = new(connectionString);

            SqlCommand command = new(consulta, connection);
            command.Parameters.AddWithValue("@nombre", Nombre);
            command.Parameters.AddWithValue("@edad", Edad);
            command.Parameters.AddWithValue("@id", ID);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new DBException("Error al obtener los datos de la base de datos: " + ex.Message);
            }
        }

        public void EliminarPersona(int ID)
        {
            string consulta = "delete from Personas" + " where ID=@id ";

            using SqlConnection connection = new(connectionString);

            SqlCommand command = new(consulta, connection);
            command.Parameters.AddWithValue("@id", ID);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new DBException("Error al obtener los datos de la base de datos: " + ex.Message);
            }
        }
    }
}
