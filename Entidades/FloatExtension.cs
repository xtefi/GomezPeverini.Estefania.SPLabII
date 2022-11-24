using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class FloatExtension
    {
        public static float SumarPreciosListaUtiles(List<Utiles> utiles)
        {
            float aux = 0;
            foreach (Utiles item in utiles)
            {
                aux += item.Precio;
            }
            return aux;
        }
    }
}
