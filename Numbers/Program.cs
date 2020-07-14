using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // all positive numbers including 0
            uint naturalNumber = 12;
            // int ... integer , positive and negative numbers
            int integerNumber = -12;

            // Float is a single precision point
            float realNumber = 2.3F;

            //Double stands for double precision point
            double doubleRealNumber = 2.3;

            // Decimal gets the precision of how many decimals you have
            decimal decimalNumber = 2.8M;

            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;

            //Check if the conversions are true
            Console.WriteLine($"Is decimal equals to binary? : {decimalNotation == binaryNotation}");
            Console.WriteLine($"Is decimal equals to hexadecimal? : {decimalNotation == hexadecimalNotation}");


            // SizeOf
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

            // Comparing double vs decimal
            Console.WriteLine("Using Doubles");
            double a = 0.1;
            double b = 0.2;

            if(a + b == 0.3)
            {
                Console.WriteLine($"{a} + {b} = {a + b} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{a} + {b} = {a + b} does NOT equals 0.3");
            }

            // Using decimals
            Console.WriteLine("Using decimals: ");
            decimal c = 0.1M;
            decimal d = 0.2M;
            if(c + d == 0.3M)
            {
                Console.WriteLine($"{c} + {d} = {c + d} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{c} + {d} = {c + d} does NOT equals 0.3");
            }

            // Booleans
            bool happy = true;
            bool sad = false;

            if(sad == true)
            {
                Console.WriteLine("Don't worry ... be happy ");
            }
            else if(happy)
            {
                Console.WriteLine("Stay that way :3");
            }

        }
    }

}
