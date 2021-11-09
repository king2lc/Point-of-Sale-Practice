using System;
using System.Linq;
using System.Collections.Generic;

namespace POS_Console
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How many items?");
            int count = Convert.ToInt16(Console.ReadLine());
            //doing 3 seperate lists for now (not ideal) eventually 3d??
            string[] items = new string[count];
            float[] prices = new float[count];
            int[] quantity = new int[count];

            float runningTotal = 0;
            for (int i = 0; i < count; i++)
            {
                //one by one for each item
                Console.WriteLine("Name of item:");
                items[i] = Console.ReadLine();

                Console.WriteLine("Price of item " + i + ":");
                prices[i] = float.Parse(Console.ReadLine());

                Console.WriteLine("Quantity for this item:");
                quantity[i] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Item tabulated, on to the Next item.");
                runningTotal += prices[i] * quantity[i];

            }
            Console.WriteLine("You purchased " + items.Count() + " items.");
            Console.WriteLine("For a total of: " + runningTotal);

        }

    }



}

