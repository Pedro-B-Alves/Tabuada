using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
           for (var i = 1; i < 11; i++)
           {
               Console.ForegroundColor = ConsoleColor.Blue;
               int contador = i;
               Console.WriteLine("--------------");
               
               for (var j = 1; j < 2; j++)
               {
                   Console.ForegroundColor = ConsoleColor.Yellow;
                   Console.WriteLine($"Tabuada do {contador}");
                   Console.ForegroundColor = ConsoleColor.Green;
                   Console.WriteLine($"{contador} x {1} = {contador*1}");
                   Console.WriteLine($"{contador} x {2} = {contador*2}");
                   Console.WriteLine($"{contador} x {3} = {contador*3}");
                   Console.WriteLine($"{contador} x {4} = {contador*4}");
                   Console.WriteLine($"{contador} x {5} = {contador*5}");
                   Console.WriteLine($"{contador} x {6} = {contador*6}");
                   Console.WriteLine($"{contador} x {7} = {contador*7}");
                   Console.WriteLine($"{contador} x {8} = {contador*8}");
                   Console.WriteLine($"{contador} x {9} = {contador*9}");
                   Console.WriteLine($"{contador} x {10} = {contador*10}");
               }
           }
            Console.ResetColor();
        }
    }
}
