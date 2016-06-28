using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzFuzz
{
    class Program
    {
        private static void dl(string[] x)
        {
            foreach(var item in x)
            {
                Console.WriteLine(item);
            }
        }


        static void Main()
        {
            Console.WriteLine("Number Please");
            string _input = Console.ReadLine();
            int input = int.Parse(_input);
            Console.Clear();
                     
                     
            int[] range = Enumerable.Range(1, input).ToArray();

            string[] test = range.Select(x => (x % 3 == 0) ? "Fizz" : (x % 5 == 0) ? "Buzz" : x.ToString())
            
            .ToArray();

            foreach (var item in test)
            {
                Console.WriteLine(item);
            }
            


            Console.ReadKey();



        }
    }
}

