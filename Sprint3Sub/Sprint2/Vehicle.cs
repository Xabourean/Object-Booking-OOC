
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint3
{
    //Create a class for vehicles and implement the Dinterface interface
    public class Vehicle
    {
        //Create two variables that all child classes will require
        public string VehicleName { get; set; }
        protected int SpeedMPH;

        public RentStates book;

        //Constructor for Vehicle class
        public Vehicle(string VehicleName, int SpeedMPH)
        {
            this.VehicleName = VehicleName;
            this.SpeedMPH = SpeedMPH;

            this.book = new Available(this);
        }


        public string GetName()
        {
            return this.VehicleName;
        }

        public void SetState(RentStates book)
        {
            this.book = book;
        }

        public int ViewRent()
        {
            // State pattern: find out from the state object what the result of visitAnimal should be
            return this.book.ViewRent();
        }

    }
}