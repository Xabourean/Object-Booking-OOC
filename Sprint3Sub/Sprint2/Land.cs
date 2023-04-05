using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint3
{
    //Create a child class of vehicles
    //Child class is named Land
    //implement the Dinterface interface
    public class Land : Vehicle, Dinterface
    {
        protected int WheelAmount;
        protected string EngineType;
        protected string Features;

        //Constructor for Land class
        public Land(string VehicleName, int SpeedMPH, int WheelAmount, string EngineType, string features) : base(VehicleName, SpeedMPH)
        {
            this.WheelAmount= WheelAmount;
            this.EngineType = EngineType;
            this.Features = features;
        }

        //Implement the required method as per the Dinterface
        public string Pdetails()
        {
            //Create conditions for it to print differently based on special features
            if (Features == null || Features == "null")
            {
                return $"Land vehicle: {VehicleName} {"\n"} {"Number of wheels:"} {WheelAmount} {"\n"} {"Engine type:"} {EngineType} {"\n"} {"Speed in MPH:"} {SpeedMPH} {"\n"}";
            }
            else
            {
                return $"Land vehicle: {VehicleName} {"\n"} {"Number of wheels:"} {WheelAmount} {"\n"} {"Engine type:"} {EngineType} {"\n"} {"Speed in MPH:"} {SpeedMPH} {"\n"} {"Special features:"} {Features} {"\n"}";
            }
        }


        public string GetDetails()
        {
            //Create conditions for it to print differently based on special features
            if (Features == null || Features == "null")
            {
                return $"Land vehicle: {VehicleName} {"\n"} {"Number of wheels:"} {WheelAmount} {"\n"} {"Engine type:"} {EngineType} {"\n"} {"Speed in MPH:"} {SpeedMPH} {"\n"}";
            }
            else
            {
                return $"Land vehicle: {VehicleName} {"\n"} {"Number of wheels:"} {WheelAmount} {"\n"} {"Engine type:"} {EngineType} {"\n"} {"Speed in MPH:"} {SpeedMPH} {"\n"} {"Special features:"} {Features} {"\n"}";
            }
        }
    }
}
