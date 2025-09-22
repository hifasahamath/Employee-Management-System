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
    public partial class FrmProduction_Location : Form
    {
        public FrmProduction_Location()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();

            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();




        }
    }
}
