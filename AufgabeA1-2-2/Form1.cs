using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AufgabeA1_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdOnePoint_Click(object sender, EventArgs e)
        {
            addPointsToLblPoints(".");
        }

        private void CmdTwoPoints_Click(object sender, EventArgs e)
        {
            addPointsToLblPoints("..");
        }

        private void CmdThreePoints_Click(object sender, EventArgs e)
        {
            addPointsToLblPoints("...");
        }

        private void addPointsToLblPoints(string append)
        {
            LblPoints.Text += append;
        }
    }
}
