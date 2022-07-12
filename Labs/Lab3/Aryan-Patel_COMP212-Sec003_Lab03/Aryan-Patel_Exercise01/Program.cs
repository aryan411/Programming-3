using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aryan_Patel_Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var invoices = new[] {
            new Invoice(87, "Electric Sander", 7, 57.98M),
            new Invoice(24, "Power Saw", 18, 99.99M),
            new Invoice(7, "Sledge Hammer", 11, 21.50M),
            new Invoice(77, "Hammer", 76, 11.99M),
            new Invoice(39, "Lawn Mover", 3, 79.50M),
            new Invoice(68, "Screw Driver", 106, 6.99M),
            new Invoice(56, "Jig Saw ", 21, 11.00M)
        };


                //display all invoices
                Console.WriteLine("All invoices:");
                foreach (var invc in invoices)
                {
                    Console.WriteLine(invc);
                }

                //a list of invoices with part Description and Total invoice sorted by ascending order

                var qry =
                    from i in invoices
                    let InvTotal = i.Price * i.Quantity
                    orderby InvTotal ascending
                    select new { i.PartDescription, InvTotal };

                Console.WriteLine("\nList of invoices with part Description and Total invoice sorted by ascending order:");

                foreach (var item in qry)
                {
                    Console.WriteLine(item);
                }


                //b part description of the part having highest quantity

                var qry2 = invoices.OrderByDescending(x => x.Quantity).First().PartDescription;


                Console.WriteLine("\nPart Description having higest quantity:");
                Console.WriteLine(qry2);



                //c average price of the parts

                var qry3 = invoices.Average(inv => inv.Price);

                //display average of price
                Console.WriteLine("\nAverage price of parts is:\n" + qry3);


                Console.ReadKey();
            } catch (Exception e) { Console.WriteLine(e.ToString()); }

           
        }
    }
}
