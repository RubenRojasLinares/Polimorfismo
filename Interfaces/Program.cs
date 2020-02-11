using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite el ancho deseado del rectangulo;");
            string ancho = Console.ReadLine();

            Console.Write("Digite el largo deseado del rectangulo;");
            string largo = Console.ReadLine();

            Rectangulo rectangulo = new Rectangulo(Convert.ToInt32(ancho), Convert.ToInt32(largo));

            Figura figura = (Figura)rectangulo;
            IDibujable dibujable = (IDibujable)rectangulo;
            Console.Write("Se dibuja el objeto de la clase rectangulo con el ancho y largo deseados \n");
            rectangulo.Mostrar();
            
            rectangulo.Dibujar();
            Console.Write("Se dibuja el objeto de la clase dibujable con el ancho y largo desados \n");

            dibujable.Dibujar();
        }
    }
}
