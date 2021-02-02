using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unterrichtseinheit08_while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            TxtOutput.Clear();
            int loop = 0;

            /*int value = Convert.ToInt32(TxtInput.Text);

            while (value > 0)
            {
                value /= 2;
                TxtOutput.Text += value + "\r\n";
                loop++;
            }*/

            int value = 0;
            string data = "";
            Random r = new Random();
            int input = Convert.ToInt32(TxtInput.Text);

            if (input >= 0 && input <= 1000)
            {
                do
                {
                    value = r.Next(0, 10000);
                    data += value + ", ";
                    loop++;
                } while (value != input);

                TxtOutput.Text = data;
                LblNumRepeats.Text = loop.ToString();
            } else
            {
                MessageBox.Show("Zahl muss zwischen 0 und 1000 leigen :)");
            }
        }
    }
}
