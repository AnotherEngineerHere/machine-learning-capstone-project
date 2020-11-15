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
using Capstone.Decision_TreeNuget;


namespace Capstone.GUI
{
    public partial class ID3 : Form
    {
        public const string PATH = @"../../Data/probe.csv";

        public const string TREE = @"../../Data/tree.csv";

        public const string NUGET = @"../../Data/nuget.csv";

        public const string TRAIN = @"../../Data/training.csv";

        private CSVFileHandler csv;

        private Tree tree;

        private Probe p;

        private EnterSample es;

        private DataTable data;

        private string path;

        private string result;

        private TreeNuget tn;

        public ID3(string path)
        {
            this.path = path;
            csv = new CSVFileHandler();
            tree = new Tree();
            tn = new TreeNuget(TRAIN);
            InitializeComponent();
            CreateTree();
            ProbeTree();
            radID3.Checked = true;
            LoadTreeViewFromFile(TREE);
        }

        public void CreateTree()
        {
            data = csv.ImportFromCsvFile(path);
            tree.Root = tree.Learn(data, "");

            tree.Print(tree.Root, tree.Root.Name.ToUpper());
            string tr = tree.Visual;



            string[] r = tr.Split("\n\r".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            List<string> s = new List<string>();

            for (int i = 0; i < r.Length; i++)
            {
                s.Add(r[i]);
            }

            var cs = new StringBuilder();
            foreach (var item in MakeTree(s, ';'))
            {
                var newLine = string.Format("{0}", item);
                cs.AppendLine(newLine);
            }
            File.WriteAllText(TREE, cs.ToString());


        }

        public void ProbeTree()
        {

            var valuesForQuery = new Dictionary<string, string>();

            string[] lines = File.ReadAllLines(PATH);


            for (int i = 1; i < lines.Length; i++)
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


                this.result += result;
                this.result += "\r\n";

            }
            butProbe.Visible = true;
            butRegister.Visible = true;

        }

        public static List<string> MakeTree(List<string> arRows, char sSeperator)
        {
            List<string> arReturnNodes = new List<string>();
            arRows.Sort();
            string sLastPath = "";
            int iFolderLength = 0;

            for (int iRow = 0; iRow < arRows.Count; iRow++)
            {
                string sRow = arRows[iRow];
                string[] sFolders = sRow.Split(sSeperator);
                iFolderLength = sFolders.Length;
                string sTab = "";
                string[] sLastFolders = sLastPath.Split(sSeperator);
                for (int i = 0; i < iFolderLength; i++)
                {
                    if (i > 0)
                    {
                        sTab = sTab + '\t';
                    }

                    if (!sLastPath.Equals(sRow))
                    {

                        if (sLastFolders != null && sLastFolders.Length > i)
                        {
                            if (!sLastFolders[i].Equals(sFolders[i]))
                            {
                                arReturnNodes.Add(sTab + sFolders[i]);
                                sLastFolders = null;
                            }
                        }
                        else
                        {
                            arReturnNodes.Add(sTab + sFolders[i]);

                        }
                    }

                }
                sLastPath = sRow;
            }
            return arReturnNodes;
        }

        public void LoadTreeViewFromFile(string file_name)
        {
            // Get the file's contents.
            string file_contents = File.ReadAllText(file_name);

            // Break the file into lines.
            string[] lines = file_contents.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            // Process the lines.
            treeData.Nodes.Clear();

            Dictionary<int, System.Windows.Forms.TreeNode> parents = new Dictionary<int, System.Windows.Forms.TreeNode>();
            foreach (string text_line in lines)
            {
                // See how many tabs are at the start of the line.
                int level = text_line.Length - text_line.TrimStart('\t').Length;

                // Add the new node.
                if (level == 0)
                    parents[level] = treeData.Nodes.Add(text_line.Trim());
                else
                    parents[level] = parents[level - 1].Nodes.Add(text_line.Trim());

                parents[level].EnsureVisible();
            }

            if (treeData.Nodes.Count > 0) treeData.Nodes[0].EnsureVisible();
        }


        private void butProbe_Click(object sender, EventArgs e)
        {
            p = new Probe(result);
            p.Show();
        }

        private void butAccord_Click(object sender, EventArgs e)
        {
            string r = tn.GetResult();
            p = new Probe(r);
            p.Show();
        }

        private void butRegister_Click(object sender, EventArgs e)
        {
            es = new EnterSample(tree, tn);
            es.Show();
        }

        

        private void butShow_Click(object sender, EventArgs e)
        {
            if (radID3.Checked == true)
            {
                LoadTreeViewFromFile(TREE);
            }
            else
            {
                LoadTreeViewFromFile(NUGET);
            }
        }

        
    }
}

    