using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculator_assignment
{
    public partial class calculator : Form
    {

        //public variable declare
        double value1, value2;
        string sign;
       

        public calculator()
        {
            InitializeComponent();
        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }

        private void onebtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            //textBox1.Text = textBox1.Text + "1";
            textBox1.Text = textBox1.Text + onebtn.Text;
           
        }

        private void twobtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "2";
        }

        private void threebtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "3";
        }

        private void fourbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "4";
        }

        private void fivebtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "5";
        }

        private void sixbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "6";
        }

        private void sevenbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "7";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "8";
        }

        private void ninebtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "9";
        }




        private void addbtn_Click(object sender, EventArgs e)
        {
            // value1 = Convert.ToInt32(textBox1.Text);
            value1 = double.Parse(textBox1.Text);
            sign = "+";
            textBox1.Text = "";

        }

        private void zerobtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "0";
        }

        private void dotbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                // textBox1.Clear();
                textBox1.Text = "";
            if(!textBox1.Text.Contains("."))
            textBox1.Text = textBox1.Text + ".";
        }

        private void subbtn_Click(object sender, EventArgs e)
        {
            // value1 = Convert.ToInt32(textBox1.Text);
            value1 = double.Parse(textBox1.Text);
            sign = "-";
            textBox1.Text = "";

        }

        private void mulbtn_Click(object sender, EventArgs e)
        {
            // value1 = Convert.ToInt32(textBox1.Text);
            value1 = double.Parse(textBox1.Text);
            sign = "*";
            textBox1.Text = "";

        }

        private void divbtn_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            sign = "/";
            textBox1.Text = "";

        }

        

        private void brac1btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + ")";
           // textBox1.Text = textBox1.Text + onebtn.Text;

        }

        private void brac2btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") ;
            textBox1.Clear();
            textBox1.Text = textBox1.Text + "(";
        }

        private void equalbtn_Click_1(object sender, EventArgs e)
        {
            int result;
            //value2 = Convert.ToInt32(textBox1.Text);
            value2 = double.Parse(textBox1.Text);
            if(sign=="+")
            {
                // result = value1 + value2;
                //textBox1.Text = result.ToString();
                textBox1.Text = (value1 + value2).ToString();
            }

            else if(sign=="-")
            {
                // result = value1 - value2;
                // textBox1.Text = result.ToString();
                textBox1.Text = (value1 - value2).ToString();
            }

            else if (sign == "*")
            {
                // result = value1 * value2;
                // textBox1.Text = result.ToString();
                textBox1.Text = (value1 * value2).ToString();
            }
            else if (sign == "/")
            {
                // result = value1 / value2;
                //textBox1.Text = result.ToString();
                textBox1.Text = (value1 / value2).ToString();
            }

            else if (sign == "%")
            {
                // result = value1 / value2;
                //textBox1.Text = result.ToString();
                textBox1.Text = (value1 % value2).ToString();
            }
            else if (sign == "exp")
            { 


                double i = Convert.ToDouble(textBox1.Text);
                double j;
                j = value2;
                textBox1.Text = Math.Exp(i * Math.Log(j*4)).ToString();
            }

            else if (sign == "sin")
            {
                // double s= Convert.ToDouble(textBox1.Text);
                //double sin;
                //sin = value2;

                // textBox1.Text = Convert.ToString(sin);
                //textBox1.Text = Math.Sin(sin).ToString();


               
                value2 = Math.Sin(value2);
                // textBox1.Text = Convert.ToString(sin);
                textBox1.Text = value2.ToString();






            }


            // Change the background color here
            this.BackColor = Color.LightGreen;

        }

        private void cebtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
           // String f, s;
            //f = Convert.ToString(value1);
           //s = Convert.ToString(value2);
            //f = "";
            //s = "";
        }

        private void divbtn_Click_1(object sender, EventArgs e)
        {
            // value1 = Convert.ToInt32(textBox1.Text);
            value1 = double.Parse(textBox1.Text);
            sign = "/";
            textBox1.Text = "";
        }

        private void plusminusbtn_Click(object sender, EventArgs e)
        {
            double d = Convert.ToDouble(textBox1.Text);
            //textBox1.Text = Convert.ToString( - 1 * d);
            d = d * -1;
            textBox1.Text = d.ToString();
        }

        private void crossbtn_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length>0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            //else if (textBox1.Text=="")
           else if(textBox1.Text.Equals(""))
            {
                textBox1.Text = "0";
            }
        }

        private void piebtn_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "3.141592653589976323";
            textBox1.Text = textBox1.Text + "3.1417";
        }

        private void sinbtn_Click(object sender, EventArgs e)
        {
            //double sin = Convert.ToDouble(textBox1.Text);
            //sin = Math.Sin(sin);
            // textBox1.Text = Convert.ToString(sin);
            //textBox1.Text = sin.ToString();

            // value1 = Convert.ToInt32(textBox1.Text);
             value1 = double.Parse(textBox1.Text);
            sign = "sin";
            textBox1.Text = "";
            //sign = "sin";
            //textBox1.Text = textBox1.Text + "sin";

        }

        private void cosbtn_Click(object sender, EventArgs e)
        {
            double cos = Convert.ToDouble(textBox1.Text);
            cos = Math.Cos(cos);
            textBox1.Text = Convert.ToString(cos);
        }

        private void tanbtn_Click(object sender, EventArgs e)
        {
            double tan = Convert.ToDouble(textBox1.Text);
            tan = Math.Tan(tan);
            textBox1.Text = Convert.ToString(tan);
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            double log = Convert.ToDouble(textBox1.Text);
            log = Math.Log10(log);
            // textBox1.Text = Convert.ToString(log);
            textBox1.Text = log.ToString();
        }

        private void squarebtn_Click(object sender, EventArgs e)
        {
           
            double sqr = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            // textBox1.Text = Convert.ToString(sqr);
            textBox1.Text = sqr.ToString();
        }

        private void modbtn_Click(object sender, EventArgs e)
        {
            // value1 = Convert.ToInt32(textBox1.Text);
            value1 = double.Parse(textBox1.Text);
            sign = "%";
            textBox1.Text = "";
        }

        private void underbtn_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(textBox1.Text);
            sq = Math.Sqrt(sq);
            // textBox1.Text = Convert.ToString(sq);
            textBox1.Text = sq.ToString();
        }

        private void expbtn_Click(object sender, EventArgs e)
        {
            // value1 = Convert.ToInt32(textBox1.Text);
            value1 = double.Parse(textBox1.Text);
            sign = "exp";
            textBox1.Text = "";
        }

        private void nibtn_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }

        }