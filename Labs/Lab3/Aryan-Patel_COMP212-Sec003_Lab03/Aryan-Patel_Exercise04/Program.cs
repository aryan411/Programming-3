using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aryan_Patel_Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string Str;
                Console.WriteLine("Enter a String:");
                Str = Console.ReadLine(); // Read the Input string from User at Run Time
                var Vl = Str.Split(' '); // Split the string using 'Space' and stored it an var variable
                Dictionary<string, int> RepeatedWordCount = new Dictionary<string, int>();
                for (int i = 0; i < Vl.Length; i++) //loop the splited string
                {
                    if (RepeatedWordCount.ContainsKey(Vl[i]) && Vl[i] != " " && Vl[i] != "  ") // Check if word already exist in dictionary update the count
                    {
                        int value = RepeatedWordCount[Vl[i]];
                        RepeatedWordCount[Vl[i]] = value + 1;
                    }
                    else
                    {
                        RepeatedWordCount.Add(Vl[i], 1); // if a string is repeated and not added in dictionary , here we are adding
                    }
                }
                Console.WriteLine();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("\n\nSorted Dictionary Contains:");
                Console.WriteLine(string.Format("{0, -15} {1, -20}", "Key", "Vl"));
                foreach (KeyValuePair<string, int> kvp in RepeatedWordCount)
                {
                    Console.WriteLine(string.Format("{0, -15} {1, -20}", kvp.Key, kvp.Value)); // Print the Repeated word and its count

                }
                Console.WriteLine("\n\nSize:" + RepeatedWordCount.Count);
                Console.WriteLine("\n Repeated Words\n");
                foreach (KeyValuePair<string, int> kvp in RepeatedWordCount)
                {
                    if (kvp.Value > 1)
                    {

                        Console.Write(kvp.Key + ", ");
                    }

                }

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

           
        }
    }
}
