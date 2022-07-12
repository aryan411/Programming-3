using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aryan_Patel_Exercise02
{
    class Program
    {
        // Declares an double array with 10 elements
        public static double[] gradeArray = new double[10];


        // Declaring a delegate
        // Delegate for a function that receives an double and returns a bool
        public delegate bool predicatGrade(double grades);
        static void Main(string[] args)
        {
            int minV = 5;
            int maxV = 50;
            Random randomNumber = new Random();

            // Populate double array with random number between 5 and 50
            for (int i = 0; i < gradeArray.Length; i++)
            {
                gradeArray[i] = randomNumber.NextDouble() * (maxV - minV) + minV;
            }

            // Delegate
            predicatGrade gradesPredicate = grade => grade >= 15.00;

            Console.Write("Student Grades: ");

            // printing all student grades
            foreach (double g in gradeArray)
            {
                Console.Write($"{g} ");
            }
            Console.Write($"\n\nGrages greater than or equal to 15.00: ");

            //filtering student grades
            GFilter(gradeArray, gradesPredicate);

        }

        //  Method
        static void GFilter(double[] grades, predicatGrade gradesPredicate)
        {
            foreach (double g in grades)
            {
                if (gradesPredicate(g))
                {
                    Console.Write($"{g} ");
                }
            }
            Console.WriteLine("\n");

        }

    }
}
