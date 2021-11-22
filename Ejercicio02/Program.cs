using System;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introducir un número: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(EsPar(valor));
        }

        static bool EsPar(int valor) => valor % 2 == 0;
    }
}
