using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AufgabeA1_2_3
{
    public partial class Form1 : Form
    {
        /**
         * Define how far the box should move per click event
         */
        public int move = 10;

        public Form1()
        {
            InitializeComponent();

            // Reset the button
            CmdBox.Top = this.Height - 100;
            CmdBox.Left = this.Width / 2 - CmdBox.Width / 2;
        }

        private void CmdUp_Click(object sender, EventArgs e)
        {
            CmdBox.Top -= move;
        }

        private void CmdRight_Click(object sender, EventArgs e)
        {
            CmdBox.Left += move;
        }

        private void CmdDown_Click(object sender, EventArgs e)
        {
            CmdBox.Top += move;
        }

        private void CmdLeft_Click(object sender, EventArgs e)
        {
            CmdBox.Left -= move;
        }

        private void CmdHome_Click(object sender, EventArgs e)
        {
            CmdBox.Top = this.Height - 100;
            CmdBox.Left = this.Width / 2 - CmdBox.Width / 2;
        }
    }
}
