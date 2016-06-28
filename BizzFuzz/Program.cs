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

            string[] display = new string[input];

            
            for (int i = 1; i < input + 1; i++)
            {

               
                if (i % 3 == 0)
                {
                    display[i - 1] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    display[i - 1] = "Buzz";
                }
                else
                {

                    display[i - 1] = i.ToString();
                }
            }

                        
          // dl(display);


            int[] L_display = new int[input];
            L_display = Enumerable.Range(1, input).ToArray();

            
            


            Console.ReadKey();



        }
    }
}

