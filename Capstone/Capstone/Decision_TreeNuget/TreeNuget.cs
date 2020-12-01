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
    public class TreeNuget
    {

        public const string NUGET = @"../../Data/nuget.csv";

        public const string PROBE = @"../../Data/probe.csv";

        private string path;

        private DataTable data;

        private DataTable pb;

        private CSVFileHandler csv;

        private DecisionTree tree;

        private string result;

        private Codification codebook;

        public TreeNuget(string path)
        {
            this.path = path;
            csv = new CSVFileHandler();
            CreateTree();
            result = "";
        }

        public string GetResult()
        {
            Probe();
            return result;
        }

        public void CreateTree()
        {
            data = csv.ImportFromCsvFile(path);

            codebook = new Codification(data);

            DataTable symbols = codebook.Apply(data);
            int[][] inputs = symbols.ToJagged<int>("Buying", "Maint", "doors", "persons", "Lug_boot", "Safety");
            int[] outputs = symbols.ToArray<int>("CarType");

            var id3learning = new ID3Learning()
            {


                new DecisionVariable("Buying", 4), // 3 possible values (Sunny, overcast, rain)
                new DecisionVariable("Maint", 4), // 3 possible values (Hot, mild, cool)  
                new DecisionVariable("doors", 4), // 2 possible values (High, normal)    
                new DecisionVariable("persons", 3),  // 2 possible values (Weak, strong) 
                new DecisionVariable("Lug_boot", 3), // 2 possible values (High, normal)    
                new DecisionVariable("Safety", 3)  // 2 possible values (Weak, strong)

            };

            tree = id3learning.Learn(inputs, outputs);
           

            string output = "";
            string tr = tree.ToRules().ToString();
            tr = tr.Replace(" =: ", ";").Replace(" && ", ";").Replace(" == ", ";").Replace("(","").Replace(")","");
            tr = tr.Replace("Buying", "BUYING").Replace("Maint", "MAINT").Replace("doors", "DOORS").Replace("persons", "PERSONS").Replace("Lug_boot", "LUG_BOOT").Replace("Safety", "SAFETY");

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
                if (corrector[0].Equals("0"))
                {
                    output += "BAD";
                }
                else
                {
                    output += "GOOD";
                }
                
                o.Add(output);
                output = "";
            }

            

            var cs = new StringBuilder();
            foreach (var item in MakeTree(o,';'))
            {
                var newLine = string.Format("{0}", item);
                cs.AppendLine(newLine);
            }
            File.WriteAllText(NUGET, cs.ToString());    

        }


        public void Probe()
        {
            pb = csv.ImportFromCsvFile(PROBE);
            for (int i = 0; i < pb.Rows.Count; i++)
            {
                int[] query = codebook.Transform(new[,]
                {
                    { "Buying", pb.Rows[i].ItemArray[0].ToString() },
                    { "Maint", pb.Rows[i].ItemArray[1].ToString() },
                    { "doors", pb.Rows[i].ItemArray[2].ToString() },
                    { "persons", pb.Rows[i].ItemArray[3].ToString()},
                    { "Lug_boot", pb.Rows[i].ItemArray[4].ToString() },
                    { "Safety", pb.Rows[i].ItemArray[5].ToString()}
                });


                int predicted = tree.Decide(query);
                if (predicted != -1)
                {
                    string answer = codebook.Revert("CarType", predicted);
                    result += "BUYING--" + pb.Rows[i].ItemArray[0].ToString() + "-->" + "MAINT--" + pb.Rows[i].ItemArray[1].ToString() + "-->" + "DOORS--"
                        + pb.Rows[i].ItemArray[2].ToString() + "-->" + "PERSONS--" + pb.Rows[i].ItemArray[3].ToString() + "-->" + "LUG_BOOT--" + pb.Rows[i].ItemArray[4].ToString() + "-->" + "SAFETY--" + pb.Rows[i].ItemArray[4].ToString() + "-->" + answer.ToUpper();
                    result += "\r\n";

                }
                else
                {
                    result += "BUYING--" + pb.Rows[i].ItemArray[0].ToString() + "-->" + "MAINT--" + pb.Rows[i].ItemArray[1].ToString() + "-->" + "DOORS--"
                        + pb.Rows[i].ItemArray[2].ToString() + "-->" + "PERSONS--" + pb.Rows[i].ItemArray[3].ToString() + "-->" + "LUG_BOOT--" + pb.Rows[i].ItemArray[4].ToString() + "-->" + "SAFETY--" + pb.Rows[i].ItemArray[4].ToString() + "-->" + "Not Answer Found";
                    result += "\r\n";
                }

            }
            
        }

        public string Example(string buying, string maint,string doors, string persons, string lug, string safety)
        {
            string outp = "";
            try
            {
                int[] query = codebook.Transform(new[,]
               {
                    { "Buying", buying },
                    { "Maint", maint },
                    { "doors", doors },
                    { "persons", persons},
                    { "Lug_boot", lug },
                    { "Safety", safety }
            });
                int predicted = tree.Decide(query);

                if (predicted != -1)
                {
                    string answer = codebook.Revert("CarType", predicted);
                    outp += "BUYING--" + buying + "-->" + "MAINT--" + maint + "-->" + "DOORS--"
                        + doors + "-->" + "PERSONS--" + persons + "-->" + "LUG_BOOT--" + lug + "-->" + "SAFETY--" + safety + "-->" + answer.ToUpper();
                    outp += "\r\n";

                }
                else
                {
                    string answer = codebook.Revert("CarType", predicted);
                    outp += "BUYING--" + buying + "-->" + "MAINT--" + maint + "-->" + "DOORS--"
                        + doors + "-->" + "PERSONS--" + persons + "-->" + "LUG_BOOT--" + lug + "-->" + "SAFETY--" + safety + "-->" + "Not Answer Found";
                    outp += "\r\n";
                }
            }
            catch(Exception e)
            {
                
                outp += "BUYING--" + buying + "-->" + "MAINT--" + maint + "-->" + "DOORS--"
                        + doors + "-->" + "PERSONS--" + persons + "-->" + "LUG_BOOT--" + lug + "-->" + "SAFETY--" + safety + "-->" + "BAD";
                outp += "\r\n"; 
            }
            

            return outp;
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