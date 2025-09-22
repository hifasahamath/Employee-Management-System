using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Quiet_Attic_Films
{
    internal class UserSignupClass
    {


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-C45MDGF\\SQLEXPRESS;Initial Catalog=Quiet_Attic_Films;Integrated Security=True;TrustServerCertificate=True");

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }






        public void SignupInsertDetails()
        {
            try
            {
                con.Open();
                string query = "INSERT INTO User_Details (FirstName, LastName, Email, Username, Password) values('" + FirstName + "','" + LastName + "','" + Email + "','" + Username + "', '" + Password + "')";
                SqlCommand CMB = new SqlCommand(query, con);
                int affectedrows = CMB.ExecuteNonQuery();
                if (affectedrows > 0)
                {
                    MessageBox.Show("Signup Successful! Please Login");

                }
                else
                {
                    MessageBox.Show("Empty Fields, Please fill the data");
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
}
