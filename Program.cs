using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(String.Join(",", array));
            string[] names = new string[] { "Tim", "Martin", "Nikki", "Sara" };
            Console.WriteLine(String.Join(",", names));
            Boolean[] array2 = new Boolean[] { true, false, true, false, true, false, true, false, true, false };
            Console.WriteLine(String.Join(",", array2));
            List<string> iceCream = new List<string>();
            iceCream.Add("Vanilla");
            iceCream.Add("Chocolate");
            iceCream.Add("Pistachio");
            iceCream.Add("Strawberry");
            iceCream.Add("Chocolate Chip Cookie Dough");
            Console.WriteLine(String.Join(",", iceCream));
            Console.WriteLine(iceCream.Count);
            Console.WriteLine(iceCream[2]);
            iceCream.RemoveAt(2);
            Console.WriteLine(iceCream.Count);
            Console.WriteLine(String.Join(",", iceCream));
            Dictionary<string, string> profile = new Dictionary<string, string>();
            Random rand = new Random();
            for (int i = 0; i < names.Length; i++)
            {
                profile.Add(names[i], iceCream[rand.Next(0, iceCream.Count)]);
            }
            foreach (var entry in profile)//found this in the plaform http://learn.codingdojo.com/m/25/5698/37833
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}