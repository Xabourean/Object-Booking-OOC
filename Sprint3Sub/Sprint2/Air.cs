using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint3
{
    //Create a child class of vehicles
    //Child class is named Air
    //implement the Dinterface interface
    public class Air : Vehicle, Dinterface
    {
        protected int WheelsPerGear;
        protected bool FlyByWire;
        protected string EngineType;
        protected string Features;

        //Constructor for Air class
        public Air( string VehicleName, int SpeedMPH, int WheelsPerGear, bool FlyByWire, string EngineType, string features) : base(VehicleName, SpeedMPH)
        {
            this.WheelsPerGear = WheelsPerGear;
            this.FlyByWire = FlyByWire;
            this.EngineType = EngineType;
            this.Features = features;
        }

        //Implement the required method as per the Dinterface
        public string Pdetails()
        {
            //Create conditions for it to print differently based on special features
            if (Features == null || Features == "null") 
            {
                return $"Air vehicle: {VehicleName} {"\n"} {"Number of wheels per landing gear:"} {WheelsPerGear} {"\n"} {"Fly by wire present?:"} {FlyByWire} {"\n"} {"Engine type:"} {EngineType} {"\n"} {"Speed in MPH:"} {SpeedMPH} {"\n"}";
            }
            else
            {
                return $"Air vehicle: {VehicleName} {"\n"} {"Number of wheels per landing gear:"} {WheelsPerGear} {"\n"} {"Fly by wire present?:"} {FlyByWire} {"\n"} {"Engine type:"} {EngineType} {"\n"} {"Speed in MPH:"} {SpeedMPH} { "\n"} {"Special features:"} {Features} {"\n"}";
            }
        }

        public string GetDetails()
        {
            //Create conditions for it to print differently based on special features
            if (Features == null || Features == "null")
            {
                return $"Air vehicle: {VehicleName} {"\n"} {"Number of wheels per landing gear:"} {WheelsPerGear} {"\n"} {"Fly by wire present?:"} {FlyByWire} {"\n"} {"Engine type:"} {EngineType} {"\n"} {"Speed in MPH:"} {SpeedMPH} {"\n"}";
            }
            else
            {
                return $"Air vehicle: {VehicleName} {"\n"} {"Number of wheels per landing gear:"} {WheelsPerGear} {"\n"} {"Fly by wire present?:"} {FlyByWire} {"\n"} {"Engine type:"} {EngineType} {"\n"} {"Speed in MPH:"} {SpeedMPH} { "\n"} {"Special features:"} {Features} {"\n"}";
            }
        }
    }
}
