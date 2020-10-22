using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unterrichtseinheit01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /**
         * What you should do when the button is clicked.
         * Let's do some party!
         */
        private void CmdMyButton_Click(object sender, EventArgs e)
        {
            // Change the text
            this.LblOutput.Text = "Hello";

            // And change the color
            this.LblOutput.ForeColor = Color.Red;
        }

        private void CmdWorld_Click(object sender, EventArgs e)
        {
            // Add string to the output
            LblOutput.Text += " World";

            // It's same how:
            // LblOutput.Text = LblOutput.Text + " World";
            // But in the programming you use +=. It's much faster and is less code.
        }

        private void CmdAddDot_Click(object sender, EventArgs e)
        {
            LblDot.Text += ".";
        }
        /**
         * Change the color
         */
        private void CmdChangeColor_Click(object sender, EventArgs e)
        {
            CmdChangeColor.BackColor = Color.Yellow;
        }

        private void CmdChangeWidth_Click(object sender, EventArgs e)
        {
            CmdChangeWidth.Width += 200;
            CmdMyButton.Top = 0;
            CmdMyButton.Left = 0;
        }
    }
}
