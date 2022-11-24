using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class StringExtension
    {
        public static int ContarLetras(this string texto)
        {
            if(string.IsNullOrEmpty(texto))
            {
                return 0;
            }

            int contador = 0;

            foreach(char caracter in texto)
            {
                contador++;
            }
            return contador;
        }
    }
}
