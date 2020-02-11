using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesAbstractas
{
    abstract class FiguraGeometrica
    {
        abstract public int Area();
    }
    class Cuadrado : FiguraGeometrica
    {
        int lado = 0;
        public Cuadrado(int n) {
            this.lado = n;
        }

        public override int Area()
        {
            return lado * lado;
        }
    }
}
