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
        public Datos.Archivador archivador;

        public Action<string> delegadoCartucheraLlena;

        #region PROPIEDADES
        public List<Utiles> Utiles { get => this.utiles; }
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
            archivador = new Datos.Archivador($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\tickets.log");
        }

        public static Cartuchera<T> operator +(Cartuchera<T> c, Utiles u)
        {
            float aux= c.PrecioTotal;
            if (u != null && c != null)
            {
                if (aux >= 500 || (aux + u.Precio) > 500)
                {
                    c.delegadoCartucheraLlena = c.archivador.Guardar;
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
                if(item is Lapiz)
                {
                    sb.AppendLine($"-------Lápiz------");
                }

                else if(item is Sacapuntas)
                {
                    sb.AppendLine($"----Sacapuntas---");
                }
                else
                {
                    sb.AppendLine($"-------Goma------");
                }
                sb.AppendLine($"{item.Mostrar()}");           
            }
            return sb.ToString();
        }


    }
}
