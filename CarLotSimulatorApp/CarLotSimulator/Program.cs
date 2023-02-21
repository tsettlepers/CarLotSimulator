using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var settleLot = new CarLot("The Settle Driveway");
            //DONE TODO
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var myCar = new Car() { Year=2015, Make="Honda", Model="Pilot", IsDriveable=true, EngineNoise="Purrrrrr", HonkNoise="Beep" };
            myCar.MakeEngineNoise();
            myCar.MakeHonkNoise();
            settleLot.Inventory.Add(myCar);
            Console.WriteLine($"Total cars created after mine = {CarLot.numCarsCreated}");

            //*************BONUS*************//
            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            //Method #1 - See above for initializer syntax
            //Method #2 - Just directly assign them
            var wifeCar = new Car();
            wifeCar.Year = 2017;
            wifeCar.Make = "Toyota";
            wifeCar.Model = "Camry";
            wifeCar.IsDriveable = true;
            wifeCar.EngineNoise = "Vrooomm";
            wifeCar.HonkNoise = "WokWok";
            wifeCar.MakeEngineNoise();
            wifeCar.MakeHonkNoise();
            settleLot.Inventory.Add(wifeCar);
            Console.WriteLine($"Total cars created after wife = {CarLot.numCarsCreated}");
            //Method #3 - Build the assignments into a constructor
            var daughterCar = new Car(2010, "Toyota", "Corolla", false, "Squeek", "CoughCough");
            daughterCar.MakeEngineNoise();
            daughterCar.MakeHonkNoise();
            settleLot.Inventory.Add(daughterCar);
            Console.WriteLine($"Total cars created after daughter = {CarLot.numCarsCreated}");

            //*************BONUS X 2*************//
            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine("*** Inventory List for " + settleLot.Name + "***");
            foreach (Car c in settleLot.Inventory) 
                Console.WriteLine(c.ToString());

            //Minor change
        }
    }
}
