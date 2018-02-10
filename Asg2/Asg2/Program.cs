using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asg2
{
    class Program
    {
        public static void Main(string[] args)
        {
            var Tcount = 0;
            var products = new List<string> {
                "Tomato",
                "Potato",
                "ToMato",
                "Potato",
                "Red Tomato",
                "Tomato Catchup",
                "Grapes",
                "grapes",
                "potato"
            };

            foreach (string prod in products)
            {
                if (string.Equals(prod, "tomato", StringComparison.CurrentCultureIgnoreCase))
                {
                    Tcount = Tcount + 1;
                }
            }
            Console.WriteLine("The number of products having string ‘tomato’ is:" + Tcount);
            Console.WriteLine();

            int indexOfPotato = 0;
            foreach (string item in products)
            {
                if (string.Equals(item, "Potato", StringComparison.CurrentCulture))
                {
                    Console.WriteLine("The index of the list where exact 'Potato' word is there is: " + indexOfPotato);
                }
                indexOfPotato = indexOfPotato + 1;
            }

            Console.WriteLine();

            float X = 0.06f;
            float Y = 5.94f;
            float sum = X + Y;
            Console.WriteLine("The sum of X & Y is " + sum);
            Console.WriteLine();
            if (sum == 6)
            {
                Console.WriteLine("The sum of the floats is equal to '6'");
            }
            else
            {
                Console.WriteLine("The sum is not equal to 6");
            }
            Console.WriteLine();

            if (X > Y)
                Console.WriteLine("X has greater value than Y");
            else
                Console.WriteLine("Y has greater value than X");

            Console.Read();

        }
    }
}
