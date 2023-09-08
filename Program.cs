using System;
using System.Text;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            long x = Int64.Parse(split[0]), y = Int64.Parse(split[1]), n = Int64.Parse(split[2]);

            StringBuilder result = new StringBuilder("");

            for (int i = 1; i <= n; i ++) {
                result.Clear() ;
                if ( i % x == 0 ) { result.Append("Fizz"); }
                if (i % y == 0) { result.Append("Buzz"); }
                if (result.Length==0) { result.Append(i); }

                Console.WriteLine(result);
            }
        }
    }
}