using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu(); // Menu //
            Sum(); // Sum Calcultaor //
            subtraction(); // Subtraction Calculator //
            Multiplication(); // Multiplication Calculator //
            Division(); // Division Calcultator //

        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("WELCOME TO SMART CALCULATOR!");
            Console.WriteLine("Please select de the type of count you need:");
            Console.WriteLine("Option 1 - Sum");
            Console.WriteLine("Option 2 - Subtraction");
            Console.WriteLine("Option 3 - Multiplication");
            Console.WriteLine("Option 4 - Division");
            Console.WriteLine("Option 5 - Exit");


            Console.WriteLine(""); //Skip Line//


            Console.WriteLine("{----------------}");
            Console.WriteLine(""); //Skip Line//
            Console.WriteLine("Write the NUMBER that match to the option you need and press ENTER:");


            short res = short.Parse(Console.ReadLine());


            switch (res)
            {
                case 1: Sum(); break;
                case 2: subtraction(); break;
                case 3: Multiplication(); break;
                case 4: Division(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }


            Console.ReadKey();
        }

        static void Sum()
        {
            Console.Clear();

            // Sum Calculator Start //

            Console.WriteLine("Write the first value you want to SUM:");
            float Value1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Write the second value you want to SUM:");
            float Value2 = float.Parse(Console.ReadLine());


            Console.WriteLine(""); //Skip Line//


            float result = Value1 + Value2;
            Console.WriteLine(("The result of the sum is " + result));


            Console.ReadKey(); // Keep the console on //\
            Menu();
        }

        static void subtraction()
        {
            Console.Clear();

            // Subtraction calculator Start //

            Console.WriteLine("Write the first Value you want to SUBTRACT:");
            float Value1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Write the second Value you want to SUBTRACT:");
            float Value2 = float.Parse(Console.ReadLine());


            Console.WriteLine(""); //Skip Line//


            float result = Value1 - Value2;
            Console.WriteLine($"The result of the subtraction is {result}");


            Console.ReadKey(); // Keep the console on //
            Menu();

            // Subtraction calculator End //
        }

        static void Multiplication()
        {
            Console.Clear();

            // Multiplication Calculator Start //

            Console.WriteLine("Write the first value you want to MULTIPLY:");
            float Value1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Write the first value you want to MULTIPLY:");
            float Value2 = float.Parse(Console.ReadLine());


            float result = Value1 * Value2;
            Console.WriteLine($"The result of the multiplication is " + (Value1 *
                Value2));


            Console.ReadKey(); // Keep the console on //
            Menu();

            // Multiplication Calculator End //
        }

        static void Division()
        {
            Console.Clear();

            // Division Calculator Start //

            Console.WriteLine("Write the first value you want to DIVIDE:");
            float Value1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Write the second value you want to DIVIDE:");
            float Value2 = float.Parse(Console.ReadLine());


            float result = Value1 / Value2;
            Console.WriteLine($"The result of the division is {Value1 / Value2}");


            Console.ReadKey(); // Keep the console on //
            Menu();

            // Division Calculator End //
        }


    }
}
