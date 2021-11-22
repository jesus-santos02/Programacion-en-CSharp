using System;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz(12154, 12235);
        }

        static void FizzBuzz(int valorInicial, int valorFinal)
        {
            string srt;
            for (var i = valorInicial; i <= valorFinal; i++)
            {
                srt = null;
                if (i % 3 == 0)
                    srt += "Fizz";                
                if (i % 5 == 0)
                    srt += "Buzz";

                Console.WriteLine(srt ?? i.ToString());
            }
        }
    }
}
