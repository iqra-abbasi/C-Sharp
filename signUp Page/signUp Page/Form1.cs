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
using System.Text.RegularExpressions;
namespace signUp_Page
{
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();
        }


        SqlCommand cmd;
        //  SqlConnection con;
        SqlDataAdapter da;

        // String pattern = "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$";
        String pattern = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}$";
        string pp = "r'^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[!@#\\$&*~]).{6,}$'";



        //database connection

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0J02DHK\SQLEXPRESS01;Initial Catalog=userregs;Integrated Security=True");


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
           /* if(txtfname.Text=="")
            {
                // MessageBox.Show("first name required");
                errorProvider1.SetError(txtfname, "first name required");
            }*/


            //validations on textbox
         if(string.IsNullOrEmpty(txtfname.Text.Trim()))
            {
                errorProvider1.SetError(txtfname, "first name required");
                return;
                
               
            }

            else
            {
                errorProvider1.Clear();

            }


            if (string.IsNullOrEmpty(txtlname.Text.Trim()))
            {
                errorProvider2.SetError(txtlname, "last name required");
                return;

            }

            else
            {
                errorProvider2.Clear();

            }

             if (string.IsNullOrEmpty(txtpassword.Text.Trim()))
            {
                errorProvider3.SetError(txtpassword, "password required");
                return;

            }
            else if (Regex.IsMatch(txtpassword.Text, pp) == false)
            {
                txtpassword.Focus();
                errorProvider3.SetError(this.txtpassword, "Password should contain upper,lower,digit and Special character ");
            }
             else if(txtpassword.Text.Length<5)
            {
                txtpassword.Focus();
                errorProvider3.SetError(this.txtpassword, "Password Must be more than 5 characters");
            }
            else
            {
                errorProvider3.Clear();

            }

             if (string.IsNullOrEmpty(txtemail.Text.Trim()))
        
            {
                errorProvider4.SetError(txtemail, "email required");
                return;

            }

          else  if (!txtemail.Text.Contains("@") && (!txtemail.Text.Contains(".")))
            {
                errorProvider4.SetError(txtemail, "must contain @ . sign ");
                txtemail.Focus();
            }

            else
            {
                errorProvider4.Clear();

            }


             if (string.IsNullOrEmpty(txtphone.Text.Trim()))
            {
                errorProvider5.SetError(txtphone, "phone number required");
                return;

            }
             else if(txtphone.Text.Length< 11 || txtphone.Text.Length > 11)
            {
                errorProvider5.SetError(txtphone, "Please enter a valid PhoneNumber");
                txtphone.Focus();
            }

            else
            {
                errorProvider5.Clear();

            }
             if (string.IsNullOrEmpty(txtid.Text.Trim()))
            {
                errorProvider6.SetError(txtid, "user id required");
                return;

            }

            else
            {
                MessageBox.Show("successfully inserted");

            }
         
         




            con.Open();
            cmd = new SqlCommand("INSERT INTO register (firstname,middlename,lastname,password,email,phonenumber,landlinenumber,id) VALUES (@firstname,@middlename,@lastname,@password,@email,@phonenumber,@landlinenumber,@id)", con);
            cmd.Parameters.Add("@firstname",txtfname.Text);
            cmd.Parameters.Add("@middlename", txtmname.Text);
            cmd.Parameters.Add("@lastname", txtlname.Text);
            cmd.Parameters.Add("@password", txtpassword.Text);
            cmd.Parameters.Add("@email", txtemail.Text);
            cmd.Parameters.Add("@phonenumber",Convert.ToInt32(txtphone.Text));
            cmd.Parameters.Add("@landlinenumber", txtland.Text);
            cmd.Parameters.Add("@id", Convert.ToInt32(txtid.Text));
            /* if (cmd.ExecuteNonQuery() > 0)
                 MessageBox.Show("new record added successfully");
             else
             {
                 MessageBox.Show("record cannot be insert!");
             }
            // cmd.ExecuteNonQuery();
            */
            cmd.ExecuteNonQuery();
           con.Close();





            //move from one page to another
            welcomepage wp = new welcomepage();
            wp.Show();
       




        }

        private void txtfname_TextChanged(object sender, EventArgs e)
        {
           /* if(string.IsNullOrEmpty(txtfname.Text)==true)
            {
                txtfname.Focus();//it will remain in this field until it would be filled
                
                errorProvider1.SetError(this.txtfname, "plaese enter first name");

            }
            else
            {
                errorProvider1.Clear();
            }*/
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
           /* if(Regex.IsMatch(txtemail.Text,pattern)==false)
             {
                 txtemail.Focus();
                 errorProvider4.SetError(this.txtemail, "email must contain @ . symbol");

             }
             else
             {
                 errorProvider4.Clear();
             }*/

            
  

        }

        private void display_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update  register set firstname=@firstname, middlename=@middlename, lastname=@lastname, password=@password,email=@email,phonenumber=@phonenumber,landlinenumber=@landlinenumber where id=@id ", con);
            cmd.Parameters.Add("@firstname", txtfname.Text);
            cmd.Parameters.Add("@middlename", txtmname.Text);
            cmd.Parameters.Add("@lastname", txtlname.Text);
            cmd.Parameters.Add("@password", txtpassword.Text);
            cmd.Parameters.Add("@email", txtemail.Text);
            cmd.Parameters.Add("@phonenumber", Convert.ToInt64(txtphone.Text));
            cmd.Parameters.Add("@landlinenumber", txtland.Text);
            cmd.Parameters.Add("@id", Convert.ToInt32(txtid.Text));

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully");

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            /*  con.Open();
              SqlCommand cmd = new SqlCommand("delete  register where id=@id", con);
              //delete all record
              //cmd = new SqlCommand("delete from register");
              cmd.Parameters.Add("@id", Convert.ToInt32(txtid.Text));

              cmd.ExecuteNonQuery();
              con.Close();
              MessageBox.Show("successfully deleted");*/

            int sid = Convert.ToInt32(txtdelete.Text);

            con.Open();
            SqlCommand cmd = new SqlCommand("delete  register where id=@id", con);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = sid;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully deleted");


        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            /* con.Open();
             SqlCommand cmd = new SqlCommand("select * from register", con);
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             DataTable dt = new DataTable();
             da.Fill(dt);
             dataGridView1.DataSource = dt;





             cmd.ExecuteNonQuery();
             con.Close();*/

            //this is to show data based on hid id

            int searchid = Convert.ToInt32(txtsearch.Text);

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM register where id=@id",con);

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = searchid;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();



        }

        private void txtland_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
          /*  if(Regex.IsMatch(txtpassword.Text,pp)==false)
            {
                txtpassword.Focus();
                errorProvider3.SetError(this.txtpassword, "must contain ");
            }
      
            else
            {
                errorProvider3.Clear();
            }
           */




        }
    }
}
