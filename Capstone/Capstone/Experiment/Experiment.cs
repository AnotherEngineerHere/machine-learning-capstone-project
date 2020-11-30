using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Decision_Tree;

namespace Capstone.Experiment
{
    public class Experiment
    {
        public const string TRAIN = @"../../Data/training.csv";

        public const string PROBE = @"../../Data/probe.csv";

        public const string COMPLE = @"../../Data/complete.csv";

        private List<string> vhigh;

        private List<string> high;

        private List<string> med;

        private List<string> low;

        private Tree tree;


        public Experiment() 
        {
            vhigh = new List<string>();
            high = new List<string>();
            med = new List<string>();
            low = new List<string>();
            tree = new Tree();
        }

        public void ProbeManualTraining() 
        {
            string[] lines = File.ReadAllLines(TRAIN);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] celdas = lines[i].Split(';');

               

            }
        }


        public void ManualTree(string buying, string maint, string doors, string persons, string lug_boot, string safety) 
        {
            var valuesForQuery = new Dictionary<string, string>();

            valuesForQuery.Add("BUYING", buying);
            valuesForQuery.Add("MAINT", maint);
            valuesForQuery.Add("DOORS", doors);
            valuesForQuery.Add("PERSONS", persons);
            valuesForQuery.Add("LUG_BOOT", lug_boot);
            valuesForQuery.Add("SAFETY", safety);

            var result = tree.CalculateResult(tree.Root, valuesForQuery, "");

            Console.WriteLine(result);
        }

        public string RandMaint(int value) 
        {
            string tr = "";

            if(value == 1)
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
