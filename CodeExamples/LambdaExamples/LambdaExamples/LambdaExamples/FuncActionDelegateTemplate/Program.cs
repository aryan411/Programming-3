using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncActionDelegateTemplate
{
    class Program
    {   // declaring a delegate..
        delegate int DelegateIncr(int value); // This is used to hold the reference of a method
        // any method which has the same signature as the delegate
        delegate bool DelegateIsEven(int value);
        delegate int DelegateSum(int value1, int value2);
        delegate void DelegateIncrement(int value);
        delegate void MyDel(); // can hold the ref of method that does not take
        // any input and does not return any value
        static void Main(string[] args)
        {
            DelegateIncrement delegateIncrement = num => Console.WriteLine($"{num}");
            // Built-in Delegate template
            Func<int, int> func = Increment;
            func = num => num + 2;
            Func<int, double> func2; // this func2 can be used to hold the ref of a function 
            // which takes one input as int and returns value of the type double

            Func<int, double, bool> func3;
            Func<int, int, int> func4 = Sum;
            Console.WriteLine($"Using a built-in delegate template- Sum call; {func4(7, 3)}");
            Func<int> func5; // no input, only the return type int
            Func<bool> func6;
            // Another built-in delegate template which for holding a ref ofa method which does not
            // takes two inputs and no return value
            Action<int, int> act1;

            Action<int, string, bool> act2;

            // Normal of invoking a function
            Console.WriteLine($"Normal Function- Increment call; {Increment(7)}");
            Console.WriteLine($"Normal Function- IsEven call; {IsEven(8)}");
            Console.WriteLine($"Normal Function- Sum call; {Sum(7, 11)}");
            // Another way of calling ..using 
            DelegateIncr delegateIncr = Increment; // assigning the reference of method Increment
                                                   // to the delegate variable
                                                   //Call the method using the delegate..
            Console.WriteLine($"Using delegate- Increment call; {delegateIncr(7)}");
            DelegateIsEven delegateIsEven = IsEven;
            Console.WriteLine($"Using delegate- IsEven call; {delegateIsEven(8)}");
            DelegateSum delegateSum = Sum;
            Console.WriteLine($"Using delegate- Sum call; {delegateSum(17, 11)}");
            delegateIncr = Increment2;
            Console.WriteLine($"Using delegate- Increment call; {delegateIncr(100)}");
            // delegateIncr = (int num) => (num + 2); // this a lambda expression
            delegateIncr = num => (num + 2); // type inference
            Console.WriteLine($"Using a lambda expression-; {delegateIncr(500)}");
            delegateSum = (num1, num2) => (num1 + num2);
            Console.WriteLine($"Using lambda-; {delegateSum(100, 200)}");
            delegateIsEven = num => num % 2 == 0;
            Console.WriteLine($"Using lambda-; {delegateIsEven(100)}");
            int number = 12;
            if (delegateIsEven(number))
                Console.WriteLine("Number is Even");
            else
                Console.WriteLine("Number is ODD");
            for (int i = 0; i <= 10; ++i)
            {
                if (delegateIsEven(i))
                    Console.WriteLine($"{i} is Even");
            }
            // Call ADD
            DelegateSum dlgSum = Sum;
            //dlgSum = (num1, num2) => (num1 + num2);
            int x = 10, y = 20;
            ADD(dlgSum, x, y); // Calling ADD passing a delegate variable
            ADD((num1, num2) => (num1 + num2), x, y); // Calling ADD by passing a lambda expression


        } // end method

        //private static void ADD(DelegateSum delSum, int num1, int num2)
        //{
        //    Console.WriteLine($"Addition of two numbers: {delSum(num1, num2)}");
        //}

        private static void ADD(DelegateSum delSum, int num1, int num2) => Console.WriteLine($"Addition of two numbers: {delSum(num1, num2)}");

        //private static int Increment(int num)
        //{
        //    return num + 2;
        //} // end Increment
        private static int Increment(int num) => num + 2; // using =>
        private static int Increment2(int count) => count + 1;
        //private static bool IsEven(int num)
        //{
        //    return num % 2 ==0;
        //} // end Increment
        //OR..
        private static bool IsEven(int num) => num % 2 == 0;
        //private static int Sum(int num1, int num2)
        //{
        //    return num1 + num2;
        //} // end Increment
        // OR..
        private static int Sum(int num1, int num2) => num1 + num2;
    } // end class
} // end namespace
