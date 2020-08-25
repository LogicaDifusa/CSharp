using System;
using static System.Console;
namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ImplicitCasting
            int a = 10;
            double b = a; // an int can be safely cast into a double
            WriteLine(b);
            #endregion

            #region Explicit Casting
                double c = 9.8;
                int d = (int)c; // can cast to anything you want with (type)
                WriteLine(d);
            #endregion

            #region 64bit to 32 bit
                long e = 10;
                int f = (int) e;
                WriteLine ($"e is {e:N0} and f is {f:N0}");

                e = long.MaxValue;
                f = (int) e;
                WriteLine($"e is {e:N0} and f is {f:N0}");

                e = 5_000_000_000;
                f = (int) e;
                WriteLine($"e is {e:N0} and f is {f:N0}");
            #endregion

            
        }
    }
}
