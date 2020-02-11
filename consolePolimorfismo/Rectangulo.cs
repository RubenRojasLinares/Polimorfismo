using System;
using System.Collections.Generic;
using System.Text;

namespace consolePolimorfismo
{
    public class Rectangulo : Geometria
    {
        public override void CalcularArea()
        {
            Console.Write("\tEscriba el valor de la base del rectángulo:");
            double Base = Convert.ToDouble(Console.ReadLine());
            Console.Write("\tEscribael valor de la altura del Rectángulo:");
            double Altura = Convert.ToDouble(Console.ReadLine());
            base.area = Base * Altura;
        }
    }
}