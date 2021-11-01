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
        decimal subtotal;

        List<Tuple<int, string>> productList = new List<Tuple<int, string>>();

        public void numDays_ValueChanged_1(object sender, EventArgs e)
        {

            if (Convert.ToInt32(numDays.Text) < numDays.Value)
            { /*The up arrow was pressed (Value Increased)*/
                subtotal = subtotal + 20;
                productList.Add(new Tuple<int, string>(Convert.ToInt32(numDays.Value), "Dagen"));
            }
            else
            {/*Down Arrow Pressed (Value Decreaseed)*/
                subtotal = subtotal - 20;
            }

            RefreshLabels();

        }

        private void numHelmet_ValueChanged(object sender, EventArgs e)
        {

            if (Convert.ToInt32(numHelmet.Text) < numHelmet.Value)
            { /*The up arrow was pressed (Value Increased)*/
                subtotal = subtotal + 20;
                productList.Add(new Tuple<int, string>(1, "Helmen"));
            }
            else
            {/*Down Arrow Pressed (Value Decreaseed)*/
                subtotal = subtotal - 20;
            }

            RefreshLabels();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            productList.Add(new Tuple<int, string>(1, "Bescherming"));

            if (Convert.ToInt32(numericUpDown1.Text) < numericUpDown1.Value)
            { /*The up arrow was pressed (Value Increased)*/
                subtotal = subtotal + 20;
                productList.Add(new Tuple<int, string>(1, "Helmen"));
            }
            else
            {/*Down Arrow Pressed (Value Decreaseed)*/
                subtotal = subtotal - 20;
            }

            RefreshLabels();
        }

        private void chkRainroof_CheckedChanged(object sender, EventArgs e)
        {
            bool rainroof = chkRainroof.Checked;

            if(rainroof == true)
            {
                productList.Add(new Tuple<int, string>(1, "Regendak"));
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
                    productList.Add(new Tuple<int, string>(1, "Bakfiets 1"));
                    subtotal = subtotal + 100;
                    break;
                case "Bakfiets 2":
                    productList.Add(new Tuple<int, string>(1, "Bakfiets 2"));
                    subtotal = subtotal + 150;
                    break;
                case "Bakfiets 3":
                    productList.Add(new Tuple<int, string>(1, "Bakfiets 3"));
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

            DataGrid();
        }

        private void DataGrid()
        {
            // This clear works in a certain way. But not in the way i wanted :c
            overviewPriceList.Rows.Clear();

            // This foreach loop is to show all the selected items
            foreach (var item in productList)
            {
                DataGridViewRow row = (DataGridViewRow)overviewPriceList.Rows[0].Clone();
                for (int i = 0; i < overviewPriceList.RowCount - 1; i++)
                {
                    if (overviewPriceList.Rows[i].Cells[0].Value.ToString() == item.Item2)
                    {
                        row.Cells[1].Value = item.Item1;
                    } else
                    {
                        row.Cells[1].Value = item.Item1;
                        row.Cells[0].Value = item.Item2;
                    }
                }

                overviewPriceList.Rows.Add(row);
            }
        }
    }
}
