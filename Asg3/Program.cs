using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asg3
{
    class ListOfProducts
    {
        public String name;
        public double price;
        public double quantity;
        public String type;

        public ListOfProducts(String name, double price, double quantity, String type)
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

            int productcount = products.Count();
            string sp = " ";
            try
            {

                Console.WriteLine("Choose an option:\n 1.Listing by product type  2.Total Inventory price and quantity  3.Average price of products  4.Find costly and cheap products 5.EXIT");
                int optionVal = int.Parse(Console.ReadLine());
                switch (optionVal)
                {
                    case 1:
                        Console.WriteLine("Enter the product type: \n 1.Leafy green  2.Cruciferous  3.Marrow  4.Root");
                        int typeVal = int.Parse(Console.ReadLine());

                        switch (typeVal)
                        {

                            case 1:
                                Console.WriteLine("The product of type leafy green is: ");
                                for (int i = 0; i < productcount; i++)
                                {
                                    if (products[i].type == "Leafy green")
                                    {
                                        Console.WriteLine(sp + sp + products[i].name);
                                    }
                                }
                                break;
                            case 2:
                                Console.WriteLine("The product of type Cruciferous is: ");
                                for (int i = 0; i < productcount; i++)
                                {
                                    if (products[i].type == "Cruciferous")
                                    {
                                        Console.WriteLine(sp + sp + products[i].name);
                                    }
                                }
                                break;

                            case 3:
                                Console.WriteLine("The product of type Marrow is: ");
                                for (int i = 0; i < productcount; i++)
                                {
                                    if (products[i].type == "Marrow")
                                    {
                                        Console.WriteLine(sp + sp + products[i].name);
                                    }
                                }
                                break;

                            case 4:
                                Console.WriteLine("The product of type Root is: ");
                                for (int i = 0; i < productcount; i++)
                                {
                                    if (products[i].type == "Root")
                                    {
                                        Console.WriteLine(sp + sp + products[i].name);
                                    }
                                }
                                break;
                            default:

                                Console.WriteLine("This is an invalid input.");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("The total price of the inventory is: ");
                        double priceSum = 0;
                        double qtySum = 0;
                        for (int i = 0; i < productcount; i++)
                        {
                            priceSum = (products[i].price * products[i].quantity) + priceSum;
                        }
                        Console.WriteLine(priceSum);

                        Console.WriteLine("The total quantity of products in inventory is: ");
                        for (int i = 0; i < productcount; i++)
                        {
                            qtySum = products[i].quantity + qtySum;
                        }
                        Console.WriteLine(qtySum);
                        break;
                    case 3:
                        Console.WriteLine("The average price of the products is: ");
                        double pSum = 0;
                        for (int i = 0; i < productcount; i++)
                        {
                            pSum = products[i].price + pSum;
                        }
                        double avgPrice = pSum / 10;
                        Console.WriteLine(avgPrice);
                        break;
                    case 4:
                        Console.WriteLine("The list of costly products are: ");
                        for (int i = 0; i < productcount; i++)
                        {
                            if (products[i].price >= 50)
                            {
                                Console.WriteLine(products[i].name);
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("The list of cheap products are: ");
                        for (int i = 0; i < productcount; i++)
                        {
                            if (products[i].price < 50)
                            {
                                Console.WriteLine(products[i].name);
                            }
                        }
                        break;
                    case 5:
                        
                        Console.WriteLine("THANK YOU.!!");
                        break;

                    default:
                        Console.WriteLine("This is an invalid input.");
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Warning!! You have entered NULL as input.!! \n\n" + e);
            }
        }       
    }
}
