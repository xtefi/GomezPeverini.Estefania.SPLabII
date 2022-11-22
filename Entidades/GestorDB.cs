using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    class GestorDB
    {
        private static string cadenaConexion;

        static GestorDB()
        {
            cadenaConexion = @"Server=.\SQLEXPRESS;Database=Libreria;Trusted_Connection=True;";
        }

        public static List<Utiles> LeerDatos()
        {
            List<Utiles> datos = new List<Utiles>();
            try
            {
                string query = "SELECT * FROM Transportistas";
                using (SqlConnection conexion = new SqlConnection(GestorDB.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    conexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //int id = reader.GetInt32(0);
                        //string nombre = reader.GetString(1);
                        //string cuit = reader.GetString(2);
                        //string patente = reader.GetString(3);
                        //long toneladas = reader.GetInt64(4);
                        //Enumerados.Granos.Grano tipoGrano = (Enumerados.Granos.Grano)reader.GetInt32(5);
                        //DateTime fechaIngreso = reader.GetDateTime(6);
                        //DateTime fechaDescarga = reader.GetDateTime(7);
                        //Utiles u = new Utiles(cuit, nombre, patente, toneladas, tipoGrano, fechaIngreso, fechaDescarga, id);
                        //datos.Add(transportista);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return datos;
        }

    }
}
