using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class CarLot
    {
        public string Name { get; set; }
        public List<Car> Inventory;

        public CarLot() 
        {
            Inventory = new List<Car>();
        }

        public CarLot (string name)
        { 
            this.Name = name; 
            Inventory= new List<Car>();
        }
    }
}
