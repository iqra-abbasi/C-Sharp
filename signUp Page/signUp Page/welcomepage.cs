using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace signUp_Page
{
    public partial class welcomepage : Form
    {
        public welcomepage()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btndisable_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            txtemail.Enabled = false;
        }
    }
}
