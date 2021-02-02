using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AufgabeA6_1_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            int start = TxtStartNumber.Text.Length > 0 ? Int16.Parse(TxtStartNumber.Text) : 0;
            int end = TxtEndNumber.Text.Length > 0 ? Int16.Parse(TxtEndNumber.Text) : 0;
            int steps = TxtStepsNumber.Text.Length > 0 ? Int16.Parse(TxtStepsNumber.Text) : 0;
            // modes:
            // 0 = All numbers
            // 1 = Odd numbers
            // 2 = Even numbers
            int mode = 0;

            // Make some checks
            if(start >= end)
            {
                MessageBox.Show("Do you want to kidding me?", "Are you sure about this?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Empty the lbl
            LblOutput.Text = "";

            // Check radio
            if (RadEvenNumber.Checked)
                mode = 2;
            else if (RadOddNumber.Checked)
                mode = 1;

            // Make the loop
            for(int i = start; i < end; i+=steps)
            {
                switch(mode)
                {
                    case 1:
                        if ((i % 2) == 0)
                            continue;
                        break;
                    case 2:
                        if ((i % 2) != 0)
                            continue;
                        break;
                    default:
                        // Nothing special
                        break;
                }

                // Output
                LblOutput.Text += i + "\r\n";
            }

            // Check if has any output
            if(LblOutput.Text.Length < 1)
            {
                LblOutput.Text = "Keine Resultate gefunden bzw. berechnet ;)";
            }
        }

        private void CmdDeleteOutput_Click(object sender, EventArgs e)
        {
            LblOutput.Text = "";
        }
    }
}
