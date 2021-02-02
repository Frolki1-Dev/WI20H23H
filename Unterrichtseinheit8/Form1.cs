using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unterrichtseinheit8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_start_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 20; i++)
            {
                TxtOutput.Text += "Hello World!\r\n";
                LblNumRep.Text = (i+1).ToString();
            }
        }
    }
}
