using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aryan_Patel_Exercise01
{
    class Invoice
    {
        public int PartNumber { get; }
        public string PartDescription { get; }
        public int Quantity { get; }
        public decimal Price { get; }

        public Invoice(int partNumber, string partDescription, int quantity, decimal price)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quantity;
            Price = price;
        }
        public override string ToString()
        {
            return "PartNumber: " + PartNumber + " PartDescription: " + PartDescription
                + " Quantity: " + Quantity + " Price: " + Price;
        }
    }
}
