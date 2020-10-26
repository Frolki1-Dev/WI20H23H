using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AufgabeA1_2_4
{
    public partial class Form1 : Form
    {
        private int steps = 25;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdWindowHeightBigger_Click(object sender, EventArgs e)
        {
            this.Width += steps;
            updateInformation();
        }

        private void CmdWindowHeightSmaller_Click(object sender, EventArgs e)
        {
            this.Width -= steps;
            updateInformation();
        }

        private void CmdWindowsWidthBigger_Click(object sender, EventArgs e)
        {
            this.Height += steps;
            updateInformation();
        }

        private void CmdWindowWidthSmaller_Click(object sender, EventArgs e)
        {
            this.Height -= steps;
            updateInformation();
        }

        private void updateInformation()
        {
            this.CenterToScreen();
            LblDimension.Text = "Dimension: w" + this.Width + " h" + this.Height;
            LblPosition.Text = "Position: x" + this.Top + " y" + this.Left;
        }
    }
}
