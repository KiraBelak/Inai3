using System;
using System.Collections.Generic;
using System.Text;

namespace Inai3.Vistas
{
    public class Estado
    {
        public string Name { get; set; }
        public string Ubicacion { get; set; }
        public string Url { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
