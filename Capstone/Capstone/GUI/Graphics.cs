using CapstoneProject.model;
using System;
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
            cantidadMax = 151 + 167 + 170 + 184 + 181 + 175 + 193 + 158 + 168;
            CreateChart();
        }

        public void CreateChart() {
            noShow();
            string[] brands = {"Renault", "Chevrolet", "Ford", "Gm", "Audi", "Fiat", "Kia", "Nissan", "Subaru", "Peugeot" };
            int[] brandsC = {151, 167, 170, 184,181, 175,193,181,158,168};
            chartMarca.Series.Clear();
            chartMarca.Series.Add("carros por marca");
            for (int i = 0; i<brands.Length; i++) {
                chartMarca.Series["carros por marca"].Points.AddXY(brands[i], brandsC[i]);
            }
            chartMarca.Visible = true;
        
        }

        private void butPastelPor_Click(object sender, EventArgs e)
        {
            noShow();
            string[] brands = { "Renault", "Chevrolet", "Ford", "Gm", "Audi", "Fiat", "Kia", "Nissan", "Subaru", "Peugeot" };
            int[] brandsC = { 151, 167, 170, 184, 181, 175, 193, 181, 158, 168 };
            porcentaje.Series["Series1"].Points.Clear();
            for (int i = 0; i < brands.Length; i++)
            {
                double d = brandsC[i];
                porcentaje.Series["Series1"].Points.AddXY(brands[i],  d);
            }
            porcentaje.Visible = true;
            
        }


        private void precioMaximo_Click(object sender, EventArgs e)
        {
            noShow();
            string[] brands = { "Very high", "high", "med", "low"};
            int[] brandsC = { 432, 432, 432, 432,432};
            chartMarca.Series.Clear();
            chartMarca.Series.Add("carros por precio");
            for (int i = 0; i < brands.Length; i++)
            {
                chartMarca.Series["carros por precio"].Points.AddXY(brands[i], brandsC[i]);
            }
            chartMarca.Visible = true;
        }

        private void buttonPorCaros_Click(object sender, EventArgs e)
        {
            noShow();
            string[] brands = { "Very high", "high", "med", "low" };
            int[] brandsC = { 1,1,1,1};
            porcentaje.Series["Series1"].Points.Clear();
            for (int i = 0; i < brands.Length; i++)
            {
                double d = brandsC[i];
                porcentaje.Series["Series1"].Points.AddXY(brands[i], d);
            }
            porcentaje.Visible = true;

        }

        private void buttPuertas_Click(object sender, EventArgs e)
        {
            noShow();
            string[] brands = { "dos", "tres", "cuatro", "cinco"};
            int[] brandsC = { 432,432,432,432 };
            chartMarca.Series.Clear();
            chartMarca.Series.Add("carros por marca");
            for (int i = 0; i < brands.Length; i++)
            {
                chartMarca.Series["carros por marca"].Points.AddXY(brands[i], brandsC[i]);
            }
            chartMarca.Visible = true;
            /*puertas.Series.Add("puertas");
            puertas.Series["puertas"].Points.Clear();
            for (int i = 0; i < brands.Length; i++)
            {
                puertas.Series["puertas"].Points.AddXY(brands[i], brandsC[i]);
            }
            puertas.Visible = true;
            */
        }

        public void noShow() {
            porcentaje.Visible = false;
            chartMarca.Visible = false;
            puertas.Visible = false;
        }
    }
}
