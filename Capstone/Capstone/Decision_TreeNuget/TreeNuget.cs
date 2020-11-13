using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Accord.MachineLearning.DecisionTrees;
using System.Data;
using Capstone.GUI;
using Accord.Statistics.Filters;
using Accord.Math;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math.Optimization.Losses;
using System.IO;

namespace Capstone.Decision_TreeNuget
{
    class TreeNuget
    {

        public const string NUGET = @"../../Data/nuget.csv";

        public const string PROBE = @"../../Data/probe.csv";

        public const string PROBE = @"../../Data/probe.csv";

        private string path;

        private DataTable data;

        private CSVFileHandler csv;

        private DecisionTree tree;

        public TreeNuget(string path)
        {
            this.path = path;
            csv = new CSVFileHandler();
        }

        public void CreateTree()
        {
            data = csv.ImportFromCsvFile(path);

            var codebook = new Codification(data);

            DataTable symbols = codebook.Apply(data);
            int[][] inputs = symbols.ToJagged<int>("Buying", "Maint", "doors", "persons", "Lug_boot", "Safety");
            int[] outputs = symbols.ToArray<int>("CarType");

            var id3learning = new ID3Learning()
            {
                new DecisionVariable("Buying", 4),
                new DecisionVariable("Maint", 4),
                new DecisionVariable("doors", 4),
                new DecisionVariable("persons", 3),
                new DecisionVariable("Lug_boot", 3),
                new DecisionVariable("Safety", 3)
            };

            tree = id3learning.Learn(inputs, outputs);
           

            string output = "";
            string tr = tree.ToRules().ToString();
<<<<<<< HEAD
            tr = tr.Replace(" =: ", ";").Replace(" && ", ";").Replace(" == ", "--").Replace("(", "").Replace(")", "");
=======
            tr = tr.Replace(" =: ", ";").Replace(" && ", ";").Replace(" == ", ";").Replace("(","").Replace(")","");
>>>>>>> master

            string[] r = tr.Split("\n\r".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            List<string> s = new List<string>();
            List<string> o = new List<string>();

            for (int i = 0; i < r.Length; i++)
            {
                s.Add(r[i]);
            }

            for (int i = 0; i < s.Count; i++)
            {
                string[] corrector = s[i].Split(';');

                for (int j = 1; j < corrector.Length; j++)
                {
                    output += corrector[j] + ";";
                    
                }

                output += corrector[0];
                o.Add(output);
                output = "";
            }


            var cs = new StringBuilder();
            foreach (var item in MakeTree(o, ';'))
            {
                var newLine = string.Format("{0}", item);
                cs.AppendLine(newLine);
            }
            File.WriteAllText(NUGET, cs.ToString());

           
            

            DataTable pb;
            pb = csv.ImportFromCsvFile(PROBE);
            Console.WriteLine(pb.Rows.Count);
            for (int i = 0; i < pb.Rows.Count; i++)
            {
                int[] query = codebook.Transform(new[,]{
                { "Buying", pb.Rows[i].ItemArray[0].ToString() },
                { "doors",pb.Rows[i].ItemArray[1].ToString()},
                { "personos",pb.Rows[i].ItemArray[2].ToString()},
                { "Lug_boot",pb.Rows[i].ItemArray[3].ToString()},
                { "safety",pb.Rows[i].ItemArray[4].ToString()}
                });
                int predicted = tree.Decide(query);
                string answer = codebook.Revert("CarType", predicted);


            }
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
    }

}