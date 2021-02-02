using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AufgabeA6_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdLoopA_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 20; i++)
            {
                LblLoop1.Text += "\r\n" + (i + 1);
            }
        }

        private void CmdLoop2_Click(object sender, EventArgs e)
        {
            for(int i = 50; i < 70; i += 2)
            {
                LblLoop2.Text += "\r\n" + i;
            }
        }

        private void CmdLoop3_Click(object sender, EventArgs e)
        {
            for(int i = 10; i > 0; i--)
            {
                LblLoop3.Text += "\r\n" + i;
            }
        }

        private void CmdLoop4_Click(object sender, EventArgs e)
        {
            for(int i = 0; i > -55; i-=5)
            {
                LblLoop4.Text += "\r\n" + i;
            }
        }
    }
}
