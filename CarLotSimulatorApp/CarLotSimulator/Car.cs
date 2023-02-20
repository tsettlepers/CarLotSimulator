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
        public string HonkNoise { get; private set; }       //makes it readonly externally
        public string EngineNoise { get; private set; }     //makes it readonly externally

        public Car()
        {
            //Default constructor
            IsDriveable = true;
        }

        public Car(int yr, string mk, string mod, bool canDrive)
        {
            Year = yr;
            Make = mk;
            Model = mod;
            IsDriveable= canDrive;
        }    

        public void MakeEngineNoise(string notedNoise)
        {
            //I don't really understand what you're wanting this to do; the instructions aren't clear.
            //Of course, the point is to see if I can organize these objects, so I'm simply making it do SOMETHING and moving on.
            //In my thinking, the reason for having a method like this is that it would do several things in addition to setting the property, so you didn't want to just handle that in the setter??
            EngineNoise = notedNoise;
        }

        public void MakeHonkNoise(string notedNoise)
        {
            //Once again... don't really know what you want me to do here.
            HonkNoise = notedNoise;
        }

        public override string ToString()
        {
            return $"{Year} {Make} {Model} that {(IsDriveable ? "is" : "is not")} driveable";
        }
    }
}
