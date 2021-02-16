using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unterrichtseinheit09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstData.Items.Add("Apfel");
            LstData.Items.Add("Banane");
            LstData.Items.Add("Orange");
            LstData.Items.Add("Kiwi");
            LstData.Items.Add("Limette");
            LstData.Items.Add("Zitrone");
        }

        private void CmdShowOneElement_Click(object sender, EventArgs e)
        {
            // SEHR WICHTIG
            // Indexes fangen mit 0 an und nicht 1!
            int count = LstData.Items.Count;

            TxtData.Text = LstData.Items[count - 1].ToString();
        }

        private void CmdShowAllElements_Click(object sender, EventArgs e)
        {
            TxtData.Text = "";

            // Count the items
            int count = LstData.Items.Count;

            // Loop
            for(int i = 0; i < count; i++)
            {
                // Output
                TxtData.Text += LstData.Items[i].ToString() + "\r\n";
            }
        }

        private void CmdShowAllElementsWithForEach_Click(object sender, EventArgs e)
        {
            TxtData.Text = "";

            foreach(string value in LstData.Items)
            {
                TxtData.Text += value + "\r\n";
            }
        }

        private void CmdShowSelectedElement_Click(object sender, EventArgs e)
        {
            TxtData.Text = "";

            if(LstData.SelectedIndex < 0)
            {
                // No selected item
                MessageBox.Show("Kein Element ausgewählt!");
                return;
            }

            TxtData.Text = LstData.SelectedIndex + " : " + LstData.SelectedItem;
        }

        private void CmdShowAllSelectedElements_Click(object sender, EventArgs e)
        {
            TxtData.Text = "";

            /*foreach(string value in LstData.SelectedItems)
            {
                TxtData.Text += value + "\r\n";
            }*/

            int count = LstData.SelectedItems.Count;

            if(count < 1)
            {
                MessageBox.Show("Kein Element ausgewählt!", "Nice :)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for(int i = 0; i < count; i++)
            {
                TxtData.Text += LstData.SelectedIndices[i] + ": " + LstData.SelectedItems[i] + "\r\n";
            }
        }

        private void TxtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && TxtInput.TextLength > 0)
            {
                if(LstData.Items.Contains(TxtInput.Text))
                {
                    MessageBox.Show("Frucht existiert schon!");
                    return;
                }

                LstData.Items.Add(TxtInput.Text);
                TxtInput.Clear();
            }
        }
    }
}
