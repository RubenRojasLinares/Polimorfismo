using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesAbstractas
{
    abstract class ClaseAbstractaEjemplo
    {
        abstract public int Area();
    }
    class Cuadrado : ClaseAbstractaEjemplo {
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
