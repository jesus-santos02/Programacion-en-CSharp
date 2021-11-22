using System;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese grados ºC: ");
            double valor = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine($"{valor} ºC = {ConvertToFahrenheit(valor)} ºF");
        }

        static double ConvertToFahrenheit(double gradosC) => (gradosC * 9/5) + 32;

    }
}
