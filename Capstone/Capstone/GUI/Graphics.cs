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
            
            chartMarca.Visible = true;
        
        }

        private void butPastelPor_Click(object sender, EventArgs e)
        {
            noShow();
           
            porcentaje.Visible = true;
            
        }


        private void precioMaximo_Click(object sender, EventArgs e)
        {
            noShow();
           
            chartMarca.Visible = true;
        }

        private void buttonPorCaros_Click(object sender, EventArgs e)
        {
            noShow();
            
            porcentaje.Visible = true;

        }

        private void buttPuertas_Click(object sender, EventArgs e)
        {
            noShow();
            
            chartMarca.Visible = true;
            
        }

        public void noShow() {
            porcentaje.Visible = false;
            chartMarca.Visible = false;
            puertas.Visible = false;
        }
    }
}
