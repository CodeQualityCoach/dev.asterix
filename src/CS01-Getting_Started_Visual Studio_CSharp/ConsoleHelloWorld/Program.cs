using System;

namespace ConsoleHelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 3)
                return;


            // Annahme: 3 Parameter Operation, Ersten Operanden, Zweiten Operanden
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
                Console.WriteLine("why am I here?");
            }
        }
    }
}
