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
            TxtOutput.Text += "\r\n----------------\r\nGo forward:\r\n";

            // Go forward
            for (int i = 0; i < 10; i++)
            {
                TxtOutput.Text += (i+1) + ". Hello World!\r\n";
            }

            TxtOutput.Text += "\r\n----------------\r\nGo backwards:\r\n";

            // Go backwards
            for (int i = 10; i > 0; i--)
            {
                TxtOutput.Text += i + ". Hello World!\r\n";
            }

            TxtOutput.Text += "\r\n----------------\r\nGet only even numbers:\r\n";

            // Output only the even numbers
            for (int i = 10; i > 0; i--)
            {
                if ((i % 2) == 0)
                {
                    TxtOutput.Text += i + ". Hello World!\r\n";
                }

                // Or
                /*if(i%2 != 0)
                {
                    continue;
                }*/
            }

            TxtOutput.Text += "\r\n----------------\r\nDouble for:\r\n";

            for (int i = 0; i < 10; i++)
            {
                for(int d = 0; d < 10; d++)
                {
                    TxtOutput.Text += (d+1) + " ";
                }
                TxtOutput.Text += "\r\n";
            }

            TxtOutput.Text += "\r\n----------------\r\nDouble for with condition:\r\n";

            for (int i = 0; i <= 10; i++)
            {
                for (int d = 0; d < 10; d++)
                {
                    if(d < i)
                    {
                        TxtOutput.Text += "   ";
                    } else
                    {
                        TxtOutput.Text += d + " ";
                    }
            
                }
                TxtOutput.Text += "\r\n";
            }
        }
    }
}
