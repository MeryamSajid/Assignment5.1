using System;

class Program
{
    public static void Main(string[] args)
    {
       
        string[] salespeople = { "Danielle", "Edward", "Francis" };
        string[] initials = { "D", "E", "F" };
        double[] salesTotals = { 0, 0, 0 };

        double grandTotal = 0;
        double highestTotal = 0;
        string highestSale = "";

        while (true)
        {
            Console.WriteLine("Please enter the initial D, E, or F for the salesperson. Enter Z to exit.");
            string initial = Console.ReadLine().ToUpper();

            if (initial == "Z")
            {
                break;
            }
            else if (Array.Exists(initials, x => x == initial))
            {
                Console.WriteLine("Enter the sale:");
                if (double.TryParse(Console.ReadLine(), out double sale))
                {
                    int index = Array.IndexOf(initials, initial);
                    salesTotals[index] += sale;

                    grandTotal += sale;

                    if (sale > highestTotal)
                    {
                        highestTotal = sale;
                        highestSale = initial;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
            else
            {
                Console.WriteLine("Error invalid salesperson entered, please try again");
            }
        }

        Console.WriteLine("Grand Total: " + grandTotal);
        Console.WriteLine("Highest Sale: " + highestSale);
    }
}