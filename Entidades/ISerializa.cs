﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal interface ISerializa
    {
        void GuardarXml(object dato, string path);
    }
}
