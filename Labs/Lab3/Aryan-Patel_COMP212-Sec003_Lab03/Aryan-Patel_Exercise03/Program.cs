using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aryan_Patel_Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                List<int> list = new List<int>();
                Random random = new Random();
                // add ramdom number to the list
                for (int i = 0; i < 10; i++)
                {
                    list.Add(random.Next(1, 100));
                }

                Console.WriteLine("Original List:\n" + string.Join(" ", list));

                var qryList = list.Where(x => x > 50)
                    .Select(x => x + 10)
                    .OrderBy(x => x).ToList();
                Console.WriteLine("List with grater than 50 than added 10 and display in ascending order\n" + string.Join(" ", qryList));
                Console.ReadKey();
            } catch (Exception e) { Console.WriteLine(e.ToString()); }
            
        }
    }
}
