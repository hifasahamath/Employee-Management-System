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
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }




        Client client = new Client();



        private void FrmClient_Load(object sender, EventArgs e)
        {

            ControlBox = false;



            client.ClientTable = dataGridView1;
            client.DisplayDetails();







            








        }

        private void btnInsert_Click(object sender, EventArgs e)
        {


            if (txtClientID.Text == "" || txtName.Text == "" || txtEmail.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Empty Fields, Please fill the data");
            }
            else
            {
                client.ClientID = txtClientID.Text;
                client.Name = txtName.Text;
                client.Email = txtEmail.Text;
                client.Address = txtAddress.Text;
                client.InsertDetails();
            }













        }

        private void btnClear_Click(object sender, EventArgs e)
        {




            txtClientID.ReadOnly = false;
            txtClientID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




            txtClientID.ReadOnly = true;
            int index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView1.Rows[index];

            txtClientID.Text = selectedrow.Cells[0].Value.ToString();
            txtName.Text = selectedrow.Cells[1].Value.ToString();
            txtEmail.Text = selectedrow.Cells[2].Value.ToString();
            txtAddress.Text = selectedrow.Cells[3].Value.ToString();



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {



            if (txtClientID.Text == "" || txtName.Text == "" || txtEmail.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Empty Fields, Fill the data");
            }
            else
            {
                if (MessageBox.Show("Do You Want To Update?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    client.ClientID = txtClientID.Text;
                    client.Name = txtName.Text;
                    client.Email = txtEmail.Text;
                    client.Address = txtAddress.Text;
                    client.updateDetails();
                }
                else
                {
                    MessageBox.Show("Update Cancelled");
                }








            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {




            if (txtClientID.Text == "" || txtName.Text == "" || txtEmail.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Empty Fields, Fill the data");
            }
            else
            {
                if (MessageBox.Show("Do You Want To Delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    client.ClientID = txtClientID.Text;
                    client.Name = txtName.Text;
                    client.Email = txtEmail.Text;
                    client.Address = txtAddress.Text;
                    client.deleteDetails();
                }
                else
                {
                    MessageBox.Show("Delete Cancelled");
                }








            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {


            this.Close();

            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();






        }



        // SEARCH


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-C45MDGF\\SQLEXPRESS;Initial Catalog=Quiet_Attic_Films;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void btnSearch_Click(object sender, EventArgs e)
        {



            SqlCommand cmd = new SqlCommand("SELECT * FROM Client WHERE ClientID = '"+ txtClientID.Text +"'", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;


         




        }
    }
}
