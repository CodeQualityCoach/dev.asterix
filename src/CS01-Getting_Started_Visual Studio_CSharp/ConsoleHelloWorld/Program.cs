using System;

namespace ConsoleHelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Not enough parameter");
                return;
            }

            string operation = args[0];
            double op1 = Convert.ToDouble(args[1]);
            double op2 = Convert.ToDouble(args[2]);

            if (operation == "add")
            {
                double result = op1 + op2;
                Console.WriteLine(result);
            }
            else if (operation == "sub")
            {
                double result = op1 - op2;
                Console.WriteLine(result);
            }
            else if (operation == "mul")
            {
                double result = op1 * op2;
                Console.WriteLine(result);
            }
            else if (operation == "div")
            {
                if (op2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero, dumbass");
                    return;
                }

                // check if op2 != 0.0
                double result = op1 / op2;
                Console.WriteLine(result);
            }
            else if (operation == "mod")
            {
                double result = op1 % op2;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Operation unknown");
            }
        }
    }
}
