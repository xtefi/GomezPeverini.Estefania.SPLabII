using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ISerializa
    {
        public void GuardarXml<T>(T objeto) where T : Lapiz;
        public void GuardarJson<T>(T objeto) where T : Lapiz;
    }
}
