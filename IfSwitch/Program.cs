﻿using System;
using static System.Console;
using System.IO;

namespace IfSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example1If
            int numberOne = 3;
            int numberTwo = 7;

            if(numberOne > numberTwo)
            {
                WriteLine("First Number is greater than second");
            }
            else
            {
                WriteLine("Second number is greater than the first one");
            }
            #endregion

            #region Example2If
                int a = 1;
                int b = 3;
                int c = 8;

                if( a > b && a > c)
                {
                    WriteLine ($"{a} is the greater of the 3 numbers");
                }
                else if(b > a && b > c){
                    WriteLine ($"{b} is the greater of the 3 numbers");
                }
                else
                {
                    WriteLine ($"{c} is the greater of the 3 numbers");
                }
            #endregion

            #region PatternMatchingIf
                object o = 3;
                int j = 4;
                if ( o is int i)
                {
                    WriteLine($"{i} x {j} = {i * j}");
                }
                else
                {
                    WriteLine("o is not an int so it cannot multiply!");
                }
            #endregion

            #region SwitchCase
                A_label:
                var number = (new Random()).Next(1,7);
                WriteLine($"My random numer is {number}");

                switch (number)
                {
                    case 1:
                    WriteLine("One");
                    break;

                    case 2:
                    WriteLine("Two");
                    goto case 1;

                    case 3:
                    case 4:
                    WriteLine("Three or four");
                    goto case 1;
                    
                    case 5:
                    goto A_label;

                    default:
                    WriteLine("Default");
                    break;
                }
            #endregion

            #region PatternMatchingSwitch
                string path = @"C:\Users\AORUS_DM\Desktop";

                Stream s = File.Open(Path.Combine(path, "test.txt"), FileMode.OpenOrCreate);

                string message = string.Empty;

                switch (s)
                {
                    case FileStream writeableFile when s.CanWrite:
                    message = "The stream is a file that i can write to";
                    break;

                    case FileStream readOnlyFile:
                    message = "The stream is a read-only file.";
                    break;

                    case MemoryStream ms:
                    message = "The stream is a memory address.";
                    break;

                    default:
                    message = "The stream is some other type.";
                    break;

                    case null:
                    message = "the stream is null.";
                    break;
                }

                WriteLine(message);

            #endregion

            #region SwitchSimplified
                message = s switch
                {
                    FileStream writeableFile when s.CanWrite
                    => "The stream is a file that i can write to",
                    FileStream readOnlyFile
                    => "The stream is a read-only file.",
                    MemoryStream ms
                    => "The stream is a memory address.",
                    null => "The stream is null.",
                    _ => "The stream is some other type."
                };
            #endregion
        }
    }
}
