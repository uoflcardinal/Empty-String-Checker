using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Please enter some text: ");
            input = Console.ReadLine();
            Console.WriteLine(check(input));
        }

        public static bool check(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
