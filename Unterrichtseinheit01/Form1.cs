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
            this.LblOutput.Text = "You clicked the button! Greate job.";

            // And change the color
            this.LblOutput.ForeColor = Color.Red;
        }
    }
}
