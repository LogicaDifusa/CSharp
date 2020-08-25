using System;
using static System.Console;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("How old are you? ");
                string input = ReadLine();
                
                try
                {
                    int age = int.Parse(input);
                    WriteLine($"You look good at your {age} years");
                }
                catch(OverflowException)
                {
                    WriteLine("Your format is valid but the age you enter is either too big or small");
                }
                catch(FormatException)
                {
                    WriteLine("Your age is not a valid format, Try again please");
                }
                catch(Exception ex)
                {
                    WriteLine($"{ex.GetType()} says {ex.Message}");
                }
        }
    }
}
