using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asg1Part3
{

    public class PrimeMinister
    {
        public string Name { get; private set; }
        public int YearElected { get; private set; }

        public PrimeMinister(string name, int yearElected)
        {
            this.Name = name;
            this.YearElected = yearElected;
        }

        public override string ToString()
        {
            return string.Format("{0}, elected: {1}", Name, YearElected);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            var primeMinisters = new Dictionary<string, PrimeMinister>
            {
                {"1998", new PrimeMinister("Atal Bihari Vajpayee", 1998) },
                {"2014", new PrimeMinister("Narendra Modi", 2014) },
                {"2004", new PrimeMinister("Manmohan Singh", 2004) }

            };
            int pmCount = primeMinisters.Count();

            foreach (var pm in primeMinisters)
            {
                if (pm.Value.YearElected == 2004)
                {
                    Console.WriteLine("The Prime minister in the year 2004 is " + pm.Value.Name);
                }
            }
            Console.WriteLine();
            primeMinisters.Add("2018", new PrimeMinister("Narendra Modi", 2018));
            Console.WriteLine("The prime ministers in dictionary after adding current PM is: ");
            foreach (var pm in primeMinisters)
            {
                Console.WriteLine(pm.Value);
            }


            var keylist = new List<string> { };
            foreach (var pm in primeMinisters)
            {
                keylist.Add(pm.Key);
            }
            Console.WriteLine();

            string[] array1 = keylist.ToArray();
            Array.Sort(array1);

            Console.WriteLine("The sorted dictionary by year is :");
            for (int i = 0; i < array1.Length; i++)
            {
                PrimeMinister pm = primeMinisters[array1[i]];
                Console.WriteLine(pm.ToString());
            }

            Console.Read();
        }
    }
}
