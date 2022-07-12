using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericMethodExample
{
    class NonGenericMethods
    {
        static void Main(string[] args)
        {
            // create arrays of int, double and char
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            Console.Write("Array intArray contains: ");
            DisplayArray(intArray); // pass an int array argument
            Console.Write("Array doubleArray contains: ");
            DisplayArray(doubleArray); // pass a double array argument
            Console.Write("Array charArray contains: ");
            DisplayArray(charArray); // pass a char array argument
        }

        private static void DisplayArray(int[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }

        // output double array                                 
        private static void DisplayArray(double[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }

        // output char array                                 
        private static void DisplayArray(char[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }
    }
}
