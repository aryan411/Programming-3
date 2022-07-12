using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementLambda02
{
    class UseStatementLambdas
    {
        // Declare a delegate type.
        delegate string StrMod(string s);
        static void Main()
        {
            // Create delegates that refer to lambda expressions
            // that perform various string modifications.
            // Replaces spaces with hyphens.
            StrMod ReplaceSpaces = s =>
            {
                Console.WriteLine("Replacing spaces with hyphens.");
                return s.Replace(' ', '-');
            };
            string str= ReplaceSpaces("This is to demonstrate use of statement lambdas");
            Console.WriteLine(str);
            

            //TODO:..
            // Create delegates that refer to lambda expressions
            // that perform various string modifications.
            // Replaces spaces with '*'

        }// end Main
    }
}
