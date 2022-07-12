using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aryan_Patel_Exercise2
{
    static class StringBuilderExtensions
    {
        public static int CountWords(StringBuilder strob) //static method used to calculate the number of words contained the object strob
        {
            return strob.ToString().Split(' ').Length;  //returning the number of words contained in the strob object as output
        } //end of method
    }
}
