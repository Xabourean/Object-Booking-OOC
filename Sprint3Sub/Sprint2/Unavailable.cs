using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint3
{
    class Unavailable : RentStates
    {
        public Vehicle book;

        public Unavailable(Vehicle book)
        {
            this.book = book;
        }

        public int ViewRent()
        {
            Console.WriteLine($"{this.book.GetName()} is booked \n Do not book {this.book.GetName()} again.");
            return 1;
        }
    }
}
