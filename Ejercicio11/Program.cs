using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaNacimiento = new DateTime(1988, 03, 02);

            Console.WriteLine($"Mi edad es {CalcularEdad(fechaNacimiento)} años");
        }

        static int CalcularEdad(DateTime fechaNacimiento)
        {
            return DateTime.Now.Subtract(fechaNacimiento).Days/365;
        }
    }
}
