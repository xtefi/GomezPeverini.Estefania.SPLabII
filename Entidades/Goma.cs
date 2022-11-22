using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Goma : Utiles
    {
        private string forma;

        public Goma(int unidades, string marca, float precio, string forma)
            :base(unidades, marca, precio)
        {
            this.forma = forma;
        }
            
    }
}
