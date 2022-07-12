using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLibraryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new LinkedListLibrary.List<int>(); // create List container
            var list2 = new LinkedListLibrary.List<double>(); // create List container
            list1.InsertAtFront(5); // adding the first element or node
            list1.InsertAtFront(9); // adding the first element or node
            list1.InsertAtBack(3);   // adding the last element or node
            list1.InsertAtFront(10);  // adding the first element or node
            list1.InsertAtFront(1);  // adding the first element or node
            list1.Display();
            list2.InsertAtFront(4.6); // adding the first element or node
            list2.InsertAtFront(5.3); // adding the first element or node
            list2.InsertAtBack(3.5);   // adding the last element or node
            list2.InsertAtFront(10.10);  // adding the first element or node
            list2.InsertAtFront(12.22);  // adding the first element or node
            list2.Display();
            Console.WriteLine($"Minimum of list 1:- {list1.Minimum()}");
            Console.WriteLine($"Minimum of list 2:- {list2.Minimum()}");
            Console.WriteLine($"Last element of list 1:- {list1.GetLastNode()}");
            Console.WriteLine($"Last element of list 2:- {list2.GetLastNode()}");
        }
    }
}
