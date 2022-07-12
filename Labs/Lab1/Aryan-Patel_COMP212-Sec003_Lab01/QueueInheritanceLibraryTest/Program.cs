using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueInheritanceLibraryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //testing a lists of int and double values and getting the minimum value

            var list2 = new QueueInheritanceLibrary.QueueInheritance<double>(); // create List container
            var list1 = new QueueInheritanceLibrary.QueueInheritance<int>(); // create List container

            // create data to store in List
            // use List insert methods       
            list1.Enqueue(1);
            list1.Enqueue(2);
            list1.Enqueue(3);
            list1.Enqueue(4);
            list1.Enqueue(5);

            list1.Display();
            Console.WriteLine($"Minimum: {list1.Minimum()}");
            Console.WriteLine($"Last Element: {list1.GetLast()}");



            // create data to store in List
            // use List insert methods       
            list2.Enqueue(4.2); // adding the first element or node
            list2.Enqueue(3.1); // adding the first element or node
            list2.Enqueue(7.3); // adding the first element or node
            list2.Enqueue(9.3); // adding the first element or node

            Console.WriteLine("");
            list2.Display();
            Console.WriteLine($"Minimum: {list2.Minimum()}");
            Console.WriteLine($"Last Element: {list2.GetLast()}");
            Console.ReadLine();

        }
    }
}
