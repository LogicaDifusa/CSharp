using System;
using static System.Console;

namespace DebuggingPt1
{
    class Program
    {
        static double Add(double a, double b)
        {
            return a * b; // deliberated bug... :v
        }
        static void Main(string[] args)
        {
            double a = 4.5;
            double b = 2.5;
            double answer = Add(a,b);
            WriteLine($"{a} + {b} = {answer}");
            ReadLine();
        }
    }
}
