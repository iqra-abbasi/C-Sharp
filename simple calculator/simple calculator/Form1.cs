using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            int input1, input2, result;
            input1 = Convert.ToInt16(num1.Text);
            input2 = Convert.ToInt16(num2.Text);

            result = input1 + input2;
            res.Text = result.ToString();
        }

        private void subbtn_Click(object sender, EventArgs e)
        {
            int input1, input2, result;
            input1 = Convert.ToInt16(num1.Text);
            input2 = Convert.ToInt16(num2.Text);
            result = input1 - input2;
            res.Text = result.ToString();
        }

        private void mulbtn_Click(object sender, EventArgs e)
        {
            int input1, input2, result;
            input1 = Convert.ToInt16(num1.Text);
            input2 = Convert.ToInt16(num2.Text);
            result = input1 *input2;
            res.Text = result.ToString();
        }

        private void divbtn_Click(object sender, EventArgs e)
        {
            int input1, input2, result;
            input1 = Convert.ToInt16(num1.Text);
            input2 = Convert.ToInt16(num2.Text);
            result = input1 %input2;
            res.Text = result.ToString();
        }

        private void div2btn_Click(object sender, EventArgs e)
        {
            int input1, input2, result;
            input1 = Convert.ToInt16(num1.Text);
            input2 = Convert.ToInt16(num2.Text);
            result = input1 / input2;
            res.Text = result.ToString();
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            num1.Text = "";
            num2.Text = "";
            res.Text = "";
        }

        private void num2_TextChanged(object sender, EventArgs e)
        {

        }

        private void res_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
