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

namespace userlogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //string id = "11";
        //string password = "uiit123";

      
        SqlCommand cmd;
        SqlConnection con=new SqlConnection(@"Data Source=DESKTOP-0J02DHK\SQLEXPRESS01;Initial Catalog=login;Integrated Security=True");


        private void btnlogin_Click(object sender, EventArgs e)
        {
            /*if (txtloginid.Text.Equals(id) && (txtpass.Text.Equals(password)))
            {
                MessageBox.Show("Successfully Login", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                    MessageBox.Show("Login Id And Password are incorrect!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/


            if(string.IsNullOrEmpty(txtloginid.Text.Trim()))
            {
                MessageBox.Show(txtloginid,"login id required!","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtpass.Text.Trim()))
            {
                MessageBox.Show(txtpass, "password required!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            try
            {


                con.Open();
                cmd = new SqlCommand("INSERT INTO userlogin (loginID,loginpassword,studentID,email,status) VALUES (@loginID,@loginpassword,@studentID,@email,@status)", con);
                cmd.Parameters.Add("@loginID",txtloginid.Text);
                cmd.Parameters.Add("@loginpassword",txtpass.Text);
               cmd.Parameters.Add("@studentID",Convert.ToInt16(txtstuid.Text));
                cmd.Parameters.Add("@email",txtemail.Text);
                cmd.Parameters.Add("@status",txtstatus.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully SignUp!!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                   loginpage lp = new loginpage();
                lp.Show();

                    }

               catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtstuid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
