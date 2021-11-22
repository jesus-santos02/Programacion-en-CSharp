using System;

namespace Ejercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introducir valor: ");
            int valor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{valor}! = {Factorial(valor)}");
        }

        static int Factorial(int valor)
        {
            int product = 1;
            for (var i = 1; i <= valor; i++)
            {
                product *= i;
            }

            return product;
        }
    }
}
