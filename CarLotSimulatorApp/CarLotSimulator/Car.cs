using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool IsDriveable { get; set; }
        public string HonkNoise { get; set; }
        public string EngineNoise { get; set; }

        public Car()
        {
            IsDriveable = true;
            CarLot.numCarsCreated++;        // Added for the static branch of the code
        }

        public Car(int yr, string mk, string mod, bool canDrive, string honk, string engine)
        {
            Year = yr;
            Make = mk;
            Model = mod;
            IsDriveable= canDrive;
            HonkNoise = honk;
            EngineNoise = engine;
            CarLot.numCarsCreated++;        // Added for the static branch of the code
        }    

        public void MakeEngineNoise()
        {
            Console.WriteLine($"{EngineNoise}");
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine($"{HonkNoise}");
        }

        public override string ToString()
        {
            return $"{Year} {Make} {Model} that {(IsDriveable ? "is" : "is not")} driveable";
        }
    }
}
