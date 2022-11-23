using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ISerializa
    {
        void GuardarXml<T>(T objeto) where T : Lapiz;
        void GuardarJson<T>(T objeto) where T : Lapiz;
    }
}
