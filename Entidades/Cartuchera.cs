using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera<T> where T: Utiles
    {
        private List<Utiles> utiles;
        private string nombre;
        public Cartuchera(string nombre)
        {
            utiles = new List<Utiles>();
            this.nombre = nombre;
        }

        public static Cartuchera<T> operator +(Cartuchera<T> c, Utiles u)
        {
            float aux=0;
            if (u != null)
            {
                foreach (Utiles item in c.utiles)
                {
                    aux += item.Precio;
                }
                if(aux >= 50 || (aux + u.Precio) >= 50)
                {
                    throw new CartucheraLlenaException("La cartuchera esta llena");
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
            foreach(Utiles item in this.utiles)
            {
                sb.AppendLine($"{item.MostrarUtiles()}");
            }
            return sb.ToString();
        }
    }
}
