using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Aryan_Patel_Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random random = new Random();
                int[] nums = Enumerable.Range(1, 10000000)
                                 .Select(x => random.Next(1, 501))
                                 .ToArray();
               
              
                Console.WriteLine("\nSum, Distinct count with using LINQ:");
                // using linq
                var linqTimeStart = DateTime.Now;
                BigInteger linqSum = nums.Aggregate(0,(Sum, i) => Sum + i);
                var linqDistinct = nums.Distinct().Count();
                var linqTimeEnd = DateTime.Now;

                var linqTime = linqTimeEnd.Subtract(linqTimeStart).TotalMilliseconds;
                Console.WriteLine($"\nDist: {linqDistinct}\nSum:{linqSum}\ntime:{linqTime}\n");

                Console.WriteLine("\nSum, Distinct count with using PLINQ:");
                // using plinq
                var plinqTimeStart = DateTime.Now;
                BigInteger plinqSum = nums.AsParallel().Aggregate(0, (Sum, i) => Sum + i);
                var plinqDistinct = nums.AsParallel().Distinct().Count();
                var plinqTimeEnd = DateTime.Now;

                // display the result
                var plinqTime = plinqTimeEnd.Subtract(plinqTimeStart).TotalMilliseconds;
                Console.WriteLine($"\nDist: {plinqDistinct}\nSum:{plinqSum}\ntime:{plinqTime}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.ReadKey();
        }

       
    }
}

