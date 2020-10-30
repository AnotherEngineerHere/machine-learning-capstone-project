using CapstoneProject.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Capstone.GUI
{
    public partial class Graphics : Form
    {
        List<Car> cars;
        int cantidadMax;
        public Graphics(List<Car> c)
        {
            InitializeComponent();
            this.cars = c;
            noShow();
            CreateChart();
        }

        public void CreateChart()
        {
            noShow();
            barras.Series[0].Points.AddXY("low", carSoldPrice()[0]);
            barras.Series[0].Points.AddXY("med", carSoldPrice()[1]);
            barras.Series[0].Points.AddXY("high", carSoldPrice()[2]);
            barras.Series[0].Points.AddXY("vhigh", carSoldPrice()[3]);
            barras.Visible = true;

        }

        private void butPastelPor_Click(object sender, EventArgs e)
        {
            noShow();
            porcentaje.Series[0].Points.AddXY("low", carsByMaintenancePrice()[0]);
            porcentaje.Series[0].Points.AddXY("med", carsByMaintenancePrice()[1]);
            porcentaje.Series[0].Points.AddXY("high", carsByMaintenancePrice()[2]);
            porcentaje.Series[0].Points.AddXY("vhigh", carsByMaintenancePrice()[3]);

            porcentaje.Visible = true;

        }


        private void precioMaximo_Click(object sender, EventArgs e)
        {
            noShow();

            barras.Visible = true;
        }

        private void buttonPorCaros_Click(object sender, EventArgs e)
        {
            noShow();

            porcentaje.Visible = true;

        }

        private void buttPuertas_Click(object sender, EventArgs e)
        {
            noShow();

            barras.Visible = true;

        }

        public void noShow()
        {
            porcentaje.Visible = false;
            barras.Visible = false;
            puntos.Visible = false;
        }

        public List<int> carSoldPrice()
        {
            List<int> price = new List<int>();
            int low = 0;
            int high = 0;
            int med = 0;
            int vhigh = 0;
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine(cars[i].Sold_Price);
                if (cars[i].Sold_Price.Equals("low"))
                {
                    low += 1;
                }
                if (cars[i].Sold_Price.Equals("med"))
                {
                    med += 1;
                }
                if (cars[i].Sold_Price.Equals("high"))
                {
                    high += 1;
                }
                if (cars[i].Sold_Price.Equals("vhigh"))
                {
                    vhigh += 1;
                }

            }
            price.Add(low);
            price.Add(med);
            price.Add(high);
            price.Add(vhigh);
            return price;
        }
        public List<int> carsByMaintenancePrice()
        {
            List<int> price = new List<int>();
            int low = 0;
            int high = 0;
            int med = 0;
            int vhigh = 0;
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Maintenace_Price.Equals("low"))
                {
                    low += 1;
                }
                if (cars[i].Maintenace_Price.Equals("med"))
                {
                    med += 1;
                }
                if (cars[i].Maintenace_Price.Equals("high"))
                {
                    high += 1;
                }
                if (cars[i].Maintenace_Price.Equals("vhigh"))
                {
                    vhigh += 1;
                }

            }
            price.Add(low);
            price.Add(med);
            price.Add(high);
            price.Add(vhigh);
            return price;
        }
        public List<int> numbersCarsPerNumberOfDoors()
        {
            List<int> numbers = new List<int>();
            int t2 = 0;
            int t3 = 0;
            int f4 = 0;
            int f5 = 0;
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Number_Doors.Equals("2"))
                {
                    t2 += 1;
                }
                if (cars[i].Number_Doors.Equals("3"))
                {
                    t3 += 1;
                }
                if (cars[i].Number_Doors.Equals("4"))
                {
                    f4 += 1;
                }
                if (cars[i].Number_Doors.Equals("5"))
                {
                    f5 += 1;
                }

            }
            numbers.Add(t2);
            numbers.Add(t3);
            numbers.Add(f4);
            numbers.Add(f5);
            return numbers;
        }
        public List<int> numbersCarsPerNumberOfPeople()
        {
            List<int> numbers = new List<int>();
            int t2 = 0;
            int t3 = 0;
            int f4 = 0;
            int f5 = 0;
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Number_Occupants.Equals("2"))
                {
                    t2 += 1;
                }
                if (cars[i].Number_Occupants.Equals("3"))
                {
                    t3 += 1;
                }
                if (cars[i].Number_Occupants.Equals("4"))
                {
                    f4 += 1;
                }
                if (cars[i].Number_Occupants.Equals("5"))
                {
                    f5 += 1;
                }

            }
            numbers.Add(t2);
            numbers.Add(t3);
            numbers.Add(f4);
            numbers.Add(f5);
            return numbers;
        }
        public List<int> numberOfVehiclesPerTrunkSize()
        {
            List<int> size = new List<int>();
            int med = 0;
            int small = 0;
            int big = 0;
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Maintenace_Price.Equals("med"))
                {
                    small += 1;
                }
                if (cars[i].Maintenace_Price.Equals("big"))
                {
                    med += 1;
                }
                if (cars[i].Maintenace_Price.Equals("small"))
                {
                    big += 1;
                }


            }
            size.Add(small);
            size.Add(med);
            size.Add(big);
            return size;
        }

    }
}