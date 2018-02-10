using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asg1Part1
{
    class ListOfProducts
    {
        public String name;
        public double price;
        public int quantity;
        public String type;

        public ListOfProducts(String name, double price, int quantity, String type)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.type = type;
        }
    }


    class Program
    {
        public static void Main(string[] args)
        {
            var products = new List<ListOfProducts>{
            new ListOfProducts( "lettuce",10.5,50,"Leafy green"),
            new ListOfProducts("cabbage",20,100,"Cruciferous"),
            new ListOfProducts("pumpkin", 30,30, "Marrow"),
            new ListOfProducts( "cauliflower", 10 , 25, "Cruciferous"),
            new ListOfProducts( "zucchini", 20.5 , 50, "Marrow"),
            new ListOfProducts( "yam", 30 , 50, "Root"),
            new ListOfProducts( "spinach", 10 , 100, "Leafy green"),
            new ListOfProducts( "broccoli", 20.2, 75, "Cruciferous"),
            new ListOfProducts( "Garlic", 30 , 20, "Leafy green"),
            new ListOfProducts( "silverbeet", 10 , 50, "Marrow")
            };

            int productcount = products.Count;
            Console.WriteLine("The number of products in the list: " + productcount);//total no of prod

            Console.WriteLine();
            String sp = " ";
            products.Add(new ListOfProducts("potato", 10, 50, "Root"));//new prod adding

            Console.WriteLine("New list of products:");
            foreach (var prod in products)
                Console.WriteLine(sp + sp + prod.name + sp + prod.price + sp + prod.quantity + sp + prod.type);//new list of all prod

            Console.WriteLine();
            Console.WriteLine("New total number of products=" + products.Count);//total no of prod

            Console.WriteLine();
            Console.WriteLine("The product of type leafy greaan is: ");
            for (int i = 0; i < productcount; i++)
            {
                if (products[i].type == "Leafy green")
                {
                    Console.WriteLine(sp + sp + products[i].name);
                }
            }
            Console.WriteLine();

            products.RemoveAt(8);
            int productcount2 = products.Count;
            Console.WriteLine("Number of products left when all Garlics are sold out:" + productcount2 + "\n");

            Console.WriteLine("Number of cabbages after adding 50 cabbages: ");
            for (int i = 0; i < productcount; i++)
            {
                if (products[i].name == "cabbage")
                {
                    products[i].quantity += 50;
                    Console.WriteLine(products[i].quantity + "\n");
                }
            }

            double totalPrice = 0;
            Console.WriteLine("The total cost of bought items is:");

            foreach (var veggie in products)
            {
                if (veggie.name == "lettuce")
                    totalPrice = totalPrice + veggie.price;
                if (veggie.name == "zucchini")
                    totalPrice = totalPrice + (2 * veggie.price);
                if (veggie.name == "broccoli")
                    totalPrice = totalPrice + (veggie.price);
            }
            Console.WriteLine(Math.Round(totalPrice));
            Console.Read();
        }

    }


}