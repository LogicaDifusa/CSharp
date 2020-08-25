using System;
using static System.Console;

namespace Checked
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
            checked
            {
            int x = int.MaxValue - 1;
            WriteLine($"Initial value : {x}");
            x++;
            WriteLine($"After Incrementing : {x}");
            x++;
            WriteLine($"After Incrementing : {x}");
            x++;
            WriteLine($"After Incrementing : {x}");
            }    
            }
            catch (OverflowException)
            {
                WriteLine("Don't worry mah friend i got your back with the exception");
            }
            
        }
    }
}
