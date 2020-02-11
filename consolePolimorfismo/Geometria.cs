using System;
using System.Collections.Generic;
using System.Text;

namespace consolePolimorfismo
{
    public class Geometria
    {
        public double area;

        public virtual void CalcularArea()
        {
            Console.WriteLine("El area es:" + area);
        }
    }
}