using System;
using SharpPad;
using System.Threading.Tasks;
using static System.Console;


namespace DebuggingPt2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var complexObject = new {
                FirstName = "Angel",
                BirthDate = new DateTime(year : 1991, month :8, day : 25),
                Friends = new [] {"Geroge", "Saul", "Carlos", "Sergy"}
            };

            WriteLine($"Dumping {nameof(complexObject)} to SharpPad");
            await complexObject.Dump();
        }
    }
}
