using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capstone.GUI;
using CapstoneProject.model;

namespace DesicionTree_CapstoneProject
{
    public partial class Principal : Form
    {
        public const string PATH = @"../../Data/most.csv";

        ListCars lc;

        DataSet ds;

        string[] _categories = { "MARCA", "PRECIO DE VENTA", "PRECIO DE MANTENIMIENTO","NUMERO DE PUERTAS","PASAJEROS","TAMAÑO DEL RETENEDOR","NIVEL DE SEGURIDAD" };

        public Principal()
        {
            InitializeComponent();

            lc = new ListCars();

            for (int i = 0; i < _categories.Length; i++)
            {
                CategoriesCB.Items.Add(_categories[i]);
            }

            
        }

        public void Load_Data() 
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
            ds.Tables[title].Columns.Add("CARFET");

            string[] lineas = File.ReadAllLines(PATH);

            for (int i = 0; i < lineas.Length; i++)
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
                lc.Add_Car(_brand, _sold_Price, _maintenance_Price, _number_doors, _number_occupants, _lug_Boot_Size, _safety_Leve);
                 

            }
            dataCar.DataSource = ds.Tables[0].DefaultView;

            InitialSettings();

        }

        private void InitialSettings()
        {
            butAll.Visible = true;
            labCategories.Visible = true;
            CategoriesCB.Visible = true;
            butGraf.Visible = true;
            butTree.Visible = true;
        }

        private void Fill_Table(List<Car> list)
        {
            string title = "Cars Data";

            ds = new DataSet();

            ds.Tables.Add(title);
           
            ds.Tables[title].Columns.Add("MARCA");
            ds.Tables[title].Columns.Add("P_VENTA");
            ds.Tables[title].Columns.Add("P_MANTENIMIENTO");
            ds.Tables[title].Columns.Add("N_PUERTAS");
            ds.Tables[title].Columns.Add("N_OCUPANTES");
            ds.Tables[title].Columns.Add("TAM_RETENEDOR");
            ds.Tables[title].Columns.Add("NIVEL_SEG");

            string[] lineas = File.ReadAllLines(PATH);

            for (int i = 0; i < list.Count; i++)
            {
                ds.Tables[title].Rows.Add(list[i].Brand, list[i].Sold_Price, list[i].Maintenace_Price, list[i].Number_Doors, list[i].Number_Occupants, list[i].Lug_Boot_Size, list[i].Safety_Level);

            }

            dataCar.DataSource = ds.Tables[0].DefaultView; ;
        }


        private void butAll_Click(object sender, EventArgs e)
        {
            Fill_Table(lc.Cars);
        }

        private void butLoad_Click(object sender, EventArgs e)
        {
            Load_Data();
           
        }

        private void butAcceptar_Click(object sender, EventArgs e)
        {
            if (CategoriesCB.Text.ToString().Equals("MARCA")) 
            {
                Search_Method();
            }
            else if (CategoriesCB.Text.ToString().Equals("PRECIO DE VENTA"))
            {
                DataTable dt = ((DataView)dataCar.DataSource).Table;
                dt.DefaultView.RowFilter = string.Format("P_VENTA = '{0}'", ComboMultiple.Text);
            }
            else if (CategoriesCB.Text.ToString().Equals("PRECIO DE MANTENIMIENTO"))
            {
                DataTable dt = ((DataView)dataCar.DataSource).Table;
                dt.DefaultView.RowFilter = string.Format("P_MANTENIMIENTO = '{0}'", ComboMultiple.Text);
            }
            else if (CategoriesCB.Text.ToString().Equals("NUMERO DE PUERTAS"))
            {
                Interval_Method(1);
            }
            else if (CategoriesCB.Text.ToString().Equals("PASAJEROS"))
            {
                Interval_Method(2);
            }
            else if (CategoriesCB.Text.ToString().Equals("TAMAÑO DEL RETENEDOR"))
            {
                DataTable dt = ((DataView)dataCar.DataSource).Table;
                dt.DefaultView.RowFilter = string.Format("TAM_RETENEDOR = '{0}'", ComboMultiple.Text);
            }
            else if (CategoriesCB.Text.ToString().Equals("NIVEL DE SEGURIDAD"))
            {
                DataTable dt = ((DataView)dataCar.DataSource).Table;
                dt.DefaultView.RowFilter = string.Format("NIVEL_SEG = '{0}'", ComboMultiple.Text);
            }


        }

        public void Search_Method()
        {
            List<Car> o = lc.Get_SubString_For_A_Search(textSearch.Text);

            Fill_Table(o);

            textSearch.Focus();
            textSearch.Select(0, 0);
        }

        public void Interval_Method(int type)
        {
            string min = textMin.Text.Trim();
            string max = textMax.Text.Trim();


            if ((min.All(Char.IsDigit) && min.Length > 0) && (max.All(Char.IsDigit) && max.Length > 0))
            {
                int minimun = Int32.Parse(min);
                int maximun = Int32.Parse(max);

                if ((minimun >= 2 && minimun <= 5) && maximun <= 5)
                {
                    List<Car> o = lc.Get_Range_From_Values(minimun, maximun,type);
                    Fill_Table(o);
                }
                else
                {
                    MessageBox.Show("Rango invalido");
                }
            }
            else
            {
                MessageBox.Show("Los caracteres ingresados deben ser numeros");
            }
        }
      
        private void CategoriesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboMultiple.Visible = true;
            labFilter.Visible = true;
            butAcceptar.Visible = true;

            if (CategoriesCB.Text.ToString().Equals("MARCA"))
            {

                labMin.Visible = false;
                labMax.Visible = false;
                textMax.Visible = false;
                textMin.Visible = false;
                ComboMultiple.Visible = false;
                textSearch.Visible = true;
            }
            else if(CategoriesCB.Text.ToString().Equals("PRECIO DE VENTA"))
            {
                textSearch.Visible = false;
                ComboMultiple.Items.Clear();
                labMin.Visible = false;
                labMax.Visible = false;
                textMax.Visible = false;
                textMin.Visible = false;

                string[] _sp = { "vhigh", "high", "med", "low" };

                for (int i = 0; i < _sp.Length; i++)
                {
                    ComboMultiple.Items.Add(_sp[i]);
                }
            }
            else if (CategoriesCB.Text.ToString().Equals("PRECIO DE MANTENIMIENTO"))
            {
                textSearch.Visible = false;
                ComboMultiple.Items.Clear();
                labMin.Visible = false;
                labMax.Visible = false;
                textMax.Visible = false;
                textMin.Visible = false;

                string[] _sp = { "vhigh", "high", "med", "low" };

                for (int i = 0; i < _sp.Length; i++)
                {
                    ComboMultiple.Items.Add(_sp[i]);
                }
            }
            else if (CategoriesCB.Text.ToString().Equals("NUMERO DE PUERTAS"))
            {
                textSearch.Visible = false;
                textMax.Clear();
                textMin.Clear();
                labMin.Visible = true;
                labMax.Visible = true;
                textMax.Visible = true;
                textMin.Visible = true;
                ComboMultiple.Visible = false;

            }
            else if (CategoriesCB.Text.ToString().Equals("PASAJEROS"))
            {
                ComboMultiple.Visible = false;
                textSearch.Visible = false;
                textMax.Clear();
                textMin.Clear();
                labMin.Visible = true;
                labMax.Visible = true;
                textMax.Visible = true;
                textMin.Visible = true;
           

            }
            else if (CategoriesCB.Text.ToString().Equals("TAMAÑO DEL RETENEDOR"))
            {
                ComboMultiple.Items.Clear();
                textSearch.Visible = false;
                labMin.Visible = false;
                labMax.Visible = false;
                textMax.Visible = false;
                textMin.Visible = false;

                string[] _sp = { "small", "med", "big"};

                for (int i = 0; i < _sp.Length; i++)
                {
                    ComboMultiple.Items.Add(_sp[i]);
                }
            }
            else if (CategoriesCB.Text.ToString().Equals("NIVEL DE SEGURIDAD"))
            {
                textSearch.Visible = false;
                ComboMultiple.Items.Clear();
                labMin.Visible = false;
                labMax.Visible = false;
                textMax.Visible = false;
                textMin.Visible = false;

                string[] _brands = { "low", "med", "high" };

                for (int i = 0; i < _brands.Length; i++)
                {
                    ComboMultiple.Items.Add(_brands[i]);
                }



            }
        }

        private void butGraf_Click(object sender, EventArgs e)
        {
            Capstone.GUI.Graphics c = new Capstone.GUI.Graphics(lc.Cars);
            c.Show();

        }

        private void butTree_Click(object sender, EventArgs e)
        {
            
            ID3 id3 = new ID3(PATH);
            id3.Show();
        }
    }
}
