using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aryan_Patel_Exercise2
{
    class StringBuilderExtensionTest
    {
        static void Main(string[] args)
        {
            StringBuilder strob = new StringBuilder("This is to test whether the extension method count can return a right answer or not");  //initializing the StringBuilder object.
            Console.WriteLine($"The number of words contained in the StringBuilder object strob is { StringBuilderExtensions.CountWords(strob)}");  //caling the extension method and passing the value of strob object as a parameter
            Console.ReadLine();
        }
    }
}
