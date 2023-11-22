// See https://aka.ms/new-console-template for more information
using System;
namespace array_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal: ");
            string tal1 = Console.ReadLine();
            int tal1_1 = Convert.ToInt32(tal1);
            int[] tal = new int[3];
            tal[0] = 1;
            tal[1] = 2;
            tal[2] = tal1_1 ;
            Console.WriteLine("Alla tal: " + tal[0] + " ," + tal[1] + " ," + tal[2]);
        }
    }
}