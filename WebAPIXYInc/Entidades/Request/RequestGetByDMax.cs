using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIXYInc.Entidades.Request
{
    public class RequestGetByDMax
    {
        public int CoordX { get; set; }
        public int CoordY { get; set; }
        public int DMax { get; set; }
    }
}
