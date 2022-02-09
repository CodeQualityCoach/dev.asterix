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
                double result = GetAdd(op1, op2);
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
                DoDiv(op1, op2);
            }
            else if (operation == "mod")
            {
                double result = op1 % op2;
                Console.WriteLine(result);
            }
            else if (operation == "sum")
            {
                int result = GetSummeFor(Convert.ToInt32(op1), Convert.ToInt32(op2));
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Operation unknown");
            }
        }

        private static int GetSummeWhile(int op1, int op2)
        {
            if (op1 > op2) { return -1; }
            int summe = 0;

            int current = op1;
            while (current <= op2)
            {
                summe = summe + current;
                // current = current + 1;
                current++;
            };

            return summe;
        }

        private static int GetSummeFor(int op1, int op2)
        {
            if (op1 > op2) { return -1; }
            int summe = 0;

            for (int current = op1; current <= op2; current++)
            {
                summe = summe + current;
                current = current + 1;
            }

            return summe;
        }

        private static void DoDiv(double op1, double op2)
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

        public static double GetAdd(double foo, double o2)
        {
            return foo + o2;
        }
    }
}
