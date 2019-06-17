using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace change_learn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int nrTwoonies, nrLoonies, nrQuarters, nrDimes, nrNickels;

            double money;
            int cents;

            money = Convert.ToDouble(txtMoney.Text);
            cents = (int)(money * 100);

            switch(cents %5)
            {
                case 1:
                    cents -= 1;
                    break;
                case 2:
                    cents -= 2;
                    break;
                case 3:
                    cents += 2;
                    break;
                case 4:
                    cents += 1;
                    break;
            }
            lblCents.Text = cents.ToString();

            nrTwoonies = cents / 200;
            cents = cents % 200;
            nrLoonies = cents / 100;
            cents = cents % 100;
            nrQuarters = cents / 25;
            cents = cents % 25;
            nrDimes = cents / 10;
            nrNickels = cents % 10;

            lblTwoonies.Text = nrTwoonies.ToString();
            lblLoonies.Text = nrLoonies.ToString();
            lblQuarters.Text = nrQuarters.ToString();
            lblDimes.Text = nrDimes.ToString();
            lblNickels.Text = nrNickels.ToString();
          

        }
    }
}
