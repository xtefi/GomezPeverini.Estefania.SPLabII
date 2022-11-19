using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class CartucheraLlenaException : Exception
    {
        public CartucheraLlenaException(string message) : base(message)
        {

        }
        public CartucheraLlenaException(string message, Exception innerException) : base(message)
        {

        }
    }
}
