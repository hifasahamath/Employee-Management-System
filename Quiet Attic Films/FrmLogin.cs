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

namespace Quiet_Attic_Films
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-C45MDGF\\SQLEXPRESS;Initial Catalog=Quiet_Attic_Films;Integrated Security=True;TrustServerCertificate=True");


        private void btnLoginFormLogin_Click(object sender, EventArgs e)
        {




            if (txtUser.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Empty Fields");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM User_Details WHERE Username = '" + txtUser.Text + "' AND Password = '" + txtPassword.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    dt.Clear();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        MessageBox.Show("Login Success", "Login Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmMenu frmMenu = new FrmMenu();
                        frmMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }









            }

          
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {

            FrmSignup SignupFrm = new FrmSignup();
            SignupFrm.Show();
            this.Hide();



        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {


            ControlBox = false;


        }
    }
}
