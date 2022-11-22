using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sacapuntas : Utiles
    {
        private string forma;
        private bool conDeposito;
        private string material;
        public Sacapuntas(int unidades, string marca, float precio, string forma, bool conDeposito, string material)
            :base(unidades, marca, precio)
        {
            this.forma= forma;
            this.conDeposito= conDeposito;
            this.material= material;
        }
    }
}
