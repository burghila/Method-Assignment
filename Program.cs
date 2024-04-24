using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate MathOperation1 class
            MathOperation1 mathOp = new MathOperation1();

            // Ask the user to provide the first parameter
            Console.WriteLine("Enter an integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to provide a second parameter or press enter
            Console.WriteLine("Enter a second integer, or just press enter: ");
            string input = Console.ReadLine();

            try
            {
                // If a second number is provided, parse it and call the method with both numbers
                int num2 = Convert.ToInt32(input);
                int results = mathOp.MathOperation(num1, num2);
                Console.WriteLine($"{num1} x {num2} = {results}");
            }
            catch
            {
                // If a second number is not provided, call the method with the first number only
                int results = mathOp.MathOperation(num1);
                Console.WriteLine($"{num1} x Default 1 = {results}");
            }

            Console.ReadLine();
        }
    }
}
