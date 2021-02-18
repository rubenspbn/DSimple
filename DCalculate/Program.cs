using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCalculate
{
    public delegate void CalculateDelegate(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            CalculateDelegate de1 = new CalculateDelegate(Add);
            CalculateDelegate de2 = new CalculateDelegate(Subtract);
            CalculateDelegate de3 = new CalculateDelegate(Multiply);
            CalculateDelegate de4 = new CalculateDelegate(Divide);

            CalculateDelegate multidel = de1 + de2 + de3 + de4;
            multidel(20, 5);
            Console.WriteLine();
            multidel -= de2;
            multidel(10, 10);
            Console.WriteLine();
            multidel += de2;
            multidel += de2;
            multidel += de2;
            multidel(20, 20);
        }
        public static void Add(int x, int y)
        {
            Console.WriteLine($"The Sum {x} and {y} = {x + y}");
        }
        public static void Subtract(int x, int y)
        {
            Console.WriteLine($"The Subtraction {x} and {y} = {x - y}");
        }
        public static void Multiply(int x, int y)
        {
            Console.WriteLine($"The Multiplication {x} and {y} = {x * y}");
        }
        public static void Divide(int x, int y)
        {
            Console.WriteLine($"The Division {x} and {y} = {x / y}");
        }
    }
}
