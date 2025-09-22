using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiet_Attic_Films
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            this.Close();

            FrmClient frmClient = new FrmClient();
            frmClient.Show();






        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

            ControlBox = false;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            this.Close();

            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();








        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();

            FrmProduction frmProduction = new FrmProduction();
            frmProduction.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();

            FrmLocation frmLocation = new FrmLocation();
            frmLocation.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {


            this.Close();

            FrmStaff frmStaff = new FrmStaff();
            frmStaff.Show();





        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Close();

            FrmStaffType frmStaffType = new FrmStaffType();
            frmStaffType.Show();





        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.Close();

            FrmProperty frmProperty = new FrmProperty();
            frmProperty.Show();



        }

        private void button7_Click(object sender, EventArgs e)
        {


            this.Close();

            FrmPropertyType frmPropertyType = new FrmPropertyType();
            frmPropertyType.Show();






        }

        private void button11_Click(object sender, EventArgs e)
        {


            this.Close();

            FrmLocation_Property frmLocation_Property = new FrmLocation_Property();
            frmLocation_Property.Show();



        }

        private void button9_Click(object sender, EventArgs e)
        {

            this.Close();

            FrmProduction_Location frmProduction_Location = new FrmProduction_Location();
            frmProduction_Location.Show();


        }

        private void button10_Click(object sender, EventArgs e)
        {

            this.Close();

            FrmProduction_Property frmProduction_Property = new FrmProduction_Property();
            frmProduction_Property.Show();


        }

        private void button8_Click(object sender, EventArgs e)
        {

            this.Close();

            FrmProduction_Staff frmProduction_Staff = new FrmProduction_Staff();
            frmProduction_Staff.Show();



        }
    }
}
