using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aryan_patel_Ex_02
{
    class Invoice
    {
        // Properties
        public int PtNum { get; }
        public string PtDscr { get; }
        public int Qlt { get; }
        public decimal Price { get; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="partNumber"></param>
        /// <param name="partDescription"></param>
        /// <param name="quantity"></param>
        /// <param name="price"></param>
        public Invoice(int partNumber, string partDescription, int quantity, decimal price)
        {

            PtNum = partNumber;
            PtDscr = partDescription;
            Qlt = quantity;
            Price = price;
        }
    }
}
