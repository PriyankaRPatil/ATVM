using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATVM
{
    public partial class ChooseDestination : Form
    {
        static float balance = 100;
        static float price;

        public ChooseDestination()
        {
            InitializeComponent();
            lblDestination.Text = " - ";
            lblPrice.Text = price.ToString();
            lblAccountBalance.Text = balance.ToString();

            rbVashi.Checked = false;
            rbAmbernath.Checked = false;
            rbAndheri.Checked = false;
            rbBandra.Checked = false;
            rbBelapur.Checked = false;
            rbBhayandar.Checked = false;
            rbBorivali.Checked = false;
            rbChurchgate.Checked = false;
            rbDadar.Checked = false;
            rbDahanuRoad.Checked = false;
            rbDombivli.Checked = false;
            rbGhatkopar.Checked = false;
            rbKalyan.Checked = false;
            rbKurla.Checked = false;
            rbMakhurd.Checked = false;
            rbMumbaiCentral.Checked = false;
            rbMumbaiCST.Checked = false;
            rbThane.Checked = false;
            rbTitwala.Checked = false;
            rbVasaiRoad.Checked = false;
            rbVirar.Checked = false;
        }

        private void ChooseDestination_Load(object sender, EventArgs e)
        {
         }

        private void button1_Click(object sender, EventArgs e)
        {
            if (price == 0) {
                MessageBox.Show("Please select a destination!","No Destination Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (balance >= price)
            {
                balance -= price;
                lblAccountBalance.Text = balance.ToString();
                MessageBox.Show("Please Collect Your Ticket!");
            }
            else
            {
                MessageBox.Show("You have insufficient balance to proceed further","Low on Balance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rbVashi_CheckedChanged(object sender, EventArgs e)
        {
            lblDestination.Text = "Vashi";
            price = 20;
            lblPrice.Text = price.ToString();
        }

        private void rbBelapur_CheckedChanged(object sender, EventArgs e)
        {
            lblDestination.Text = "Belapur";
            price = 15;
            lblPrice.Text = price.ToString();
        }

        private void rbMakhurd_CheckedChanged(object sender, EventArgs e)
        {
            lblDestination.Text = "Mankhurd";
            price = 22;
            lblPrice.Text = price.ToString();
        }

        private void rbKurla_CheckedChanged(object sender, EventArgs e)
        {
            lblDestination.Text = "Kurla";
            price = 23;
            lblPrice.Text = price.ToString();
        }

        private void rbMumbaiCST_CheckedChanged(object sender, EventArgs e)
        {
            lblDestination.Text = "MumbaiCST";
            price = 30;
            lblPrice.Text = price.ToString();
        }

        private void rbGhatkopar_CheckedChanged(object sender, EventArgs e)
        {
            lblDestination.Text = "Ghatkopar";
            price = 24;
            lblPrice.Text = price.ToString();
        }

        private void rbThane_CheckedChanged(object sender, EventArgs e)
        {
            lblDestination.Text = "Thane";
            price = 25;
            lblPrice.Text = price.ToString();
        }

        private void rbDombivli_CheckedChanged(object sender, EventArgs e)
        {
            lblDestination.Text = "Dombivli";
            price = 27;
            lblPrice.Text = price.ToString();
        }

        private void rbKalyan_CheckedChanged(object sender, EventArgs e)
        {
            lblDestination.Text = "Kalyan";
            price = 28;
            lblPrice.Text = price.ToString();
        }

        private void rbAmbernath_CheckedChanged(object sender, EventArgs e)
        {
            lblDestination.Text = "Ambernath";
            price = 30;
            lblPrice.Text = price.ToString();
        }

        private void rbTitwala_CheckedChanged(object sender, EventArgs e)
        {
            lblDestination.Text = "Titwala";
            price = 30;
            lblPrice.Text = price.ToString();
        }

        private void rbDadar_CheckedChanged(object sender, EventArgs e)
        {
            lblDestination.Text = "Dadar";
            price = 25;
            lblPrice.Text = price.ToString();
        }

        private void rbMumbaiCentral_CheckedChanged(object sender, EventArgs e)
        {
            lblDestination.Text = "Mumbai Central";
            price = 34;
            lblPrice.Text = price.ToString();
        }

        private void rbChurchgate_CheckedChanged(object sender, EventArgs e)
        {
            lblDestination.Text = "Churchgate";
            price = 35;
            lblPrice.Text = price.ToString();
        }

        private void rbBandra_CheckedChanged(object sender, EventArgs e)
        {
            lblDestination.Text = "Bandra";
            price = 28;
            lblPrice.Text = price.ToString();
        }

        private void rbAndheri_CheckedChanged(object sender, EventArgs e)
        {
            lblDestination.Text = "Andheri";
            price = 28;
            lblPrice.Text = price.ToString();
        }

        private void rbBorivali_CheckedChanged(object sender, EventArgs e)
        {
            lblDestination.Text = "Borivali";
            price = 29;
            lblPrice.Text = price.ToString();
        }

        private void rbBhayandar_CheckedChanged(object sender, EventArgs e)
        {
            lblDestination.Text = "Bhayandar";
            price = 30;
            lblPrice.Text = price.ToString();
        }

        private void rbVasaiRoad_CheckedChanged(object sender, EventArgs e)
        {
            lblDestination.Text = "Vasai Road";
            price = 30;
            lblPrice.Text = price.ToString();
        }

        private void rbVirar_CheckedChanged(object sender, EventArgs e)
        {
            lblDestination.Text = "Virar";
            price = 32;
            lblPrice.Text = price.ToString();
        }

        private void rbDahanuRoad_CheckedChanged(object sender, EventArgs e)
        {
            lblDestination.Text = "Dahanu Road";
            price = 35;
            lblPrice.Text = price.ToString();
        }
    }
}
