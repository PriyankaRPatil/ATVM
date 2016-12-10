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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbCard.Text == "1010101010")
            {
                this.Hide();
                ChooseDestination cd = new ChooseDestination();
                MessageBox.Show("Welcome to ATVM : Mumbai Local Trains!", "Welcome",MessageBoxButtons.OK,MessageBoxIcon.Information);
                cd.Show();
            }
            else
            {
                MessageBox.Show("You have entered an invalid card number!","",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
