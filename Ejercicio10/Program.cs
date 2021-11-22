using System;
using System.Collections.Generic;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(){9,1,11,15,8};

            Console.WriteLine($"El Valor máximo es: {MaxValue(numbers)}");
        }

        static double MaxValue(List<int> numbers)
        {
            int valorMaximo = 0;
            for (var i = 0; i < numbers.Count; i++)
            {
                if (valorMaximo < numbers[i])
                {
                    valorMaximo = numbers[i];
                }
            }

            return valorMaximo;
        }
    }
}
