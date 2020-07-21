using System;

namespace VariablesPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Object
            object newObjectVariable;
            object height = 2.1;
            object name = "Angel";

            Console.WriteLine($"{name} is {height} meters tall");
            //int length = name.Lenght; // Error compiler
            int length2 = ((string)name).Length; // Tell the compiler it is a string
            // You need always to explicit cast the type to make convertions
            // And so the compiler knows what type of variable you're using.
            Console.WriteLine($"{name} has {length2} characters");
            #endregion
            
            #region Dynamic
            // Dynamic can also store any type of data
                dynamic dynamicObject = "Angel";
                //int length = dynamicObject.Lenght;
                Console.WriteLine($"{name} has {length2} characters");
                string checkMethods = "Something";
                dynamic noMethods = "NoMethods";
                //checkMethods. // this acces gives you the string methods
                // noMethods. // this doesn't show you the string methods
            #endregion

            #region var
                var population = 66_000_000;
                var weight = 50.1; // Kilograms
                var price = 100.3M; // The M is to tell him that is a single point float
                var fruit = "Apples"; // When compiler sees the "" it infers a string
                var letter = 'A'; // compiler sees '' infers a char
                var happy = true; // Always stay happy :)

                Console.WriteLine($"{population} \n {weight} \n {price} \n {fruit}");
            #endregion

            #region default
                Console.WriteLine($"default(int) = {default(int)}");
                Console.WriteLine($"default(bool) = {default(bool)}");
                Console.WriteLine($"default(DateTime) = {default(DateTime)}");
                Console.WriteLine($"default(string) = {default(string)}");
            #endregion

            #region Arrays
                // Allocate memory for four strings in an array
                string [] names;
                names = new string[4];

                // storing items at index position
                names[0] = "George";
                names[1] = "Saul";
                names[2] = "Carlos";
                names[3] = "Sergy";

                // looping through the names
                for (int i = 0; i < names.Length; i++)
                {
                    // Printthe name at position i 
                    Console.WriteLine(names[i]);
                }
            #endregion

            #region Formatting
                int numberOfApples = 12;
                decimal pricePerApple = 1.2M;
                // :C is for adding the currency of yout country
                Console.WriteLine($"Apples cost {pricePerApple:C} Total is : {(numberOfApples * pricePerApple):C}");

                // Format syntax is {variable:format type}
                string header = "Fruits";
                string apples = "Apples";
                string bananas = "Bananas";
                int applesCount = 123456;
                int bananasCount = 56789;
                Console.WriteLine($"{header,-8}");
                Console.WriteLine($"{apples,-8} {applesCount,6:N0}"); // The , in the variable to play with the alignment
                Console.WriteLine($"{bananas,-8} {bananasCount,6:N0}");
            #endregion

            #region ReadLine
                Console.WriteLine("Type your name and press Enter");
                string Name = Console.ReadLine(); // Reads from user and waits for the enter key
                Console.WriteLine("Type your age and press Enter");
                string age = Console.ReadLine();

                Console.WriteLine($"Hello {name}, you look good for {age}");
            #endregion
        }
    }
}
