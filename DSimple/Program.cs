using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSimple
{
    public delegate void AddDelegate(int a, int b);
    //public delegate string GreetingsDelegate(string s);
    class Program
    {
        static void Main(string[] args)
        {
            //most basic
            AddDelegate addDelegate = new AddDelegate(AddNumbers);
            addDelegate(3, 5);

            //AddDelegate subtract = new AddDelegate(Subtract);
            //subtract(10, 6);

            //GreetingsDelegate greetingsDelegate = new GreetingsDelegate(Greetings);
            //Console.WriteLine(greetingsDelegate("xxx"));
            //Console.WriteLine(greetingsDelegate.Invoke("xxx"));

            //Action
            Action<int, int> subtract = Subtract;
            subtract(8, 2);

            //Func
            //GreetingsDelegate greetingsDelegate = new GreetingsDelegate(Greetings);
            Func<string, string> greetingsdelegate = Greetings;
            Console.WriteLine(greetingsdelegate);
        }
        public static void AddNumbers(int a, int b)
        {
            Console.WriteLine($"the sum of {a} + {b} = {a + b}");
        }
        public static void Subtract(int a, int b)
        {
            Console.WriteLine($"substraction of {a} - {b} = {a - b}");
        }
        public static string Greetings(string s)
        {
            return s;
        }
    }
}
