using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user to enter purchase amount
            Console.WriteLine("Enter Price of an item (From 25 cents to a dolar, in 5-cent increments");
            int purchase = Convert.ToInt32(Console.ReadLine()); // convert it to int32
            Console.WriteLine("You bought an item for " + purchase + " cents and game me a dollar, so your change is:");
            //Subtract 100 (value of a dollar)
            purchase = 100 - purchase;
            //Show how many quarters are given back and reduce purchase by that amount
            Console.WriteLine((purchase / 25) + " Quarters");
            purchase %= 25;
            //Show how many dimes are given back and reduce purchase by that amount
            Console.WriteLine((purchase / 10) + " Dimes and");
            purchase %= 10;
            //Show how many nickels are given back and reduce purchase by that amount
            Console.WriteLine((purchase / 5) + " Nickels.");
            purchase %= 5;
        }
    }
}
