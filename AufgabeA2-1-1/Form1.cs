using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AufgabeA2_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdOutput_Click(object sender, EventArgs e)
        {
            if(TxtFirstname.Text.Length < 1 || TxtLastname.Text.Length < 1)
            {
                MessageBox.Show("Es sind noch leere Felder hinterlegt. Bitte ausfüllen!", "Leere Felder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            LblOutput.Text = TxtFirstname.Text + " " + TxtLastname.Text;
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            LblOutput.Text = "...";
            TxtFirstname.Clear();
            TxtLastname.Clear();
        }
    }
}
