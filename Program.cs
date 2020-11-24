using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
           for (var i = 1; i < 11; i++)
           {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Tabuada do {i}");
               for (var j = 1; j < 11; j++)
               {
                   Console.ForegroundColor = ConsoleColor.Green;
                   Console.WriteLine($"{i} x {j} = {i*j}");
               }
           }
            Console.ResetColor();
        }
    }
}
