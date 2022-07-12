using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aryan_Patel_Exercise01
{
    class Program
    {
        static void Main(string[] args) //main method
        {
            int[] integerArray = { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }; //declaration and initialization of an array of interger type.
            char[] charArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };  // declaration and initialization of an array of string type.
            Console.WriteLine("Values in Integer Array : ");
            foreach (var T in integerArray)   //printing values of integerArray
            {
                Console.Write($"\t{T}");
            }
            Console.WriteLine("\nValues in Char Array : ");
            foreach (var T in charArray)  //printing values of charArray
            {
                Console.Write($"\t{T}");
            }
            Console.WriteLine("\nPress '1' for integer array search or '2 for char array search' : ");
            int choice = Convert.ToInt32(Console.ReadLine());  //type of array selected by the user
            switch (choice)
            {
                case 1: //if the user selects "1" the interger array will be searched 
                    Console.WriteLine("Enter the integer to search for : ");  //user will enter the value to be searched
                    int searchElement = Convert.ToInt32(Console.ReadLine()); //taking the entered value as input

                    int result = Search(integerArray, searchElement);  //calling the generic method to compare the entered integer value

                    if (result.Equals(-1))
                    {
                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine($"The index location is {result}");  //displaying the value returned by the generic method which is the index value
                    }
                    break;
                case 2:  //if the user selects "2" the char array will be searched
                    Console.WriteLine("Enter the char to search for : ");  //asking user to enter a value
                    char searchElementChar = Convert.ToChar(Console.ReadLine()); //taking the value as input

                    int resultChar = Search(charArray, searchElementChar);   //calling the generic method to compare the entered char value
                    if (resultChar.Equals(-1))
                    {
                        Console.WriteLine(resultChar);
                    }
                    else
                    {
                        Console.WriteLine($"The index location is {resultChar}"); //displaying the value returned by the generic method i.e. the index value
                    }
                    break;
            }


            Console.ReadLine();
        }//end of main method

        public static int Search<T>(T[] dataArray, T SearchKey) where T : IComparable<T> // generic method that searches the array using linear search algorithm
        {
            for (int index = 0; index < dataArray.Length; index++)
            {
                if (dataArray[index].CompareTo(SearchKey) == 0) //checks if the entered number is in the array
                {
                    return index;  //gives the position of the element 
                }
            }
            return -1;  //if the entered number is not in the array the program will return -1 as output
        }//end of generic method
    }//end of class
}

