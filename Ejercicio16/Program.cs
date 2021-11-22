using System;
using System.Collections.Generic;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>(){"jesus", "jorge", "samir", "carlos"};

            var firstCharacterList = FirstCharacterList(stringList);

            foreach (var item in stringList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------");

            foreach (var item in firstCharacterList)
            {
                Console.WriteLine(item);
            }
        }

        static List<string> FirstCharacterList(List<string> strings)
        {
            List<string> temp = new List<string>();
            
            for (var i = 0; i < strings.Count; i++)
            {
                temp.Add(strings[i].Substring(0, 1).ToUpper());
            }

            return temp;
        }
    }
}
