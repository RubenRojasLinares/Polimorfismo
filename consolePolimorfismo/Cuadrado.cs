using System;
using System.Collections.Generic;
using System.Text;

namespace consolePolimorfismo
{
    public class Cuadrado : Geometria
    {
        public override void CalcularArea()
        {
            Console.Write("\tEscriba el valor de un lado del cuadrado:");
            double lado = Convert.ToDouble(Console.ReadLine());
            base.area = lado * lado;
        }
    }
}