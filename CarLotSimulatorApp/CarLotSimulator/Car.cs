using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator //Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
{
    public class Car
    {
        //Default Constructor
        public Car() { }
     
        //Custom Constructor
        public Car (int year, string make, string model, string engineNoise, string honkNoise, bool isDrivable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = true;      
        }

        // Properties--->
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }
        //<---Properties

        public void MakeEngineNoise()
        {
            Console.WriteLine($"This car goes {EngineNoise}");
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine($"This cars honk goes {HonkNoise}");
        }






        //public Car (int year, string make, string model, string engineNoise, string honkNoise, bool isDrivable)
        //{
        //    Year = year;
        //    Make = make;
        //    Model = model;                
        //    EngineNoise = engineNoise;
        //    HonkNoise = honkNoise;
        //    IsDriveable = true;
        //}
        ////Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
    }

}
