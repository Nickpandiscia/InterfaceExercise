using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public int BedSize { get; set; }
        public bool HasTowMirrors { get; set; }
        public int NumberOfWheels { get; set; }
        public bool HasHeadLights { get; set; }
        public int NumberOfDoors { get; set; }
        public string ColorOfPaint { get; set; }
        public string Logo { get; set; }
        public string SpecialColor { get; set; }
    }
}
