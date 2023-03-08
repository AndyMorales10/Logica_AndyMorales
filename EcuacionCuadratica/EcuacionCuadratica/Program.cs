using System;

namespace EcuacionCuadratica
{
    public class EcuacionCuadratica
    {
        static void Main(string[] args)
        {
            double result1, result2, a, b, c;

            Console.Write("Por favor ingrese un valor para a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Por favor ingrese un valor para b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Por favor ingrese un valor para c: ");
            c = Convert.ToDouble(Console.ReadLine());

            result1 = (((-1) * b) + Math.Sqrt(((Math.Pow(b, 2)) - (4 * a * c)))) / (2 * a);

            result2 = (((-1) * b) - Math.Sqrt(((Math.Pow(b, 2)) - (4 * a * c)))) / (2 * a);


            Console.WriteLine("El resultado + de la ecuación cuadrática es:  " + result1);
            Console.WriteLine("El resultado - de la ecuación cuadrática es:  " + result2);
        }
    }
}
