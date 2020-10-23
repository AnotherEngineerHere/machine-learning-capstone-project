using Capstone.Decision_Tree;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone.GUI
{
    public partial class ID3 : Form
    {
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
      
    }
}

    