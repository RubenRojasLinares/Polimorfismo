using System;
using System.Collections.Generic;
using System.Text;

namespace consolePolimorfismo
{
    public class Rombo : Geometria
    {
        public override void CalcularArea()
        {
            Console.Write("\tEscriba el valor  la diagonal mayor del rombo:");
            double diagonalMayor = Convert.ToDouble(Console.ReadLine());
            Console.Write("\tEscriba el valor de la diagonal menor del rombo");
            double diagonalMenor = Convert.ToDouble(Console.ReadLine());
            base.area = diagonalMayor * diagonalMenor / 2;
        }
    }
}