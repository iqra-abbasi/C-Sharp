using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listboxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnpopulate_Click(object sender, EventArgs e)
        {

           
            lstleft.Items.Clear();
            lstleft.Items.AddRange(new object[] { "One", "Two", "Three", "Four", "Five" });
            
        }

        private void btnright_Click(object sender, EventArgs e)
        {
            if (lstleft.SelectedIndex != -1)
            {
                lstright.Items.Add(lstleft.SelectedItem);
                lstleft.Items.RemoveAt(lstleft.SelectedIndex);
            }
            else
            {
                MessageBox.Show("No item selected in LstLeft.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        }

        private void btnrightall_Click(object sender, EventArgs e)
        {
            if (lstleft.Items.Count > 0)
            {
                lstright.Items.AddRange(lstleft.Items);
                lstleft.Items.Clear();
            }
            else
            {
                MessageBox.Show("LstLeft is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            lstleft.Items.Clear();
            lstright.Items.Clear();

           MessageBox.Show("Empty", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    

    }
    }
}
