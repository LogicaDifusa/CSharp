using System;
using static System.Convert;
using static System.Console;

namespace Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ConvertToInt
                double g = 9.8;
                int h = ToInt32(g);
                WriteLine($"g is {g} and h is {h}");
            #endregion

            #region RoundingNumbers
                double[] doubles = new[]
                {
                    9.49, 9.5, 9.51, 10.49, 10.5, 10.51 
                };

                foreach (double n in doubles)
                {
                    WriteLine($"ToInt({n}) is {ToInt32(n)}");
                }
            #endregion

            #region ConvertingToString
                int number = 12;
                WriteLine(number.ToString());

                bool boolean = true;
                WriteLine(boolean.ToString());
                
                DateTime now = DateTime.Now;
                WriteLine(now.ToString());

                object me = new object();
                WriteLine(me.ToString());
            #endregion

            #region binaryToString
                 byte[] binaryObject = new byte[128]; // allocating 128 spaces of memory
                 // Populate with random bytes
                 (new Random()).NextBytes(binaryObject);
                 WriteLine("Binary as Hexadecimal");
                 for (int index = 0; index < binaryObject.Length; index++)
                 {
                     Write($"{binaryObject[index]:X} ");
                 }
                 WriteLine(); // a white space just because

                 // Now converting using convert toBase64
                 string encoded = ToBase64String(binaryObject);
                 WriteLine($"Binary as String is : {encoded}");
            #endregion

            #region ParsingFromStringtoNumbersAndDate
                int age = int.Parse("27");
                DateTime birthday = DateTime.Parse("2 August 1991");
                WriteLine($"I was born {age} years ago.");
                WriteLine($"My birhtday is {birthday}");
                WriteLine($"My birhtday is {birthday:D}");
            #endregion

            #region TryParse and Causing error while parsing
                // Error while parsing
                //int count = int.Parse("abc");

                // TryParse Example
                Write("How old are you? ");
                int count;
                string input = ReadLine();
                if(int.TryParse(input, out count))
                {
                    WriteLine($"You look good at your {count} years");
                }
                else
                {
                    WriteLine("I could not parse the input");
                }
            #endregion
        }
    }
}
