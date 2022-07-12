using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// What is a lambda -- this is basically an annonymous function i.e one without a name
// void () { ...} -- represented as a lambda expression.
// you would see the operator '=>' that means "goes to"
// delegate is function pointer
// it holds the reference of a function with thes same signature

namespace Example01
{
            // Declare a delegate that takes an int argument
            // and returns an int result.
            delegate int Incr(int v);
            // Declare a delegate that takes an int argument
            // and returns a bool result.
            delegate bool IsEven(int v);
    // define another delegate
    delegate int OpDel(int val1, int val2);
class SimpleLambdaDemo
        {
            static void Main()
            {
                // Create an Incr delegate instance that refers to
                // a lambda expression that increases its parameter by 2.
                Incr incr = count => count + 2;
            
            Incr incr2 = Increment; // Reference of Increment method is 
            OpDel opDel1 = Sum;                      // assigned to the delegate incr2
                                                     //  Incr incr = (int count) => count + 2; // You can specify the type of count if you want
                                                     // Now, use the incr lambda expression.
            OpDel opDel2 = (int num1, int num2) => num1 + num2;

            Console.WriteLine(Sum(10, 20)); // this is normal way of calling a method
            Console.WriteLine(opDel1(10, 20)); // this is using delegate
            Console.WriteLine(opDel2(10, 20));

            Console.WriteLine("Use incr lambda expression: ");
                int x = -10;
                while (x <= 0)
                {
                    Console.Write(x + " ");
                    x = incr(x); // increase x by 2
                }
                Console.WriteLine("\n");
                // Create an IsEven delegate instance that refers to
                // a lambda expression that returns true if its parameter
                // is even and false otherwise.
                IsEven isEven = n => n % 2 == 0;
                
            // Now, use the isEven lambda expression.
                Console.WriteLine("Use isEven lambda expression: ");
                for (int i = 1; i <= 10; i++)
                    if (isEven(i))
                    Console.WriteLine(i + " is even.");

            // TODO:..

            // Create an IsOdd delegate instance that refers to
            // a lambda expression that returns true if its parameter
            // is odd and false otherwise.

        } // end Main

        public static int Increment(int value)
        {
            return value + 2;
        }

        public static int Sum(int value1, int value2)
        {
            return value1 + value2;
        }

    } // end class
    } // end namespace
   
