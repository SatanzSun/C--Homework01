﻿using System;

namespace Caluclator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadat decimalskaitļus un aritmētisko operātoru.");
            Console.WriteLine("pirmais skaitlis x:");
            decimal x = Convert.ToDecimal(Console.ReadLine().Replace(',', '.'));
            Console.WriteLine("otrais skaitlis y:");
            decimal y = Convert.ToDecimal(Console.ReadLine().Replace(',', '.'));
            Console.WriteLine("aritmētiskais operators: (+, -, /, *");
            string z = Console.ReadLine();

            switch (z.Trim())
            {
                case "+":
                    Utils.Add(x, y);
                    break;

                case "-":
                    Utils.Subtract(x, y);
                    break;

                case "/":
                    Utils.Divide(x, y);
                    break;

                case "*":
                    Utils.Multiply(x, y);
                    break;

                default:
                    Console.WriteLine("neatbilstošs operātors");
                    break;

            }

        }
    }
}
