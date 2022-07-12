using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aryan_patel_Ex_03
{
    class Program //C# class
    {
        //Main() method
        static void Main(string[] args)
        {
            //creating integer array
            int[] IntArray = new int[] { 10, 20, 30, 40, 50 };
            Console.WriteLine("array 1: lower = 5 higher = 3");
            //call method ShowArray()
            ShowArray(IntArray, 5, 3);
            //creating double array
            double[] doubleArray = new double[] { 12.50, 13.25, 24.15 };
            Console.WriteLine("array 2: lower = 0 higher = 1");
            //call method ShowArray()
            ShowArray(doubleArray, 0, 1);
        }
        private static void ShowArray<T>(T[] a, int lowIndex, int highIndex)
        {
            //CHECKING lowIndex
            if (lowIndex < 0 || lowIndex > highIndex || lowIndex > a.Length)
            {
                //lowIndex should not be negative and should not be greater than highIndex or size of the array
                Console.WriteLine("lowIndex should not be negative and should not be greater than highIndex or size of the array");
            }
            else if (highIndex < 0 || highIndex < lowIndex || highIndex > a.Length)
            {
                Console.WriteLine("highIndex an not be negative, less than lowIndex or higher than the size of the array");
            }
            else
            {
                //prints all the elements between - starting from lowIndex value to highindex value.
                Console.WriteLine("Array elements between index " + lowIndex + " and " + highIndex);
                //using for loop
                for (int x = lowIndex; x <= highIndex; x++)
                {
                    Console.WriteLine(a[x]);//print each element
                }
            }
        }
    }
}
