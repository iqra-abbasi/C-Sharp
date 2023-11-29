using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace billcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        double inputunits;
        double surcharge = 0.05;
        double netbill;
        int costperunit = 5;
        double billperunit;
        int tvcharges = 35;
        double totalbill;
        double mytvcharges;




        private void btncalculate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtname.Text.Trim()))
            {
                MessageBox.Show("name required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtunits.Text.Trim()))
            {
                MessageBox.Show("units cannot be null", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtunits.Text, out int totalUnits)|| totalUnits <0)
            {
                MessageBox.Show("Please enter valid units", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {

                if (inputunits > 500)
                {

                    netbill = inputunits * surcharge;//adding 5%
                    billperunit = netbill * costperunit;//adding per unit price
                    mytvcharges = billperunit + tvcharges;
                    totalbill = mytvcharges;

                    MessageBox.Show($"Name: {txtname.Text}  \n  Total Units: {inputunits} \n  Cost per Unit: Rs. {costperunit}\nTotal Bill: Rs. {totalbill}",  "Bill Details");

                  



                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
              
           




        }

        private void txtunits_TextChanged(object sender, EventArgs e)
        {
            inputunits = Convert.ToDouble(txtunits.Text);
        }
    }
}
