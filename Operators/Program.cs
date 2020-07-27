using System;
using static System.Console;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region unary
            int a = 3;
            int b = a++;
            WriteLine($"a is {a}, b is {b}");

            int c = 3;
            int d = ++c;
            WriteLine($"a is {c}, b is {d}");
            #endregion

            #region Arithmetic
                int e = 11;
                int f = 3;
                WriteLine($"e is {e} f is {f}");
                WriteLine($"e + f =  { e + f }");
                WriteLine($"e - f =  { e - f }");
                WriteLine($"e * f =  { e * f }");
                WriteLine($"e / f =  { e / f }");
                WriteLine($"e % f =  { e % f }");
                double g = 11.0;
                WriteLine($"g is {g:N1} f is {f}");
                WriteLine($"g / f =  { g / f }");
            #endregion
            
            #region Assignation
                int p = 6;
                p += 3; // p = p + 3;
                p -= 3; // p = p - 3;
                p *= 3; // p = p * 3;
                p /= 3; // p = p / 3;
            #endregion

            #region Logical
                bool operatorA = true;
                bool operatorB = false;
                WriteLine($"AND | a     |b");
                WriteLine($"a   |{ operatorA & operatorA,-5} |  { operatorA & operatorB,-5}");
                WriteLine($"b   |{ operatorB & operatorA,-5} |  { operatorB & operatorB,-5}");
                WriteLine();

                WriteLine($"OR | a     |b");
                WriteLine($"a   |{ operatorA | operatorA,-5} |  { operatorA | operatorB,-5}");
                WriteLine($"b   |{ operatorB | operatorA,-5} |  { operatorB | operatorB,-5}");
                WriteLine();

                WriteLine($"XOR | a     |b");
                WriteLine($"a   |{ operatorA ^ operatorA,-5} |  { operatorA ^ operatorB,-5}");
                WriteLine($"b   |{ operatorB ^ operatorA,-5} |  { operatorB ^ operatorB,-5}");
                WriteLine();
            #endregion

            #region Conditionals
                WriteLine($"a & doSomething() =  {operatorA && doSomething()}");
                WriteLine($"b & doSomething() =  {operatorB && doSomething()}");
            #endregion

            #region Miscellaneous
                // There are four operators:
                // = is the assignment operator
                // . is the member acces operator
                // () is the incovation operator
                // [] is the incovation operator
            #endregion
        }

        private static bool doSomething()
        {
            WriteLine("Do a barrel roll!");
            return true;
        }
    }
}
