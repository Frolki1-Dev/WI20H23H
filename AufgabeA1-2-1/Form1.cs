using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AufgabeA1_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdYellow_Click(object sender, EventArgs e)
        {
            LblYellow.Text = "Gelbe Hintergrundfarbe";
            LblYellow.BackColor = Color.Yellow;
        }

        private void CmdRed_Click(object sender, EventArgs e)
        {
            LblRed.Text = "Rote Hintergundfarbe";
            LblRed.BackColor = Color.Red;
            LblRed.ForeColor = Color.White;
        }

        private void CmdGreen_Click(object sender, EventArgs e)
        {
            LblGreen.Text = "Grüne Hintergundfarbe";
            LblGreen.BackColor = Color.Green;
            LblGreen.ForeColor = Color.White;
        }

        private void CmdBlue_Click(object sender, EventArgs e)
        {
            LblBlue.Text = "Blaue Hintergundfarbe";
            LblBlue.BackColor = Color.Blue;
            LblBlue.ForeColor = Color.White;
        }
    }
}
