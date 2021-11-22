using System;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introducir cadena 1: ");
            string srt1 = Console.ReadLine();
            Console.Write("Introducir cadena 2: ");
            string srt2 = Console.ReadLine();

            Console.WriteLine(MaxString(srt1, srt2));
        }

        static string MaxString(string a, string b)
        {
            return a.Length > b.Length ? a : b;
        }
    }
}
