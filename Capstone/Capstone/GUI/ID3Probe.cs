using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Capstone.GUI
{
    public partial class ID3Probe : Form
    {
        public const string PATH = @"../../Data/probe.csv";

        string result;

        DataSet ds;

        public ID3Probe()
        {
            InitializeComponent();

        }

        public ID3Probe(string result)
        {
            this.result = result;
        }


        public void createTable()
        {
            MessageBox.Show("...:) The data has been loaded correctly :)...");
            string title = "Cars Data";
            ds = new DataSet();
            ds.Tables.Add(title);
            ds.Tables[title].Columns.Add("P_VENTA");
            ds.Tables[title].Columns.Add("P_MANTENIMIENTO");
            ds.Tables[title].Columns.Add("N_PUERTAS");
            ds.Tables[title].Columns.Add("N_OCUPANTES");
            ds.Tables[title].Columns.Add("TAM_RETENEDOR");
            ds.Tables[title].Columns.Add("NIVEL_SEG");

            string[] lineas = File.ReadAllLines(PATH);

            for (int i = 1; i < lineas.Length; i++)
            {
                string[] celdas = lineas[i].Split(';');

                string _brand = celdas[0];
                string _sold_Price = celdas[1];
                string _maintenance_Price = celdas[2];
                string _number_doors = celdas[3];
                string _number_occupants = celdas[4];
                string _lug_Boot_Size = celdas[5];
                string _safety_Leve = celdas[6];


                ds.Tables[title].Rows.Add(_brand, _sold_Price, _maintenance_Price, _number_doors, _number_occupants, _lug_Boot_Size, _safety_Leve);
         
            }
            dataProbe.DataSource = ds.Tables[0].DefaultView;
        }

        private void ID3Probe_Load(object sender, EventArgs e)
        {
            createTable();
        }
    }

}

