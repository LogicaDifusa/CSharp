using System;
using static System.Console;

namespace WritingFunctions
{
    class Program
    {
        #region Function Tables   
        static void Tables(byte number)
        {
            WriteLine($"This is the {number} table.");
            for (int row = 1; row <= 10; row++)
            {
                WriteLine($"{row} x {number} = {row * number}");
                WriteLine();
            }
        }
        // Used for calling another function
        static void RunTables ()
        {
            bool isNumber;
            do
            {
                Write("Enter a number between 0 and 255: ");

                isNumber = byte.TryParse(ReadLine(), out byte number);

                if (isNumber)
                {
                    Tables(number);
                }
                else
                {
                    WriteLine("You did not enter a valid number");
                }
            } while (isNumber);
        }
        #endregion

        #region Function with Parameters
        // activate the summary typing  / / / without space
            /// <summary>
            /// Pass the amount to calculate taxes and the two letter country code
            /// </summary>
            /// <param name="amount"> Amount to calculate the taxes</param>
            /// <param name="twoLetterCountry"> Two letter country code for my switch case</param>
            /// <returns>Returns the calculated taxes to pay.</returns>
            static decimal CalculateTax(decimal amount, string twoLetterCountry)
            {
                decimal rate = 0.0M;
                switch (twoLetterCountry)
                {
                    case "CH": // Chihuahua
                    rate = 0.09M;
                    break;

                    case "JL": // Jalisco
                    case "CL": // Colima
                    rate = 0.25M;
                    break;

                    case "OX": // Oaxaca
                    case "TB": // Tabasco
                    case "TM": // Tamapulipas
                    rate = 0.27M;
                    break;

                    case "SO": // Sonora
                    case "MTY": // Monterrey
                    rate = 0.0825M;
                    break;
                    default: // All of the other countries
                    rate = 0.06M;
                    break;
                }
                return amount * rate;
            }

            static void RunCalculateTax()
            {
                Write("Enter amount to calculate : ");
                string amountText = ReadLine();
                Write("Enter a two-letter region code: ");
                string countryCode = ReadLine();

                if(decimal.TryParse(amountText, out decimal amount))
                {
                    decimal taxToPay = CalculateTax(amount, countryCode);
                    WriteLine($"You must pay {taxToPay} in sales Tax");
                }
                else {
                    WriteLine("Amount not valid.");
                }
            }
        #endregion
        
        #region Recursion
            static int Factorial(int number)
            {
                if (number < 1)
                {
                    return 0;
                }
                else if (number == 1)
                {
                    return 1;
                }
                else
                {
                    return number * Factorial(number - 1);
                }
            }

            static void RunFactorial()
            {
                bool isNumber;
                do
                {
                Write("Enter a number : ");
                isNumber = int.TryParse(ReadLine(), out int number);
                if(isNumber)
                {
                    WriteLine($"{number:N0} != {Factorial(number):N0}");
                }
                else
                {
                    WriteLine("Not a valid number");
                }   
                } while (isNumber);
            }
        #endregion
        static void Main(string[] args)
        {
            //RunTables();
            //RunCalculateTax();
            //RunFactorial();
            // XML Comments are SO BEAUTIFUL!
        }
    }
}
