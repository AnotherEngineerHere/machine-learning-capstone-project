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
using Capstone.Decision_TreeNuget;
using Capstone.Experiment;


namespace DesicionTree_CapstoneProject
{
    public partial class Principal : Form
    {
        public const string PATH = @"../../Data/training.csv";

        private ListCars lc;

        private Capstone.GUI.Graphics c;

        private ID3 id3;

        private DataSet ds;

        string[] _categories = { "Buying", "Maintenance","Doors","Persons","Lug_Boot","Safety" };

        private Experiment exp;

        private ExGraph exGraph;

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
            
            ds.Tables[title].Columns.Add("Buying");
            ds.Tables[title].Columns.Add("Maintenance");
            ds.Tables[title].Columns.Add("Doors");
            ds.Tables[title].Columns.Add("Persons");
            ds.Tables[title].Columns.Add("Lug_Boot");
            ds.Tables[title].Columns.Add("Safety");
            ds.Tables[title].Columns.Add("IsGoodOption");

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
                string _carft = celdas[6];


                ds.Tables[title].Rows.Add(_sold_Price, _maintenance_Price, _number_doors, _number_occupants, _lug_Boot_Size, _safety_Leve,_carft);
                lc.Add_Car(_sold_Price, _maintenance_Price, _number_doors, _number_occupants, _lug_Boot_Size, _safety_Leve, _carft);
                 

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
            butExp.Visible = true;
         
        }

        private void Fill_Table(List<Car> list)
        {
            string title = "Cars Data";

            ds = new DataSet();

            ds.Tables.Add(title);

            ds.Tables[title].Columns.Add("Buying");
            ds.Tables[title].Columns.Add("Maintenance");
            ds.Tables[title].Columns.Add("Doors");
            ds.Tables[title].Columns.Add("Persons");
            ds.Tables[title].Columns.Add("Lug_Boot");
            ds.Tables[title].Columns.Add("Safety");
            ds.Tables[title].Columns.Add("IsGoodOption");

            string[] lineas = File.ReadAllLines(PATH);

            for (int i = 0; i < list.Count; i++)
            {
                ds.Tables[title].Rows.Add(list[i].Sold_Price, list[i].Maintenace_Price, list[i].Number_Doors, list[i].Number_Occupants, list[i].Lug_Boot_Size, list[i].Safety_Level,list[i].CarF);

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
            if (CategoriesCB.Text.ToString().Equals("Buying"))
            {
                DataTable dt = ((DataView)dataCar.DataSource).Table;
                dt.DefaultView.RowFilter = string.Format("Buying = '{0}'", ComboMultiple.Text);
            }
            else if (CategoriesCB.Text.ToString().Equals("Maintenance"))
            {
                DataTable dt = ((DataView)dataCar.DataSource).Table;
                dt.DefaultView.RowFilter = string.Format("Maintenance = '{0}'", ComboMultiple.Text);
            }
            else if (CategoriesCB.Text.ToString().Equals("Doors"))
            {
                Interval_Method(1);
            }
            else if (CategoriesCB.Text.ToString().Equals("Persons"))
            {
                Interval_Method(2);
            }
            else if (CategoriesCB.Text.ToString().Equals("Lug_Boot"))
            {
                DataTable dt = ((DataView)dataCar.DataSource).Table;
                dt.DefaultView.RowFilter = string.Format("Lug_Boot = '{0}'", ComboMultiple.Text);
            }
            else if (CategoriesCB.Text.ToString().Equals("Safety"))
            {
                DataTable dt = ((DataView)dataCar.DataSource).Table;
                dt.DefaultView.RowFilter = string.Format("Safety = '{0}'", ComboMultiple.Text);
            }


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
                    MessageBox.Show("Invalid range");
                }
            }
            else
            {
                MessageBox.Show("Entered data must be numbers");
            }
        }
      
        private void CategoriesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboMultiple.Visible = true;
            labFilter.Visible = true;
            butAcceptar.Visible = true;

           if(CategoriesCB.Text.ToString().Equals("Buying"))
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
            else if (CategoriesCB.Text.ToString().Equals("Maintenance"))
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
            else if (CategoriesCB.Text.ToString().Equals("Doors"))
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
            else if (CategoriesCB.Text.ToString().Equals("Persons"))
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
            else if (CategoriesCB.Text.ToString().Equals("Lug_Boot"))
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
            else if (CategoriesCB.Text.ToString().Equals("Safety"))
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
            c = new Capstone.GUI.Graphics(lc.Cars);
            c.Show();

        }

        private void butTree_Click(object sender, EventArgs e)
        {
            id3 = new ID3(PATH);
            id3.Show();
            
        }

        private void butExp_Click(object sender, EventArgs e)
        {
            exGraph = new ExGraph();
            exGraph.Show();

        }
    }
}
