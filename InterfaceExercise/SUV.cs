using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public bool HasExtraBackSeats { get; set; }
        public string TVSize { get; set; }
        public int NumberOfWheels { get; set; }
        public bool HasHeadLights { get; set; }
        public int NumberOfDoors { get; set; }
        public string ColorOfPaint { get; set; }
        public string Logo { get; set; }
        public string SpecialColor { get; set; }
    }
}
