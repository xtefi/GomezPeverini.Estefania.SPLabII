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
        #region ELIMINAR
        public static void Delete(Utiles selected, int id)
        {
            string query = string.Empty;
            if (selected is Lapiz)
                query = $"DELETE FROM Lapices WHERE id = @id;";
            else if (selected is Goma)
                query = $"DELETE FROM Gomas WHERE id = @id;";
            else
                query = $"DELETE FROM Sacapuntas WHERE id = @id;";
            try
            {
                using (SqlConnection conexion = new SqlConnection(GestorDB.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.CommandText = query;
                    conexion.Open();
                    cmd.ExecuteNonQuery();

                }

            }
            catch
            {
            }
        }
        #endregion

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
                string query = "SELECT * FROM Gomas";
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

        #region ALTAS

        public static void AltaLapiz(Lapiz lapiz)
        {
            string query = "insert into Lapices (marca, precio, color, tamano) values (@marca, @precio, @color, @tamano)";
            SqlConnection conexion = null;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("marca", lapiz.Marca);
                cmd.Parameters.AddWithValue("precio", lapiz.Precio);
                cmd.Parameters.AddWithValue("color", lapiz.Color);
                cmd.Parameters.AddWithValue("tamano", lapiz.Tamano);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
        public static void AltaGoma(Goma goma)
        {
            string query = "insert into Gomas (marca, precio, forma) values (@marca, @precio, @forma)";
            SqlConnection conexion = null;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("marca", goma.Marca);
                cmd.Parameters.AddWithValue("precio", goma.Precio);
                cmd.Parameters.AddWithValue("forma", goma.Forma);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
        public static void AltaSacapuntas(Sacapuntas sacapuntas)
        {
            string query = "insert into Sacapuntas (marca, precio, forma, conDeposito, material) values (@marca, @precio, @forma, @conDeposito, @material)";
            SqlConnection conexion = null;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("marca", sacapuntas.Marca);
                cmd.Parameters.AddWithValue("precio", sacapuntas.Precio);
                cmd.Parameters.AddWithValue("forma", sacapuntas.Forma);
                cmd.Parameters.AddWithValue("conDeposito", sacapuntas.ConDeposito);
                cmd.Parameters.AddWithValue("material", sacapuntas.Material);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        #endregion

        #region MODIFICACIONES

        public static void ActualizarLapiz(Lapiz lapiz, int id)
        {
            string query = "update Lapices set marca=@marca, precio=@precio, color=@color, tamano=@tamano where id = @id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("marca", lapiz.Marca);
                    cmd.Parameters.AddWithValue("precio", lapiz.Precio);
                    cmd.Parameters.AddWithValue("color", lapiz.Color);
                    cmd.Parameters.AddWithValue("tamano", lapiz.Tamano);
                    conexion.Open();
                    cmd.ExecuteNonQuery();

                }
            }
            catch
            {
                throw;
            }
        }

        public static void ActualizarSacapuntas(Sacapuntas sacapuntas, int id)
        {
            string query = "update Sacapuntas set marca=@marca, precio=@precio, forma=@forma, conDeposito=@conDeposito, material=@material where id = @id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("marca", sacapuntas.Marca);
                    cmd.Parameters.AddWithValue("precio", sacapuntas.Precio);
                    cmd.Parameters.AddWithValue("forma", sacapuntas.Forma);
                    cmd.Parameters.AddWithValue("conDeposito", sacapuntas.ConDeposito);
                    cmd.Parameters.AddWithValue("material", sacapuntas.Material);
                    conexion.Open();
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void ActualizarGomas(Goma goma, int id)
        {
            string query = "update Gomas set marca=@marca, precio=@precio, forma=@forma where id = @id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("marca", goma.Marca);
                    cmd.Parameters.AddWithValue("precio", goma.Precio);
                    cmd.Parameters.AddWithValue("forma", goma.Forma);
                    conexion.Open();
                    cmd.ExecuteNonQuery();

                }
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }

}

