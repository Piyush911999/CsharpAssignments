using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asg1Part2
{

    class Program
    {
        public static void Main(string[] args)
        {
            Program obj = new Program();
            obj.EngDict();
        }


        public void EngDict()
        {
            string[] englishDict = { "Boat", "house", "cat", "river", "cupboard" };
            Console.WriteLine("The plurals of the words in Dictionary are: ");
            for (int i = 0; i < englishDict.Length; i++)
            {
                englishDict[i] = englishDict[i] + "s";
                Console.WriteLine(englishDict[i]);
            }

            Console.WriteLine();
            englishDict[1] = "residence";
            Console.WriteLine("After replacing 'house' with it's synonym the words in Dictionary are: ");
            for (int i = 0; i < englishDict.Length; i++)
            {
                Console.WriteLine(englishDict[i]);
            }
            Console.WriteLine();

            var listEngDict = new List<string> { };

            for (int i = 0; i < englishDict.Length; i++)
            {
                listEngDict.Add(englishDict[i]);
            }

            listEngDict.Add("Printer");

            var listLength = listEngDict.Count;
            Console.WriteLine("After adding 'Printer' the new length of the List is: " + listLength);
            Console.WriteLine();
            Console.WriteLine("The list of words with 7 characters is : ");
            for (int i = 0; i < listLength; i++)
            {
                if (listEngDict[i].Length == 7)
                {
                    Console.WriteLine(listEngDict[i]);
                }
            }
            Console.WriteLine();

            Console.WriteLine("The word on 3rd position is: " + listEngDict[2]);
            Console.WriteLine();

            string[] dictAscending = listEngDict.ToArray();
            Array.Sort(dictAscending);
            Console.WriteLine("The array in ascending order is : ");
            for (int i = 0; i < dictAscending.Length; i++)
            {
                Console.WriteLine(dictAscending[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Reversing the array we get : ");
            Array.Reverse(dictAscending);
            for (int i = 0; i < dictAscending.Length; i++)
            {
                Console.WriteLine(dictAscending[i]);
            }
            Console.Read();
        }
    }
}

