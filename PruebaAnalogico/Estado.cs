using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaAnalogico
{
    class Estado
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public bool BotonPresionado { get; private set; }

        public Estado(int x, int y, bool botonPresionado)
        {
            this.X = x;
            this.Y = y;
            this.BotonPresionado = botonPresionado;
        }
    }
}
