using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public bool HasHeadLights { get; set; }
        public int NumberOfDoors { get; set; }
        public string ColorOfPaint { get; set; }
    }
}
