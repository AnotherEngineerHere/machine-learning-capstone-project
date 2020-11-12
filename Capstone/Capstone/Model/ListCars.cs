using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.model
{
    public class ListCars
    {
        public List<Car> Cars { get; }

        public ListCars()
        {
            Cars = new List<Car>();
        }

        public void Add_Car(string sold_Price, string maintenace_Price, string number_Doors, string number_Occupants, string lug_Boot_Size, string safety_Leve, string carF)
        {
            Car c = new Car(sold_Price, maintenace_Price, number_Doors, number_Occupants, lug_Boot_Size, safety_Leve,carF);
            Cars.Add(c);
        }

      

        public List<Car> Get_Range_From_Values(int min, int max,int type)
        {
            List<Car> o = new List<Car>();
            for (int i = 0; i < Cars.Count; i++)
            {
                string code = "";
                if (type == 1)
                {
                    code = Cars[i].Number_Doors.Trim();
                }
                else if(type == 2)
                {
                    code = Cars[i].Number_Occupants.Trim();
                }    
                
                int c = Int32.Parse(code);

                if ((c >= min && c <= max))
                {
                    o.Add(Cars[i]);
                }
            }

            return o;
        }

        
    }
}
