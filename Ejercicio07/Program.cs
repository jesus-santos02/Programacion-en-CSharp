using System;
using System.Collections.Generic;

namespace Ejercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(){4,3,7,5,10};

            Console.WriteLine(ProductOfNumbers(numbers));
        }

        static int ProductOfNumbers(List<int> numbers)
        {
            int product = 1;

            foreach (var number in numbers)
            {
                product *= number;
            }

            return product;
        }
    }
}
