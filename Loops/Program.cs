using System;
using static System.Console;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region While
                int x = 1;
                while( x <= 11)
                {
                    WriteLine(x);
                    x++;
                }
            #endregion

            #region doWhile
                // string password = string.Empty;

                // do
                // {
                //     Write("Enter your password : ");
                //     password = ReadLine();
                // }
                // while ( password != "Pa$$w0rd");
                // WriteLine("Correct!");
            #endregion

            #region For
                for (int y = 0; y <= 10; y++)
                {
                    WriteLine(y);
                }

                // Infinite Loop
                // for(;;)
                // {
                //     WriteLine("Unlimited Power!!!!");
                // }
            #endregion

            #region ForEach
            string [] names = { "George", "Saul", "Charles", "Sergy" };
            foreach (string name in names)
            {
                WriteLine ($"{name} has {name.Length} characters.");
            }
            #endregion
        }
    }
}