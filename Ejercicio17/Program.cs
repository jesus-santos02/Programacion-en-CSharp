using System;
using System.Collections.Generic;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>(){"jesus", "jorge", "samir", "carlos"};

            var lastCharacterList = LastCharacterList(stringList);

            foreach (var item in stringList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------");

            foreach (var item in lastCharacterList)
            {
                Console.WriteLine(item);
            }
        }

        static List<string> LastCharacterList(List<string> strings)
        {
            List<string> temp = new List<string>();
            
            for (var i = 0; i < strings.Count; i++)
            {
                temp.Add(strings[i].Substring(strings[i].Length - 1).ToUpper());
            }

            return temp;
        }
    }
}
