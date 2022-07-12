using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample02
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "demonstration of extension methods";
            Console.WriteLine(name.FirstLetterToUppercase());
        } // end Main()
    }
}
