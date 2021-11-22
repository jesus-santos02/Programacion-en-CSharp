using System;
using System.Collections.Generic;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(){9,1,11,15,8};
            
            var listaInvertida = Invertir(numbers);
            foreach (var item in listaInvertida)
            {
                Console.WriteLine(item);
            }
        }

        static List<int> Invertir(List<int> numbers)
        {
            List<int> temp = new List<int>();
            int position = numbers.Count - 1;
            for (var i = 0; i < numbers.Count; i++)
            {
                temp.Add(numbers[position - i]);
            }

            return temp;
        }
    }
}
