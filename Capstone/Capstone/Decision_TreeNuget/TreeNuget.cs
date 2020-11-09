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

namespace Capstone.Decision_TreeNuget
{
    class TreeNuget
    {
        private string path;

        private DataTable data;

        private CSVFileHandler csv;

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


                new DecisionVariable("Buying", 4), // 3 possible values (Sunny, overcast, rain)
                new DecisionVariable("Maint", 4), // 3 possible values (Hot, mild, cool)  
                new DecisionVariable("doors", 4), // 2 possible values (High, normal)    
                new DecisionVariable("persons", 3),  // 2 possible values (Weak, strong) 
                new DecisionVariable("Lug_boot", 3), // 2 possible values (High, normal)    
                new DecisionVariable("Safety", 3)  // 2 possible values (Weak, strong)

            };

            DecisionTree tree = id3learning.Learn(inputs, outputs);

            double error = new ZeroOneLoss(outputs).Loss(tree.Decide(inputs));



    }   }
}
