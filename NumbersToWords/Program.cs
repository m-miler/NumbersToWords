using System;
using Parsers;

namespace NumbersToWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool start_app = true;
            Console.WriteLine("To exit app please enter x");
            
            while (start_app) 
            {
                Console.WriteLine("Please enter the number you would like to convert: ");
                string input = Console.ReadLine();
                if (input == "x")
                {
                    start_app = false;
                }
                else 
                {
                    double number = Double.Parse(input);
                    Parsers.Countries.PL country = new Parsers.Countries.PL();
                    string result = country.ConvertNumberToString(number);
                    Console.WriteLine($"Number in words: {result}");
                }
            }
        }
    }
}