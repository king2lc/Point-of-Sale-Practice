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
            
           
            Console.WriteLine("You bought: " + item);
            Console.WriteLine("For a total of: " + price * quantity);


        }

        public float GetInput(int items, float total)
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Input Item Name.");
                string item = Console.ReadLine();
                Console.WriteLine("Input item price.");
                float price = float.Parse(Console.ReadLine());
                Console.WriteLine("Purchase how many?");
                int quantity = Convert.ToInt32(Console.ReadLine());

                return count + 3;
                return;
            }
            return count;
        }


    }
}
