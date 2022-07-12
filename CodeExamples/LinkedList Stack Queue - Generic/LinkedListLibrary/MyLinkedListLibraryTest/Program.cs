using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLinkedListLibrary;

namespace MyLinkedListLibraryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<double>();

            list.InsertAtBack(10.6);
            list.InsertAtFront(20.5);
            list.InsertAtBack(30.3);
            list.InsertAtFront(40.2);
            list.Display();

            var list2 = new List<string>();

            list2.InsertAtBack("Java");
            list2.InsertAtBack("Csharp");
            list2.InsertAtBack("PHP");
            list2.InsertAtBack("Python");
            list2.Display();

        }
    }
}
