using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIXYInc.Entidades.Request
{
    public class CreatePOI
    {
        public string Nome { get; set; }
        public int CoordX { get; set; }
        public int CoordY { get; set; }
    }
}
