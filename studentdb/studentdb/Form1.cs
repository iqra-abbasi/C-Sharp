using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentdb
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        SqlConnection con=new SqlConnection(@"Data Source=DESKTOP-0J02DHK\SQLEXPRESS01;Initial Catalog=studentdb;Integrated Security=True");
        SqlCommand cmd;

      


        private void btnadd_Click(object sender, EventArgs e)
        {



            /* if(string.IsNullOrEmpty(txtname.Text.Trim()))
 {
     txtname.Focus();
     this.BackColor = Color.Red;
     errorProvider1.SetError(txtname, "student name required!");
     return;
 }
 else
 {
     errorProvider1.Clear();
 }

 if(txtreg.Text.Length<12)
 {
     txtreg.Focus();
     errorProvider2.SetError(txtreg, "Registration Number Must be Greater Then 12");
     return;
 }
 else
 {
     errorProvider2.Clear();
 }
 if (!int.TryParse(txtmarks.Text, out int marks) || marks < 0)
 {
     txtmarks.Focus();
     this.BackColor = Color.Green;
     errorProvider3.SetError(txtmarks, "Marks Should Not be Negative!");
     return;
 }
 else
 {
     errorProvider3.Clear();
 }*/




            if (string.IsNullOrEmpty(txtname.Text.Trim()))
            {
                this.BackColor = Color.LightBlue;
                MessageBox.Show("Student name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txtreg.Text.Length!=12)
            {
                MessageBox.Show("Registration number must be exactly 12 characters","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtmarks.Text, out int marks) || marks < 0)
            {
                this.BackColor=Color.Green;
                MessageBox.Show("Marks should be a non-negative integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }





            DialogResult result = MessageBox.Show("Do you really want to save the record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                con.Open();

                cmd = new SqlCommand("INSERT INTO student(ID,Name,RegNo,CourseName,MidMarks,Semister) VALUES (@ID,@Name,@RegNo,@CourseName,@MidMarks,@Semister)", con);
                cmd.Parameters.Add("@ID", Convert.ToInt64(txtid.Text));
                cmd.Parameters.Add("@Name", txtname.Text);
                cmd.Parameters.Add("@RegNo", txtreg.Text);
                cmd.Parameters.Add("@CourseName", txtcourse.Text);
                cmd.Parameters.Add("@MidMarks", txtmarks.Text);
                cmd.Parameters.Add("@Semister", Convert.ToInt32(txtsemister.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            else
            {
                MessageBox.Show("Record not saved.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
