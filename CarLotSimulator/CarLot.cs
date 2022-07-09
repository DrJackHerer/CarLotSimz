using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class CarLot
    {

        public CarLot()
        {
                
        }

        public static int numberOfCars = 0;

      public List<Car> ParkingLot = new List<Car>();

    }

    //public class Car
    //{
    //    public Car(string model, string engineNoise, string make, string year, bool isDrivable)
    //    {
    //        Model = model;
    //        EngineNoise = engineNoise;
    //        Make = make;
    //        Year = year;
    //        IsDrivable = isDrivable;
    //    }
    //    public Car()
    //    {

    //    }

    //    public int year { get; set; }
    //    public string model { get; set; }
    //    public string make { get; set; }
    //    public string enginenoise { get; set; }
    //    public string honknoise { get; set; }
    //    public bool isdrivable { get; set; }
    

        //public void MakeEngineNoise()
        //{
        //    Console.WriteLine($"This car  goes {EngineNoise}");
        //}

        //public void MakeHonkNoise()
        //{
        //    Console.WriteLine($"The horn goes {HonkNoise}.");
        //}
        

        


    //}
}
