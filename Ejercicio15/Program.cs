using System;
using System.Collections.Generic;

namespace Ejercicio15
{
        class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(){9,1,11,15,8};
            
            var listaOrdenada = OrdenarDescendente(numbers);
            foreach (var item in listaOrdenada)
            {
                Console.WriteLine(item);
            }
        }

        static List<int> OrdenarDescendente(List<int> numbers)
        {
            List<int> list = new List<int>();
            int temp = 0;
            for (var i = 0; i < numbers.Count; i++)
            {
                for (var j = 0; j < numbers.Count; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            return numbers;
        }
    }
}
