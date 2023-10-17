using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add two numbers");
            Console.WriteLine("2. Add list of numbers");
            double choice = Convert.ToDouble(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = num1 + num2;
                Console.WriteLine("Result: " + result);
            }
            else if (choice == 2)
            {
                Console.Write("Enter comma-separated (,) integer values: ");
                string input = Console.ReadLine();

                string[] numbers = input.Split(',');
                double sum = 0;
                foreach (string num in numbers)
                {
                    sum += Convert.ToDouble(num);
                }

                Console.WriteLine("Result: " + sum);
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }
}
