using System;
using System.Collections.Generic;
using System.Text;


//Create a seperate class file called Car !DONE!
//Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
//Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
//The methods should take one string parameter: the respective noise property
namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
            
        }
        public Car(string year, string make, string model, string engineNoise, string honkNoise, string isDrivable)
        {
            Year = year;

        }
        public static bool MakeEngineNoise()
        {
            return false;

        }

        public bool MakeHonkNoise()
        {
            return true;

        }

        public string Model { get; set; }
        public string EngineNoise { get; set; }

        public string Make { get; set; }
        public string Year { get; set; }
        public bool IsDrivable { get; set; }



    }
}






    

