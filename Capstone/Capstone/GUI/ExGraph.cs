using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capstone.Experiment;

namespace Capstone.GUI
{
    public partial class ExGraph : Form
    {
        private Experiment.Experiment expe;
        public ExGraph()
        {
            expe = new Experiment.Experiment();
            InitializeComponent();
            sample1();
            
        }

        public void sample1() {
            clear();
            Graph.Series[0].Points.AddXY("vHig", expe.GetAssertions()[0]);
            Graph.Series[0].Points.AddXY("high", expe.GetAssertions()[1]);
            Graph.Series[0].Points.AddXY("med", expe.GetAssertions()[2]);
            Graph.Series[0].Points.AddXY("low", expe.GetAssertions()[3]);
            
        }

        public void sample2() {
            clear();
            Graph.Series[0].Points.AddXY("vHig", expe.GetAssertions()[4]);
            Graph.Series[0].Points.AddXY("high", expe.GetAssertions()[5]);
            Graph.Series[0].Points.AddXY("med", expe.GetAssertions()[6]);
            Graph.Series[0].Points.AddXY("low", expe.GetAssertions()[7]);
        }

        public void training() {
            clear();
            Graph.Series[0].Points.AddXY("vHig", expe.GetAssertions()[8]);
            Graph.Series[0].Points.AddXY("high", expe.GetAssertions()[9]);
            Graph.Series[0].Points.AddXY("med", expe.GetAssertions()[10]);
            Graph.Series[0].Points.AddXY("low", expe.GetAssertions()[11]);
        }

        public void clear() {
            Graph.Series[0].Points.Clear();
        }

        private void s1_Click(object sender, EventArgs e)
        {
            sample1();
        }

        private void s2_Click(object sender, EventArgs e)
        {
            sample2();
        }

        private void treaning_Click(object sender, EventArgs e)
        {
            training();
        }
    }
}
