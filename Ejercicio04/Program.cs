using System;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese Cateto Opuesto: ");
            double catOpuesto = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese Cateto Adyacente: ");
            double catAdyacente = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"El valor de la Hipotenusa es : {Hipotenusa(catOpuesto, catAdyacente)}");

        }

        static double Hipotenusa(double catOpuesto, double catAdyacente)
        {
            return Math.Sqrt(catOpuesto*catOpuesto + catAdyacente*catAdyacente);
        }
    }
}
