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
    public partial class ID3Probe : Form
    {
        string result;

        public ID3Probe()
        {
            InitializeComponent();

        }

        public ID3Probe(string result)
        {
            this.result = result;
        }
    }

}

