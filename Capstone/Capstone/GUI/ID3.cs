using Capstone.Decision_Tree;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Capstone.GUI
{
    public partial class ID3 : Form
    {
        public const string PATH = @"../../Data/probe.csv";

        CSVFileHandler csv;

        string path;

        Tree tree;


        public ID3(string path)
        {
            this.path = path;
            csv = new CSVFileHandler();
            tree = new Tree();
            InitializeComponent();
            CreateTree();
            ProbeTree();
         
        }

        public void CreateTree() 
        {
            DataTable data = csv.ImportFromCsvFile(path);
            tree.Root = tree.Learn(data, "");
          
            tree.Print(tree.Root, tree.Root.Name.ToUpper());
            string tr = tree.Visual;
            textTree.Text = tr;
            textTree.ReadOnly = true;
        }

        public void ProbeTree()
        {
            

            var valuesForQuery = new Dictionary<string, string>();

            DataTable data = csv.ImportFromCsvFile(path);

            string[] lines = File.ReadAllLines(PATH);


            for (int i = 0; i < lines.Length; i++)
            {
                valuesForQuery.Clear();
                string[] celdas = lines[i].Split(';');

                string buying = celdas[0];
                string maint = celdas[1];
                string doors = celdas[2];
                string persons = celdas[3];
                string lug_boot = celdas[4];
                string safety = celdas[5];

                valuesForQuery.Add(data.Columns[0].ToString(), buying);
                valuesForQuery.Add(data.Columns[1].ToString(), maint);
                valuesForQuery.Add(data.Columns[2].ToString(), doors);
                valuesForQuery.Add(data.Columns[3].ToString(), persons);
                valuesForQuery.Add(data.Columns[4].ToString(), lug_boot);
                valuesForQuery.Add(data.Columns[5].ToString(), safety);

                var result = tree.CalculateResult(tree.Root, valuesForQuery, "");

                if (result.Contains("Attribute not found"))
                {
                    Console.WriteLine("Ramdom answer: Yes");
                }
                else
                {
                    
                    Console.WriteLine(result);
                }

            }         
            

        }
      
    }
}

    