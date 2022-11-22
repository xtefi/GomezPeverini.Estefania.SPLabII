using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class GestorDB
    {
        private static string cadenaConexion;

        static GestorDB()
        {
            cadenaConexion = @"Server=.\SQLEXPRESS;Database=Libreria;Trusted_Connection=True;";
        }

        public static void Delete(Utiles util, int id)
        {
            string query = string.Empty;
            try
            {
                if (util is Lapiz)
                    query = $"DELETE FROM Lapices WHERE Id=@id;";
                else if (util is Goma)
                    query = $"DELETE FROM Gomas WHERE Id=@id;";
                else
                    query = $"DELETE FROM Sacapuntas WHERE WHERE Id=@id;";
                using (SqlConnection conexion = new SqlConnection(GestorDB.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    conexion.Open();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region LECTORES
        public static List<Lapiz> LeerLapiz()
        {
            List<Lapiz> datos = new List<Lapiz>();
            try
            {
                string query = "SELECT * FROM Lapices";
                using (SqlConnection conexion = new SqlConnection(GestorDB.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    conexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string marca = reader.GetString(1);
                        float precio = (float)reader.GetDouble(2);
                        string color = reader.GetString(3);
                        string tamano = reader.GetString(4);
                        Lapiz lapiz = new Lapiz(marca, precio, color, tamano, id);
                        datos.Add(lapiz);
                    }
                }
            }
            catch
            {

            }
            return datos;
        }
        public static List<Sacapuntas> LeerSacapuntas()
        {
            List<Sacapuntas> datos = new List<Sacapuntas>();
            try
            {
                string query = "SELECT * FROM Sacapuntas";
                using (SqlConnection conexion = new SqlConnection(GestorDB.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    conexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string marca = reader.GetString(1);
                        float precio = (float)reader.GetDouble(2);
                        string forma = reader.GetString(3);
                        bool conDeposito = reader.GetBoolean(4);
                        string material = reader.GetString(5);
                        Sacapuntas sacapuntas = new Sacapuntas(marca, precio, forma, conDeposito, material, id);
                        datos.Add(sacapuntas);
                    }
                }
            }
            catch
            {
            }
            return datos;
        }
        public static List<Goma> LeerGomas()
        {
            List<Goma> datos = new List<Goma>();
            try
            {
                string query = "SELECT * FROM Sacapuntas";
                using (SqlConnection conexion = new SqlConnection(GestorDB.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    conexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string marca = reader.GetString(1);
                        float precio = (float)reader.GetDouble(2);
                        string forma = reader.GetString(3);
                        Goma gomas = new Goma(marca, precio, forma, id);
                        datos.Add(gomas);
                    }
                }
            }
            catch
            {
            }
            return datos;
        }
        #endregion

    }
}
