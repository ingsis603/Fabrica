﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryAutomovil.mundo.interfaces;

namespace AbstractFactoryAutomovil.mundo.clases
{
    class AutoToyota : IAuto
    {
        public string darNombre()
        {
            return "Auto Toyota";
        }
    }
}
