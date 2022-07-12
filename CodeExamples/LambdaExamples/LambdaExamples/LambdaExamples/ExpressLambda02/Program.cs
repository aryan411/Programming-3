// Example of Expression Lambdas

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressLambda02
{
    // Here is a delegate type that is compatible with lambda expression used here:
    delegate bool DelRange(int lower, int upper, int v);

    class Program
    {
        
        static void Main(string[] args)
        {
           // Here is an example that uses a lambda expression to
           //  determine if a value is within a specified range:
        DelRange rangeOK = (low, high, val) => (val >= low && val <= high);
           
            // After doing so, the lambda expression can be executed as shown here:
            if (rangeOK(10, 15, 13))
             Console.WriteLine("13 is within the range.");
            else
                Console.WriteLine("13 is not within the range.");
            
            // TODO:...
            // Define a lambda expression which calculate the average of three values
            // And Define corresponding delegate


        } // end main()

        
    } // end class
} // end namespace
