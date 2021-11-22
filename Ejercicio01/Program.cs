using System;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introducir primer valor: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introducir segundo valor: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            if (valor1 > valor2)
                Console.WriteLine($"El mayor valor es: {valor1}");
            else
                Console.WriteLine($"El mayor valor es: {valor2}");
        }
    }
}
