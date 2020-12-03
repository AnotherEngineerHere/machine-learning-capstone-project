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

        public const string SAM2 = @"../../Data/Sample2.csv";

        public const string SAM1 = @"../../Data/Sample1.csv";

        public const string TRAIN = @"../../Data/training.csv";

        public const string COMP = @"../../Data/complete.csv";

        public const string EXP = @"../../Data/exp.csv";

        private Tree treeSample1;

        private Tree treeSample2;

        private Tree treeTrain;

        private Tree treeComplete;

        private TreeNuget tnSample1;
        
        private TreeNuget tnSample2;

        private TreeNuget tnTrain;

        private TreeNuget tnComplete;

        private DataTable data;

        private CSVFileHandler csv;

        private List<string> s;

        private List<int> results;

        public Experiment() 
        {
          
            treeSample1 = new Tree();
            treeSample2 = new Tree();
            treeTrain = new Tree();
            treeComplete = new Tree();
            tnSample1 = new TreeNuget(SAM1);
            tnSample2 = new TreeNuget(SAM2);
            tnTrain = new TreeNuget(TRAIN);
            
            csv = new CSVFileHandler();
            s = new List<string>();
            results = new List<int>();

            CreateTreeManualSample1();
            CreateTreeManualSample2();
            CreateTreeManualTrain();

            RunCases();
           
        }

        public List<int> GetAssertions() 
        {
            return results;
        }

        public void RunCases() 
        {
            ProbeSample1("vhigh");
            ProbeSample1("high");
            ProbeSample1("med");
            ProbeSample1("low");

            ProbeSample2("vhigh");
            ProbeSample2("high");
            ProbeSample2("med");
            ProbeSample2("low");


            ProbeTraining("vhigh");
            ProbeTraining("high");
            ProbeTraining("med");
            ProbeTraining("low");

            var cs = new StringBuilder();
            foreach (var item in s)
            {
                var newLine = string.Format("{0}", item);
                cs.AppendLine(newLine);
            }
            File.WriteAllText(EXP, cs.ToString());
        }

        public void ProbeSample1(string buying) 
        {
            Random r = new Random();
            int assertions = 0;

            for (int i = 0; i < 100; i++)
            {

                int maint = r.Next(1, 5);
                int doors = r.Next(1, 5);
                int persons = r.Next(1, 5);
                int lug_boot = r.Next(1, 5);
                int safety = r.Next(1, 5);


                string[] separatingStrings = { "-->" , "--"};

                string manual = ManualTreeTraining(buying, RandMaint(maint), RandDoors(doors), RandPer(persons), RandLug(lug_boot), RandSaf(safety), treeSample1);

                string[] m = manual.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

                string answer1 = m[m.Length - 1].Trim();

                
                int maint1 = r.Next(1, 5);
                int doors1 = r.Next(1, 5);
                int persons1 = r.Next(1, 5);
                int lug_boot1 = r.Next(1, 5);
                int safety1 = r.Next(1, 5);
                
                string accord = tnSample1.Example(buying, RandMaint(maint1), RandDoors(doors1), RandPer(persons1), RandLug(lug_boot1), RandSaf(safety1));

                string[] a = accord.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

                string answer2 = a[a.Length - 1].Trim();

                if (answer1.Equals(answer2))
                    assertions++;
               
            }

            s.Add("Set:Sample1" + "," + "SoldPrice:"+ buying + "," + "SameOutput:"+ assertions);
            results.Add(assertions);

        }

        public void ProbeSample2(string buying)
        {
            Random r = new Random();
            int assertions = 0;

            for (int i = 0; i < 100; i++)
            {

                int maint = r.Next(1, 5);
                int doors = r.Next(1, 5);
                int persons = r.Next(1, 5);
                int lug_boot = r.Next(1, 5);
                int safety = r.Next(1, 5);


                string[] separatingStrings = { "-->", "--" };

                string manual = ManualTreeTraining(buying, RandMaint(maint), RandDoors(doors), RandPer(persons), RandLug(lug_boot), RandSaf(safety), treeSample2);

                string[] m = manual.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

                string answer1 = m[m.Length - 1].Trim();


                int maint1 = r.Next(1, 5);
                int doors1 = r.Next(1, 5);
                int persons1 = r.Next(1, 5);
                int lug_boot1 = r.Next(1, 5);
                int safety1 = r.Next(1, 5);

                string accord = tnSample2.Example(buying, RandMaint(maint1), RandDoors(doors1), RandPer(persons1), RandLug(lug_boot1), RandSaf(safety1));

                string[] a = accord.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

                string answer2 = a[a.Length - 1].Trim();

                if (answer1.Equals(answer2))
                    assertions++;

            }

            s.Add("Set:Sample2" + "," + "SoldPrice:" + buying + "," + "SameOutput:" + assertions);
            results.Add(assertions);

        }

        public void ProbeTraining(string buying)
        {
            Random r = new Random();
            int assertions = 0;

            for (int i = 0; i < 100; i++)
            {

                int maint = r.Next(1, 5);
                int doors = r.Next(1, 5);
                int persons = r.Next(1, 5);
                int lug_boot = r.Next(1, 5);
                int safety = r.Next(1, 5);


                string[] separatingStrings = { "-->", "--" };

                string manual = ManualTreeTraining(buying, RandMaint(maint), RandDoors(doors), RandPer(persons), RandLug(lug_boot), RandSaf(safety), treeTrain);

                string[] m = manual.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

                string answer1 = m[m.Length - 1].Trim();


                int maint1 = r.Next(1, 5);
                int doors1 = r.Next(1, 5);
                int persons1 = r.Next(1, 5);
                int lug_boot1 = r.Next(1, 5);
                int safety1 = r.Next(1, 5);

                string accord = tnTrain.Example(buying, RandMaint(maint1), RandDoors(doors1), RandPer(persons1), RandLug(lug_boot1), RandSaf(safety1));

                string[] a = accord.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

                string answer2 = a[a.Length - 1].Trim();

                if (answer1.Equals(answer2))
                    assertions++;

            }

            s.Add("Set:Training" + "," + "SoldPrice:" + buying + "," + "SameOutput:" + assertions);
            results.Add(assertions);

        }

        public string ManualTreeTraining(string buying, string maint, string doors, string persons, string lug_boot, string safety, Tree tree) 
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

       

        public void CreateTreeManualSample1()
        {
            data = csv.ImportFromCsvFile(SAM1);
            treeSample1.Root = treeSample1.Learn(data, "");

        }

        public void CreateTreeManualSample2()
        {
            data = csv.ImportFromCsvFile(SAM2);
            treeSample2.Root = treeSample2.Learn(data, "");

        }

        public void CreateTreeManualTrain()
        {
            data = csv.ImportFromCsvFile(TRAIN);
            treeTrain.Root = treeTrain.Learn(data, "");

        }

        public void CreateTreeManualComp()
        {
            data = csv.ImportFromCsvFile(COMP);
            treeComplete.Root = treeTrain.Learn(data, "");

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
