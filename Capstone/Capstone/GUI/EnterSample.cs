using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capstone.Decision_Tree;
using Capstone.Decision_TreeNuget;

namespace Capstone.GUI
{
    

    public partial class EnterSample : Form
    {
        Tree tree;

        TreeNuget tn;

        string[] buying = { "vhigh","high","med","low"};
        string[] maint = { "vhigh", "high", "med","low" };
        string[] doors = { "2","3","4","5" };
        string[] persons = { "2", "4", "5" };
        string[] lugbot = { "small", "med", "big" };
        string[] safety = {"low","med","high"};


        public EnterSample(Tree t, TreeNuget tn)
        {
            InitializeComponent();
            Fill(buying,BuyingCB);
            Fill(maint,MaintCB);
            Fill(doors,DoorsCB);
            Fill(persons, PersonsCB);
            Fill(lugbot, LugBootCB);
            Fill(safety,SafetyCB);

            this.tree = t;
            this.tn = tn;
            
        }

        private void Fill(string[]sp,ComboBox c)
        {
            for (int i = 0; i < sp.Length; i++)
            {
                c.Items.Add(sp[i]);
            }
        }

        public void CalculateAOutput()
        {


            var valuesForQuery = new Dictionary<string, string>();

            string buying = BuyingCB.Text;
            string maint = MaintCB.Text;
            string doors = DoorsCB.Text;
            string persons = PersonsCB.Text;
            string lug_boot = LugBootCB.Text;
            string safety = SafetyCB.Text;

            valuesForQuery.Add("BUYING", buying);
            valuesForQuery.Add("MAINT", maint);
            valuesForQuery.Add("DOORS", doors);
            valuesForQuery.Add("PERSONS", persons);
            valuesForQuery.Add("LUG_BOOT", lug_boot);
            valuesForQuery.Add("SAFETY", safety);

            var result = tree.CalculateResult(tree.Root, valuesForQuery, "");

            if (result.Contains("Attribute not found"))
            {
                MessageBox.Show("Can't caluclate outcome. Na valid route through the tree was found");
            }
            else
            {
                textSample.Text = result;
            }

        }

        public void CalculateAOutputAccord()
        {
            string buying = BuyingCB.Text;
            string maint = MaintCB.Text;
            string doors = DoorsCB.Text;
            string persons = PersonsCB.Text;
            string lug_boot = LugBootCB.Text;
            string safety = SafetyCB.Text;

            string output = tn.Example(buying,maint,doors,persons,lug_boot,safety);

            textSample.Text = output;
        }

        private void butCal_Click(object sender, EventArgs e)
        {
            CalculateAOutput();
        }

        private void butAcc_Click(object sender, EventArgs e)
        {
            CalculateAOutputAccord();
        }
    }
}
