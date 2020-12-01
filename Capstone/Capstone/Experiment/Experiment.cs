using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Decision_Tree;
using Capstone.Decision_TreeNuget;
using Capstone.GUI;

namespace Capstone.Experiment
{
    public class Experiment
    {

        public const string TRAIN = @"../../Data/training.csv";

        public const string PATH = @"../../Data/probe.csv";

        private Tree tree;

        private Tree treeP;

        private TreeNuget tn;
        
        private TreeNuget tna;

        private DataTable data;

        private CSVFileHandler csv;

        private string[] dataExperiment;

        public Experiment() 
        {
          
            tree = new Tree();
            treeP = new Tree();
            tn = new TreeNuget(TRAIN);
            tna = new TreeNuget(PATH);
            csv = new CSVFileHandler();
            dataExperiment = new string[8];
            CreateTreeManualTrain();
            CreateTreeManualProbe();
            RunCases();
            
        }

        public void RunCases() 
        {

            ProbeTraining("low");
        }

        public void ProbeTraining(string buying) 
        {
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                try 
                {
                    int maint = r.Next(1, 5);
                    int doors = r.Next(1, 5);
                    int persons = r.Next(1, 5);
                    int lug_boot = r.Next(1, 5);
                    int safety = r.Next(1, 5);


                    string[] separatingStrings = { "-->" };

                    string manual = ManualTreeTraining(buying, RandMaint(maint), RandDoors(doors), RandPer(persons), RandLug(lug_boot), RandSaf(safety));

                    string[] m = manual.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

                    string answer1 = m[m.Length - 1];

                    int maint1 = r.Next(1, 5);
                    int doors1 = r.Next(1, 5);
                    int persons1 = r.Next(1, 5);
                    int lug_boot1 = r.Next(1, 5);
                    int safety1 = r.Next(1, 5);

                    string accord = tn.Example(buying, RandMaint(maint1), RandDoors(doors1), RandPer(persons1), RandLug(lug_boot1), RandSaf(safety1));

                    string[] a = accord.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

                    string answer2 = a[a.Length - 1];

                    Console.WriteLine(" A2 " + manual);
                } 
                catch (Exception e) 
                {
                    Console.WriteLine("Some ouputs cannot be calculated");
                }
               
            }
           
            
        }

        public void ProbeSetProbe(string buying)
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {

                int maint = r.Next(1, 5);
                int doors = r.Next(1, 5);
                int persons = r.Next(1, 5);
                int lug_boot = r.Next(1, 5);
                int safety = r.Next(1, 5);

                string[] separatingStrings = { "-->" };

                string manual = ManualTreeProbe(buying, RandMaint(maint), RandDoors(doors), RandPer(persons), RandLug(lug_boot),RandSaf(safety));

                string[] m = manual.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

                string answer1 = m[m.Length - 1];

                int maint1 = r.Next(1, 5);
                int doors1 = r.Next(1, 5);
                int persons1 = r.Next(1, 5);
                int lug_boot1 = r.Next(1, 5);
                int safety1 = r.Next(1, 5);

                string accord = tna.Example(buying, RandMaint(maint1), RandDoors(doors1), RandPer(persons1), RandLug(lug_boot1), RandSaf(safety1));

                string[] a = accord.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

                string answer2 = a[a.Length - 1];

                Console.WriteLine("A1 " + answer1 + " A2 " + answer2);
            }


        }


        public string ManualTreeTraining(string buying, string maint, string doors, string persons, string lug_boot, string safety) 
        {
            string tr = "";
            var valuesForQuery = new Dictionary<string, string>();

            valuesForQuery.Add("BUYING", buying);
            valuesForQuery.Add("MAINT", maint);
            valuesForQuery.Add("DOORS", doors);
            valuesForQuery.Add("PERSONS", persons);
            valuesForQuery.Add("LUG_BOOT", lug_boot);
            valuesForQuery.Add("SAFETY", safety);

            tr = tree.CalculateResult(tree.Root, valuesForQuery, "");

            return tr;
        }

        public string ManualTreeProbe(string buying, string maint, string doors, string persons, string lug_boot, string safety)
        {
            string tr = "";
            var valuesForQuery = new Dictionary<string, string>();

            valuesForQuery.Add("BUYING", buying);
            valuesForQuery.Add("MAINT", maint);
            valuesForQuery.Add("DOORS", doors);
            valuesForQuery.Add("PERSONS", persons);
            valuesForQuery.Add("LUG_BOOT", lug_boot);
            valuesForQuery.Add("SAFETY", safety);

            tr = treeP.CalculateResult(treeP.Root, valuesForQuery, "");

            return tr;
        }

        public void CreateTreeManualTrain()
        {
            data = csv.ImportFromCsvFile(TRAIN);
            tree.Root = tree.Learn(data, "");

        }

        public void CreateTreeManualProbe()
        {
            data = csv.ImportFromCsvFile(PATH);
            treeP.Root = treeP.Learn(data, "");

        }

        public string RandMaint(int value)
        {
            string tr = "";

            if (value == 1)
            {
                tr = "vhigh";
            }
            else if (value == 2)
            {
                tr = "high";
            }
            else if (value == 3)
            {
                tr = "med";
            }
            else
            {
                tr = "low";
            }

            return tr;
        }

        public string RandDoors(int value)
        {
            string tr = "";

            if (value == 1)
            {
                tr = "2";
            }
            else if (value == 2)
            {
                tr = "3";
            }
            else if (value == 3)
            {
                tr = "4";
            }
            else
            {
                tr = "5";
            }

            return tr;
        }

        public string RandPer(int value)
        {
            string tr = "";

            if (value == 1)
            {
                tr = "2";
            }
            else if (value == 2)
            {
                tr = "4";
            }
            else
            {
                tr = "5";
            }

            return tr;
        }

        public string RandLug(int value)
        {
            string tr = "";

            if (value == 1)
            {
                tr = "small";
            }
            else if (value == 2)
            {
                tr = "med";
            }
            else
            {
                tr = "big";
            }

            return tr;
        }

        public string RandSaf(int value)
        {
            string tr = "";

            if (value == 1)
            {
                tr = "low";
            }
            else if (value == 2)
            {
                tr = "med";
            }
            else
            {
                tr = "high";
            }

            return tr;
        }
    }
}
