using System;
using System.Collections.Generic;

namespace Ejercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(){1,2,3,4,5};

            Console.WriteLine($"El Promedio es: {Average(numbers)}");
        }

        static double Average(List<int> numbers)
        {
            double average = 0.0;
            for (var i = 0; i < numbers.Count; i++)
            {
                average += (double)numbers[i]/numbers.Count;
            }

            return average;
        }
    }
}
