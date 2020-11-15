using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Capstone.GUI
{
    public partial class Probe : Form
    {

        public const string PATH = @"../../Data/probe.csv";

        string result;

        DataSet ds;

        public Probe(string result)
        {
            this.result = result;
            InitializeComponent();
            CreateTable();
            CreateTree();
           
        }

        public void CreateTable()
        {
            MessageBox.Show("... :) The data has been loaded correctly :) ...");
            string title = "Cars Data";
            ds = new DataSet();
            ds.Tables.Add(title);
            ds.Tables[title].Columns.Add("Buying");
            ds.Tables[title].Columns.Add("Maintenance");
            ds.Tables[title].Columns.Add("Doors");
            ds.Tables[title].Columns.Add("Persons");
            ds.Tables[title].Columns.Add("Lug_Boot");
            ds.Tables[title].Columns.Add("Safety");

            string[] lineas = File.ReadAllLines(PATH);

            for (int i = 1; i < lineas.Length; i++)
            {
                string[] celdas = lineas[i].Split(';');

                string _sold_Price = celdas[0];
                string _maintenance_Price = celdas[1];
                string _number_doors = celdas[2];
                string _number_occupants = celdas[3];
                string _lug_Boot_Size = celdas[4];
                string _safety_Leve = celdas[5];


                ds.Tables[title].Rows.Add(_sold_Price, _maintenance_Price, _number_doors, _number_occupants, _lug_Boot_Size, _safety_Leve);

            }
            dataProbe.DataSource = ds.Tables[0].DefaultView;
        }

        public void CreateTree()
        { 
            textProbe.Text = result;
            textProbe.ReadOnly = true;
        }

    
    }
}
