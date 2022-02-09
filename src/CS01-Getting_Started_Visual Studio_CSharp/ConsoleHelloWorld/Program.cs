using System;

namespace ConsoleHelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Annahme: 3 Parameter Operation, Ersten Operanden, Zweiten Operanden
            string operation = args[0];
            double op1 = Convert.ToDouble(args[1]);
            double op2 = Convert.ToDouble(args[2]);

            if (operation == "add")
            {
                double summe = op1 + op2;
                Console.WriteLine(summe);
            }
        }
    }
}
