using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera<T> where T: Utiles
    {
        private List<Utiles> utiles;
        private int capacidad;
        private string nombre;
        private string ruta;
        public Action<string> delegadoCartucheraLlena;

        #region PROPIEDADES
        public List<Utiles> Utiles { get => this.utiles; }
        public string Ruta { set => this.ruta = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public int Capacidad { get => this.capacidad; set => this.capacidad = value; }
        private float PrecioTotal 
        { 
            get
            {
                float aux=0;
                foreach (Utiles item in this.utiles)
                {
                    aux += item.Precio;
                }
                return aux;
            }
        }
        #endregion

        public Cartuchera(string nombre, int capacidad)
        {
            utiles = new List<Utiles>();
            this.capacidad = capacidad;
            this.nombre = nombre;
        }

        public static Cartuchera<T> operator +(Cartuchera<T> c, Utiles u)
        {
            float aux= c.PrecioTotal;
            if (u != null && c != null)
            {
                if (aux >= 500 || (aux + u.Precio) > 500)
                {
                    c.delegadoCartucheraLlena = c.Guardar;
                    c.delegadoCartucheraLlena.Invoke(c.MostrarCartuchera());
                    throw new CartucheraLlenaException("La cartuchera está llena");                    
                }
                else if(c.capacidad <= c.utiles.Count)
                {
                    throw new CartucheraLlenaException("La cartuchera está llena");
                }
                else
                {
                    c.utiles.Add(u);
                    return c;
                }                    
            }            
            return c;
        }

        public string MostrarCartuchera()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Precio total: {this.PrecioTotal}");
            foreach (Utiles item in this.utiles)
            {
                sb.AppendLine($"");
                sb.AppendLine($"{item.Mostrar()}");           
            }
            return sb.ToString();
        }

        /// <summary>
        /// Escribe datos del tipo string en un archivo de logs. En caso de no existir el archivo, lo crea.
        /// </summary>
        /// <param name="datos">Datos del tipo string que se quiere guardar en el archivo.txt</param>
        public void Guardar(string datos)
        {
            this.ruta = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\{DateTime.Today.DayOfWeek.ToString()}_tickets.log";
            try
            {
                using (StreamWriter writer = new StreamWriter(ruta, true))
                {
                    writer.WriteLine(datos);
                    writer.WriteLine("-----------------------------------------------------------------------------------");

                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
        #region ARCHIVOS
        /// <summary>
        /// Valida que exista un archivo de texto y retorna todo su contenido. 
        /// En caso de no existir el archivo arroja una Excepcion.
        /// </summary>
        /// <param name="datos">Datos del tipo string que fueron obtenidos del archivo.txt</param>
        /// <returns>Retorna true si pudo leer y retornar los datos o false en caso contrario. 
        /// En caso de fallas, arroja una Excepcion</returns>
        public bool Leer(out string datos)
        {
            bool agregoInfo = false;
            datos = string.Empty;
            if (File.Exists(ruta))
            {
                using (StreamReader reader = new StreamReader(ruta))
                {
                    datos = reader.ReadToEnd();
                    agregoInfo = true;
                }
            }
            else
            {
                throw new FileNotFoundException("No se encontró ningun archivo de Excepciones creado para leer");
            }
            return agregoInfo;
        }
        #endregion
    }
}
