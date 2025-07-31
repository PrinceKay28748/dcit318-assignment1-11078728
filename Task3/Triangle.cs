using System.Runtime.ExceptionServices;

public class Triangle
{
    // Class for the main method
    public static void Main(string[] args)
    {
        int firstSide, secondSide, thirdSide;
        while (true)
        {
           
            Console.WriteLine("Enter the lengths of the three sides of the triangle:");
            Console.WriteLine("Side A: ");
            string? sideA = Console.ReadLine();
            int.TryParse(sideA, out firstSide);

            Console.WriteLine("Side B: ");
            string? sideB = Console.ReadLine();
            int.TryParse(sideB, out secondSide);

            Console.WriteLine("Side C: ");
            string? sideC = Console.ReadLine();
            int.TryParse(sideC, out thirdSide);

            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            {
                Console.WriteLine("Invalid input: Side lengths must be positive numbers.");
               
            }

            else
            {
                break;
            }


        } 

        // checking for validity of the triangle
        if (firstSide + secondSide > thirdSide && firstSide + thirdSide > secondSide && secondSide + thirdSide > firstSide)
        {
           if( firstSide == secondSide && secondSide == thirdSide)
            {
                Console.WriteLine("The triangle is equilateral.");
            }
            else if (firstSide == secondSide || secondSide == thirdSide || firstSide == thirdSide)
            {
                Console.WriteLine("The triangle is isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is scalene.");
            }
        }
        else
        {
            Console.WriteLine("The triangle is not valid.");
        }


    }
}