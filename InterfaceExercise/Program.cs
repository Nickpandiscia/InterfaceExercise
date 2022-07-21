using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.IsSmall = true;
            car.SportsCar = "Porshe";
            car.NumberOfWheels = 4;
            car.NumberOfDoors = 2;
            car.ColorOfPaint = "grey";
            car.Logo = "Porshe";
            car.HasHeadLights = true;
            car.SpecialColor = "Sparkle grey";
                        
            Truck truck = new Truck();
            truck.HasTowMirrors = true;
            truck.BedSize = 5;
            truck.NumberOfWheels = 4;
            truck.HasHeadLights = false;
            truck.ColorOfPaint = "green/blue";
            truck.Logo = "Ford";
            truck.SpecialColor = "Ocean green";
            truck.NumberOfDoors = 2;

            SUV sUV = new SUV();
            sUV.TVSize = "12in";
            sUV.HasExtraBackSeats = true;
            sUV.NumberOfDoors = 6;
            sUV.NumberOfWheels = 6;
            sUV.ColorOfPaint = "White";
            sUV.HasHeadLights = true;
            sUV.Logo = "Chevy";
            sUV.SpecialColor = "Silver White";

            DateTime now = DateTime.Now;
            Console.WriteLine("Welcome to Nicks Automobile website.");
            Console.WriteLine($"Todays date is {now}");
            Console.WriteLine("------");
            Console.WriteLine("Would you like to see the info on your vehicles you've requested to see?");
            Console.WriteLine("Type 'y' to see or 'n' to go to the website.");
            var userInput = Console.ReadLine();
            if(userInput == "y")
            {
                Console.WriteLine($"Here is the info on the car you've requested:");
                Console.WriteLine($"Number of wheels:{car.NumberOfWheels}, Type:{car.SportsCar}, Small:{car.IsSmall}.");
                Console.WriteLine($"Color:{car.ColorOfPaint}, Headlights:{car.HasHeadLights}, Logo:{car.Logo}, Doors:{car.NumberOfDoors}, Company Color:{car.SpecialColor}.");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Info on the truck for your request:");
                Console.WriteLine($"Wheels:{truck.NumberOfWheels}, Bed size:{truck.BedSize}, Tow mirrors:{truck.HasTowMirrors}.");
                Console.WriteLine($"Color:{truck.ColorOfPaint},Headlights:{truck.HasHeadLights}, Logo:{truck.Logo}.");
                Console.WriteLine($"Company color:{truck.SpecialColor}, Doors:{truck.NumberOfDoors}.");
                Console.WriteLine("----------");
                Console.WriteLine("Info on the SUV for your request.");
                Console.WriteLine($"Wheels:{sUV.NumberOfWheels}, TV:{sUV.TVSize}, Headlights:{sUV.HasHeadLights}.");
                Console.WriteLine($"Color:{sUV.ColorOfPaint}, Extra seats:{sUV.HasExtraBackSeats}, Logo:{sUV.Logo}.");
                Console.WriteLine($"Doors:{sUV.NumberOfDoors}, Company color:{sUV.SpecialColor}.");
            }
            else
            {
                return;
            }
            Console.WriteLine("---------------");
            Console.WriteLine("If you like any of these vehicles, type which one you like.");
            Console.WriteLine(" ex: type 'SUV', 'Truck', 'Car'.");
            Console.WriteLine("Or type 'All' for all of them!");
            var userChoice = Console.ReadLine();
            if(userChoice == "SUV")
            {
                Console.WriteLine("Congrats on your new SUV!");
            }
            if(userChoice == "Truck")
            {
                Console.WriteLine("Congrats on your new truck!");
            }
            if(userChoice == "Car")
            {
                Console.WriteLine("Congrats on your new car!");
            }
            if (userChoice == "All")
            {
                Console.WriteLine("That's amazing! Congrats!");
            }          
        }
    }
}
