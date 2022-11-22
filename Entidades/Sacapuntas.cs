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
        public Sacapuntas(string marca, float precio, string forma, bool conDeposito, string material)
            :base(marca, precio)
        {
            this.forma= forma;
            this.conDeposito= conDeposito;
            this.material= material;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Forma: {this.forma}");
            sb.AppendLine($"Deposito: {this.conDeposito}");
            sb.AppendLine($"Material: {this.material}");
            return sb.ToString();
        }
    }
}
