using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncActionPredicateD
{
    //public delegate double D1(int x, float y, double z);
    //public delegate void D2(int x, float y, double z);
    //public delegate bool D3(string str);
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, float, double, double> d1 = AddNums1;
            Action<int,float,double> d2 = AddNums2;
            Predicate<string> d3 = CheckLength;
            double res1 = d1(3, 5.5F, 5.05);
            d2(3, 5.5F, 5.05);
            bool res2 = d3("dirk");
            Console.WriteLine(
                res1 + Environment.NewLine +
                res2);
        }
        public static double AddNums1(int x, float y, double z)
        {
            return x + y + z;
        }
        public static void AddNums2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }
        public static bool CheckLength(string str)
        {
            return str.Length > 5;
        }
    }
}
