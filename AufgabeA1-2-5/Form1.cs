using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AufgabeA1_2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdBit1_Click(object sender, EventArgs e)
        {
            CmdBit1.Text = flip(CmdBit1.Text);
        }

        private void CmdBit2_Click(object sender, EventArgs e)
        {
            CmdBit2.Text = flip(CmdBit2.Text);
        }

        private void CmdBit3_Click(object sender, EventArgs e)
        {
            CmdBit3.Text = flip(CmdBit3.Text);
        }

        private void CmdBit4_Click(object sender, EventArgs e)
        {
            CmdBit4.Text = flip(CmdBit4.Text);
        }

        private void CmdBit5_Click(object sender, EventArgs e)
        {
            CmdBit5.Text = flip(CmdBit5.Text);
        }

        private void CmdBit6_Click(object sender, EventArgs e)
        {
            CmdBit6.Text = flip(CmdBit6.Text);
        }

        private void CmdBit7_Click(object sender, EventArgs e)
        {
            CmdBit7.Text = flip(CmdBit7.Text);
        }

        private void CmdBit8_Click(object sender, EventArgs e)
        {
            CmdBit8.Text = flip(CmdBit8.Text);
        }

        private string flip(string current_int)
        {
            if (current_int == "0")
            {
                return "1";
            }

            return "0";
        }

        private void CmdCalc_Click(object sender, EventArgs e)
        {
            string bits = CmdBit8.Text + CmdBit7.Text + CmdBit6.Text + CmdBit5.Text + CmdBit4.Text + CmdBit3.Text + CmdBit2.Text + CmdBit1.Text;
            LblResult.Text = "Wert in Dezimal: " + Convert.ToInt16(bits, 2).ToString();
        }

        private void CmdReset_Click(object sender, EventArgs e)
        {
            CmdBit1.Text = "0";
            CmdBit2.Text = "0";
            CmdBit3.Text = "0";
            CmdBit4.Text = "0";
            CmdBit5.Text = "0";
            CmdBit6.Text = "0";
            CmdBit7.Text = "0";
            CmdBit8.Text = "0";
        }
    }
}
