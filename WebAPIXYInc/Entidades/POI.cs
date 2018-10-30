using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIXYInc.Entidades
{
    public class POI
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CoordX { get; set; }
        public int CoordY { get; set; }
    }
}
