using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new Carlot();

            //TODO

            //DONE: Create a seperate class file called Car :DONE
            //DONE: Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable :DONE
            //DONE: Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //DONE: The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            //Dot Notation
            Car car1 = new Car(); //<-------------------- Instantiation 1
            car1.Year = 2009;
            car1.Make = "Mazda";
            car1.Make = "CX-5";
            car1.EngineNoise = "Zoom Zoom";
            car1.HonkNoise = "beeep!";
            car1.IsDriveable = true;

            carLot.ParkingLot.Add(car1);

            //Object Initializer Syntax
            var car2 = new Car() //<--------------------- Instantiation 2
            {
                Year = 1999,
                Make = "Ford",
                Model = "F150",
                EngineNoise = "Vroom",
                HonkNoise = "*doesn't work*",
                IsDriveable = true
            };

            carLot.ParkingLot.Add(car2); //<------------- Instantiation  3
            //Custom Constructor
            Car car3 = new Car(1999, "Honda", "Accord", "Braaaaaaah", "Beeeeep", true);

            carLot.ParkingLot.Add(car3);
            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach (var car in carLot.ParkingLot)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
                car.MakeEngineNoise();
                car.MakeHonkNoise();
                Console.WriteLine($"Current Number of car: {++Carlot.numberOfCars}");
                Console.WriteLine("-------------------------------");
                Console.WriteLine();
                
            }
        }
    }
}
