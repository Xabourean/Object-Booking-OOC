using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint3
{
    class Manufacturer
    {
        private static Manufacturer ManuInstance = null;

        //Create separate variables for each child class
        private List<Sea> SeaVehicle = new List<Sea>();
        private List<Air> AirVehicle = new List<Air>();
        private List<Land> LandVehicle = new List<Land>();

        //Instance the object
        public static Manufacturer CheckForInstance()
        {
            if (ManuInstance == null)
            {
                ManuInstance = new Manufacturer();
            }
            return ManuInstance;
        }

        //Construct the object and specify their child class
        public void AddSeaVehicle(Sea SeaVehicle)
        {
            this.SeaVehicle.Add(SeaVehicle);
        }

        public void AddAirVehicle(Air AirVehicle)
        {
            this.AirVehicle.Add(AirVehicle);
        }

        public void AddLandVehicle(Land LandVehicle)
        {
            this.LandVehicle.Add(LandVehicle);
        }

        //Call to print the details of the object(s)
        public void Pdetails()
        {
            foreach (Sea SeaVehicle in SeaVehicle)
            {
                Console.WriteLine(SeaVehicle.Pdetails());
            }

            foreach (Air AirVehicle in AirVehicle)
            {
                Console.WriteLine(AirVehicle.Pdetails());
            }

            foreach (Land LandVehicle in LandVehicle)
            {
                Console.WriteLine(LandVehicle.Pdetails());
            }
        }

    }
}
