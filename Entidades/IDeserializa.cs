using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal interface IDeserializa
    {
        List<Lapiz> LeerXml(string path);
    }
}
