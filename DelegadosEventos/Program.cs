using System;
delegate double Function(double x);

namespace DelegadosEventos
{
    class Multiplier
    {
        double factor;
        public Multiplier(double factor)
        {
            this.factor = factor;
        }
        public double Multiply(double x)
        {
            return x * factor;
        }
    }

    class DelegateExample
    {
        static double Square(double x)
        {
            return x * x;
        }
        static double[] Apply(double[] a, Function f)
        {
            double[] result = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
                result[i] = f(a[i]);
            return result;
        }
        static void Main(string[] args)
        {
            double[] a = { 0.0, 0.5, 1.0 };
            double[] squares = Apply(a, Square); // el delegado manda a llamar metodos con la misma firma y el tipo de retorno en este caso llama a metodo linea 21
            double[] sines = Apply(a, Math.Sin);// manda a llamar la funcion estatica de la clase Math y ejecuta la funcion con el numero proporcionado.porque en la linea 29 dice f(x).
            Multiplier m = new Multiplier(2.0); // instancia de una clase
            double[] doubles = Apply(a, m.Multiply);// manda a llamar el metodo de la clase multiplier linea 13.
        }
    }

}
