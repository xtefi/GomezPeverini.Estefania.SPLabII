using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Cartuchera<T> where T: Utiles
    {
        private List<Utiles> utiles;

        public Cartuchera()
        {
            utiles = new List<Utiles>(); 
        }

        public static bool operator +(Cartuchera<T> c, Utiles u)
        {
            float aux=0;
            try
            {
                if (u != null)
                {
                    foreach (Utiles item in c.utiles)
                    {
                        aux += item.Precio;
                    }
                    if(aux >= 500 || u.Precio + aux > 500)
                    {
                        throw new CartucheraLlenaException("La cartuchera esta llena");
                    }
                    else
                    {
                        c.utiles.Add(u);
                        return true;
                    }                    
                }
            }
            catch(CartucheraLlenaException) 
            {
            }
            catch(Exception ex)
            { 
            }
            return false;
        }
    }
}
