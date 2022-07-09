using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Done
            var carLot = new CarLot();

            //Now that the Car class is created we can instanciate 3 new cars


            Car myFirstCar = new Car();
            // Dot notation
            myFirstCar.Model = "Subaru";
            carLot.ParkingLot.Add(myFirstCar);
            Car mySecondCar = new Car()
            {

                //object syntax
                Year = "1986",
                Make = "Toyota",
                Model = "AE86",
                

            };
            //carLot.Add(myFirstCar);
            //Custom
            //Year = year,
            //Make = make, etc


            Car myThirdCar = new Car(1995, "r34");
            myThirdCar.Model = "Nissan";

            //object  init
            var myFourthCar = new Car();
            {
                Year = 1990,
                Make = "Ford",
                Model = "Shelby GT500";
            }

            foreach(var car in carLot.ParkingLot)
            {
                Console.WriteLine($"{car.Model}{car.Year}");
            }

            



            Console.WriteLine(myFirstCar.Model);
            Console.WriteLine($"{mySecondCar}");
            Console.WriteLine(myThirdCar.Model);

            
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
