using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone.GUI
{
    public partial class EnterSample : Form
    {
        string[] buying = { "vhigh","high","med","low"};
        string[] maint = { "vhigh", "high", "med","low" };
        string[] doors = { "2","3","4","5" };
        string[] persons = { "2", "4", "5" };
        string[] lugbot = { "low", "med", "high" };
        string[] safety = {"low","med","high"};


        public EnterSample()
        {
            InitializeComponent();
            Fill(buying,BuyingCB);
            Fill(maint,MaintCB);
            Fill(doors,DoorsCB);
            Fill(persons, PersonsCB);
            Fill(lugbot, LugBootCB);
            Fill(safety,SafetyCB);
            
        }

        private void Fill(string[]sp,ComboBox c)
        {
            for (int i = 0; i < sp.Length; i++)
            {
                c.Items.Add(sp[i]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
