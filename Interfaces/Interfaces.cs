using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IDibujable
    {
        void Dibujar(); // llamada funcion porque esta fuera de una clase
    }
    interface IEsDibujable : IDibujable
    {
        bool PuedeDibujarse { get; } // llamada funcion porque esta fuera de una clase
    }

    public class Figura
    {
        public float alto, ancho;
        public Figura(float alto, float ancho)
        {
            this.alto = alto;
            this.ancho = ancho;
        }

        public float Alto { get { return alto; } set { alto = value; } } // Propiedad
        public float Ancho { get { return ancho; } set { ancho = value; } }// Propiedad

        public void Mostrar()
        { // Metodo porque se encuentra dentro de una clase
            Console.WriteLine("{0}:{1}x{2}", GetType(), Alto, Ancho);
        }
    }

    class Cuadrado : Rectangulo
    {
        public Cuadrado(float lado) : base(lado, lado) { }
        public float Lado { get { return alto; } set { alto = ancho = value; } }
    }

    public class Rectangulo : Figura, IDibujable
    {
        public void Dibujar()
        {
            if (this.Alto > 0)
            {
                string s = "";
                for (int x = 0; x < this.Ancho; ++x)
                {
                    s += "[]";
                }

                Console.WriteLine(s);
                if (this.Alto > 2)
                {
                    for (int y = 0; y < this.Alto - 2; ++y)
                    {
                        s = "[]";
                        for (int x = 0; x < this.Ancho - 2; ++x)
                            s += "  ";

                        if (this.Ancho > 1)
                            s += "[]";
                        Console.WriteLine(s);
                    }
                }

                if (this.Alto > 1)
                {
                    s = "";
                    for (int x = 0; x < this.Ancho; ++x)
                    {
                        s += "[]";

                    }
                    Console.WriteLine(s);
                }
            }
            Console.ReadLine();
        }
        public Rectangulo(float alto, float ancho) : base(alto, ancho) { }
    }
}
