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
        private int id;

        public string Forma { get => this.forma; }
        public string Material { get => this.material; }
        public int Id { get => id; }
        public bool ConDeposito { get => conDeposito; }

        #region CONSTRUCTORES
        public Sacapuntas(string marca, float precio, string forma, bool conDeposito, string material)
            :base(marca, precio)
        {
            this.forma= forma;
            this.conDeposito= conDeposito;
            this.material= material;
        }
        public Sacapuntas(string marca, float precio, string forma, bool conDeposito, string material, int id)
            : this(marca, precio, forma, conDeposito, material)
        {
            this.id = id;
        }
        #endregion
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
