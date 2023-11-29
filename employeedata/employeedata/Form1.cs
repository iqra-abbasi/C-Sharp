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

namespace employeedata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlCommand cmd;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0J02DHK\SQLEXPRESS01;Initial Catalog=employee;Integrated Security=True");

        private void btnadd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtid.Text.Trim()))
            {
                MessageBox.Show("id required","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else if(!int.TryParse(txtid.Text,out int id) || id<0)
            {
                MessageBox.Show("id should not be negative", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;


            }


            if (string.IsNullOrEmpty(txtname.Text.Trim()))
            {
                MessageBox.Show("name required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (txtname.Text.Length<6 || txtname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("name should be greater then 6 characters and not contains digits", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;


            }

            if (string.IsNullOrEmpty(txtdes.Text.Trim()))
            {
                MessageBox.Show("destination required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (txtdes.Text.Length < 6)
            {
                MessageBox.Show("destination should be greater then 6 characters", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;


            }

            if (string.IsNullOrEmpty(txtsalary.Text.Trim()))
            {
                MessageBox.Show("salary required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!int.TryParse(txtsalary.Text, out int salary) ||salary < 0)
            {
                MessageBox.Show("salary should be greater than zero", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;


            }




            DialogResult res = MessageBox.Show("Do You really Want to Insert Data","question",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {


                try
                {
                    con.Open();


                    cmd = new SqlCommand("INSERT  INTO empdata(ID,Name,Destination,Salary)VALUES (@ID,@Name,@Destination,@Salary)", con);
                    cmd.Parameters.Add("@ID", int.Parse(txtid.Text));
                    cmd.Parameters.Add("@Name", txtname.Text);
                    cmd.Parameters.Add("@Destination", txtdes.Text);
                    cmd.Parameters.Add("@Salary", int.Parse(txtsalary.Text));
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Successfully Inserted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            else
            {
                MessageBox.Show("Data Not Saved","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            }
       
    

        private void btnupdate_Click(object sender, EventArgs e)
        {


            DialogResult res = MessageBox.Show("Do You really Want to Update Data", "question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {


                try
                {

                    con.Open();

                    cmd = new SqlCommand("UPDATE  empdata set ID=@ID, Name=@Name, Destination=@Destination, Salary=@Salary", con);
                    cmd.Parameters.Add("@ID", int.Parse(txtid.Text));
                    cmd.Parameters.Add("@Name", txtname.Text);
                    cmd.Parameters.Add("@Destination", txtdes.Text);
                    cmd.Parameters.Add("@Salary", int.Parse(txtsalary.Text));
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }


            else
            {
                MessageBox.Show("Data Not Updated", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void btndlt_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Do You really Want to Delete Data", "question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {


                try
                {


                con.Open();

                // cmd = new SqlCommand("DELETE FROM empdata", con);
                // cmd = new SqlCommand("DELETE  empdata WHERE ID=@ID", con);
                //cmd.Parameters.Add("@ID", int.Parse(txtid.Text));


                int sid = int.Parse(txtsearch.Text);

                SqlCommand cmd = new SqlCommand("delete empdata where ID=@ID", con);
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = sid;

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Successfully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


             else
            {
                MessageBox.Show("Data Not Deleted", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do You really Want to Display Data", "question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {

                try
            {
                con.Open();


                cmd = new SqlCommand("SELECT * FROM empdata", con);
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                dataGridView1.DataSource = dt;

                //cmd.ExecuteNonQuery();

                con.Close();


                //this is to show data based on hid id
                /*
                int sid = int.Parse(txtsearch.Text);

                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM empdata where ID=@ID", con);

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = sid;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cmd.ExecuteNonQuery();
                con.Close();
                */

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            }


            else
            {
                MessageBox.Show("Data Not Displayed", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
