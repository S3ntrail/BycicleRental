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

        public Form1()
        {
            InitializeComponent();
        }

        // Global variable
        decimal price, subtotal;

        public void numDays_ValueChanged(object sender, EventArgs e)
        {

            subtotal = subtotal + 20;

            RefreshLabels();

        }

        private void numHelmet_ValueChanged(object sender, EventArgs e)
        {
            subtotal = subtotal + 5;

            RefreshLabels();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            subtotal = subtotal + 5;

            RefreshLabels();
        }

        private void chkRainroof_CheckedChanged(object sender, EventArgs e)
        {
            bool rainroof = chkRainroof.Checked;

            if(rainroof == true)
            {
                subtotal = subtotal + 5;
            } else
            {
                subtotal = subtotal - 5;
            }

            RefreshLabels();
        }

        private void listBycicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBycicle.SelectedItem.ToString();

            switch(selectedItem)
            {
                case "Bakfiets 1":
                    subtotal = subtotal + 100;
                    break;
                case "Bakfiets 2":
                    subtotal = subtotal + 150;
                    break;
                case "Bakfiets 3":
                    subtotal = subtotal + 250;
                    break;

            }

            RefreshLabels();

        }

        // This event handler refreshes everytime its being called upon
        private void RefreshLabels()
        {
            lblSubtotal.Text = subtotal.ToString();

            taxOutcome.Text = Convert.ToString(subtotal / 100 * 21);

            totalPrice.Text = Convert.ToString(subtotal + (subtotal / 100 * 21));
        }
    }
}
