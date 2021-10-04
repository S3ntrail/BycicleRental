using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakfietsenHuren
{
    public partial class Form1 : Form
    {

        decimal price = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void ckbBycicleOne_CheckedChanged(object sender, EventArgs e)
        {
            bool checkBox1 = ckbBycicleOne.Checked;

            if(checkBox1 == true)
            {
                decimal price =+100;
            }

        }

        private void numDays_ValueChanged(object sender, EventArgs e)
        {
            int rentalDays = Convert.ToInt32(numDays.Value);

            int rentalPrice = rentalDays * 20;

            decimal price =+ rentalDays;
        }

        private void lblSubtotal_Click(object sender, EventArgs e)
        {
            lblSubtotal.Text = Convert.ToString(price);
        }
    }
}
