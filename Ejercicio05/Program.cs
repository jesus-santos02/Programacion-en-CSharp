using System;

namespace Ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            
            while (count < 100)
            {
                Console.WriteLine($"{count}, {++count}");
            }
        }
    }
}
