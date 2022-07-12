using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aryan_patel_Ex_02
{
    class Program
    {
        /// <summary>
        /// Display Invoices
        /// </summary>
        /// <param name="invoices"></param>
        static void DisplayInvoices(IOrderedEnumerable<Invoice> invoices)
        {
            //Display headings
            Console.WriteLine(string.Format("{0, -15} {1, -20} {2, 10} {3, 10}", "Part Number", "Part Description", "Quantity", "Price"));
            // display the items one by one
            foreach (Invoice invoice in invoices)
            {
                Console.WriteLine(string.Format("{0, -15} {1, -20} {2, 10} {3, 10}",
                invoice.PtNum, invoice.PtDscr, invoice.Qlt, invoice.Price));
            }
        }
        static void Main(string[] args)
        {
            // Create a list
            List<Invoice> invoices = new List<Invoice>();
            // Create new invoice object using the given details
            invoices.Add(new Invoice(87, "Electric Sander", 7, 57.98m));

            invoices.Add(new Invoice(24, "Power Saw", 18, 99.99m));
            invoices.Add(new Invoice(7, "Sledge Hammer", 11, 21.50m));
            invoices.Add(new Invoice(77, "Hammer", 76, 11.99m));
            invoices.Add(new Invoice(39, "Lawn Mower", 3, 79.50m));
            invoices.Add(new Invoice(68, "Screw Driver", 106, 6.99m));
            invoices.Add(new Invoice(56, "Jig Saw", 21, 11.00m));
            // Sort by Part Number in ascending order
            var sortByPartNumber = invoices.OrderBy(p => p.PtNum);
            Console.WriteLine("Sort by Part Number in ascending order:");
            DisplayInvoices(sortByPartNumber);
            // Sort by Quantity in descending order
            Console.WriteLine();
            Console.WriteLine("Sort by Quantity in descending order:");
            var sortByQuantity = invoices.OrderByDescending(p => p.Qlt);
            DisplayInvoices(sortByQuantity);
            Console.ReadKey();
        }

    }
}
