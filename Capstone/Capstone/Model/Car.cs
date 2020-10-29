using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.model
{
    public class Car
    {
        
        public string Sold_Price { get; }
        public string Maintenace_Price { get; }
        public string Number_Doors { get; }
        public string Number_Occupants { get; }
        public string Lug_Boot_Size { get; }
        public string Safety_Level { get; }
        public string CarF { get; }

        public Car(string sold_Price, string maintenace_Price, string number_Doors, string number_Occupants, string lug_Boot_Size, string safety_Level, string carF)
        {
            Sold_Price = sold_Price;
            Maintenace_Price = maintenace_Price;
            Number_Doors = number_Doors;
            Number_Occupants = number_Occupants;
            Lug_Boot_Size = lug_Boot_Size;
            Safety_Level = safety_Level;
            CarF = carF;
        }
    }
}
