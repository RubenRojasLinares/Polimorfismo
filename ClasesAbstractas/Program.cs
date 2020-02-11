using System;

namespace ClasesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado cuadrado = new Cuadrado(12);
            Console.WriteLine("Area del cuadrado ={0}",cuadrado.Area());
            Console.Read();
        }
    }
}
