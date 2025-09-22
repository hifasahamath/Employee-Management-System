using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Quiet_Attic_Films
{
    public partial class FrmSignup : Form
    {
        public FrmSignup()
        {
            InitializeComponent();
        }

        UserSignupClass usersignup = new UserSignupClass();






        private void btnSignUp_Click(object sender, EventArgs e)
        {




           




            if (txtFName.Text == "" || txtLName.Text == "" || txtEmail.Text == "" || txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Empty Fields, Please fill the data");
            }


            else
            {
                usersignup.FirstName = txtFName.Text;
                usersignup.LastName = txtLName.Text;
                usersignup.Email = txtEmail.Text;
                usersignup.Username = txtUsername.Text;
                usersignup.Password = txtPassword.Text;
                usersignup.SignupInsertDetails();
            }









        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            FrmLogin loginForm = new FrmLogin();
            loginForm.Show();
            this.Hide();





        }

        private void FrmSignup_Load(object sender, EventArgs e)
        {


            ControlBox = false;



        }
    }
}
