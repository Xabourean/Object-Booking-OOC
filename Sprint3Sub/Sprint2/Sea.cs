using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint3
{
    //Create a child class of vehicles
    //Child class is named Sea
    //implement the Dinterface interface
    public class Sea : Vehicle, Dinterface
    {
        protected int DryWeight;
        protected double Displacement;
        protected string EngineType;
        protected string Features;

        //Constructor for Sea class
        public Sea(string VehicleName, int SpeedMPH, int DryWeight, double Displacement, string EngineType, string Features) : base(VehicleName, SpeedMPH)
        {
            this.DryWeight = DryWeight;
            this.Displacement = Displacement;
            this.EngineType = EngineType;
            this.Features = Features;
        }

        //Implement the required method as per the Dinterface
        public string Pdetails()
        {
            //Create conditions for it to print differently based on special features
            if (Features == null || Features == "null")
            {
                return $"Sea vehicle: {VehicleName} {"\n"} {"Dry weight in pounds:"} {DryWeight} {"\n"} {"Displacement in litres:"} {Displacement} {"\n"} {"Engine type:"} {EngineType} {"\n"} {"Horsepower:"} {SpeedMPH} {"\n"}";
            }
            else
            {
                return $"Sea vehicle: {VehicleName} {"\n"} {"Dry weight:"} {DryWeight} {"\n"} {"Displacement:"} {Displacement} {"\n"} {"Engine type:"} {EngineType} {"\n"} {"Speed in MPH:"} {SpeedMPH} {"\n"} {"Special features:"} {Features} {"\n"}";
            }
        }

        public string GetDetails()
        {
            //Create conditions for it to print differently based on special features
            if (Features == null || Features == "null")
            {
                return $"Sea vehicle: {VehicleName} {"\n"} {"Dry weight in pounds:"} {DryWeight} {"\n"} {"Displacement in litres:"} {Displacement} {"\n"} {"Engine type:"} {EngineType} {"\n"} {"Horsepower:"} {SpeedMPH} {"\n"}";
            }
            else
            {
                return $"Sea vehicle: {VehicleName} {"\n"} {"Dry weight:"} {DryWeight} {"\n"} {"Displacement:"} {Displacement} {"\n"} {"Engine type:"} {EngineType} {"\n"} {"Speed in MPH:"} {SpeedMPH} {"\n"} {"Special features:"} {Features} {"\n"}";
            }
        }
    }
}