//Demonstrate a statement lambda.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementLambda01
{
        class StatementLambdaDemo
        {
        // DelegateFact takes one int argument and returns an int result.
        delegate int DelegateFact(int end);
        static void Main()
            {
            
            // A statement lambda that returns the factorial
            // of the value it is passed.
            DelegateFact fact = (int n ) => {
                                    int r = 1;
                                    for (int i = 1; i <= n; i++)
                                     r = i * r;
                                    return r;
                                   }; // end statement

                Console.WriteLine("The factorial of 3 is " + fact(3));

                Console.WriteLine("The factorial of 5 is " + fact(5));

            // TODO:..
            // A statement lambda that returns the sum of values upto 'n'
           

        } // end Main()
    } // end class
    } //end namespace
