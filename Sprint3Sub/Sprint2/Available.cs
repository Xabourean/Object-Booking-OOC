
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint3
{
    class Available : RentStates
    {

        public Vehicle book;

        public Available(Vehicle book)
        {
            this.book = book;
        }

        public int ViewRent()
        {
            Console.WriteLine($"{this.book.GetName()} is not booked.");
            return 0;
        }
    }
}