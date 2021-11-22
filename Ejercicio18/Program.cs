using System;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "Ana";
            Console.WriteLine(IsPalindrome(cadena));
        }

        static bool IsPalindrome(string srt)
        {
            string temp = "";
            string cadena = srt.ToLower();
            for (var i = 0; i < cadena.Length; i++)
            {
                temp += cadena[cadena.Length - 1 - i];
            }

            return cadena == temp;
        }
    }
}
