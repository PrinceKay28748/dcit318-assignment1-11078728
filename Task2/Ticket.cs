using System;

public class Ticket
{

    public static void Main(string[] args)
    {
        int age;

        while (true) { 
            Console.WriteLine("Please enter your age :");
            string? input = Console.ReadLine();



            if (!int.TryParse(input, out age) || age <= 0)
            {
                Console.WriteLine("Invalid input: Age must be a positive number.");
            }

            else
            {
                break;
            }

        }

            if (age <= 12 || age >= 65)
        {
            Console.WriteLine("The price of the ticket is GHC 7");


        }


        else
        {
            Console.WriteLine("The price of the ticket is GHC 10");
        }
        

       
    }



}
