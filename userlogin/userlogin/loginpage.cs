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
    public partial class loginpage : Form
    {
        public loginpage()
        {
            InitializeComponent();
        }


        SqlCommand cmd;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0J02DHK\SQLEXPRESS01;Initial Catalog=login;Integrated Security=True");



        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {

                
                cmd = new SqlCommand("SELECT * from userlogin where loginID ='"+txtid.Text+ "' and  loginpassword='"+txtpassword.Text+"' ", con);
                con.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if(dr.HasRows==true)
                {
                    MessageBox.Show("Already Exists!!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    homepage hp = new homepage();
                    hp.Show();
                }

                else
                {

                    MessageBox.Show("not Exists!!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();
               


            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }


        }
    }
}
