using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SinTintaExcepcion : Exception
    {
        public SinTintaExcepcion(string message) : base(message)
        {

        }    
    }
}
