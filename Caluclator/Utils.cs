using System;
using System.Collections.Generic;
using System.Text;

namespace Caluclator
{
    class Utils
    {
        public static void Add(decimal x, decimal y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public static void Subtract(decimal x, decimal y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public static void Divide(decimal x, decimal y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public static void Multiply(decimal x, decimal y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
    }
}
