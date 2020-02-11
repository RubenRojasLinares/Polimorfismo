using System;

namespace consolePolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado c = new Cuadrado();
            Rectangulo r = new Rectangulo();
            Rombo rb = new Rombo();
            c.CalcularArea();
            Console.WriteLine("\tArea del cuadrado es:"+ c.area);
            Console.WriteLine();
            r.CalcularArea();
            Console.WriteLine("\tArea del rectangulo es:"+ r.area);
            Console.WriteLine();
            rb.CalcularArea();
            Console.WriteLine("\tArea del rombo es:"+ rb.area);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
