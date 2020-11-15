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
    }
}