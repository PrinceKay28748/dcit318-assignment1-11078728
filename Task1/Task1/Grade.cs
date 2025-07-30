// Welcome to the Grading System Calcualator. This is a functional approach.
// It takes the grades and gives feedback based on the numerical score.

using System;

namespace GradeCalculatorApp
{

    public class Grade
    {
        // class for the main method 


        public static void Main(string[] args)
        {
            GradeCalculator evaluate = new GradeCalculator();
            evaluate.run();



        }
    };

    public class GradeCalculator
    {
        private int numericGrade;

        private void gradeMethod()
        {
            // Prompt user to enter the grade

            Console.WriteLine("Enter a Numeric Grade between 0 and 100");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade >= 0 || grade <= 100)
            {
                numericGrade = grade;


            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }

        }
        private string determineGrade(int numericGrade)
        {
            if (numericGrade >= 90) return "A";
            else if (numericGrade >= 80) return "B";
            else if (numericGrade >= 70) return "C";
            else if (numericGrade >= 60) return "D";
            else return "F";
        }


        public void run()
        {
            gradeMethod();

            string finalGrade = determineGrade(numericGrade);
            Console.WriteLine(" Your grade is " + finalGrade);


        }




















    }
}


