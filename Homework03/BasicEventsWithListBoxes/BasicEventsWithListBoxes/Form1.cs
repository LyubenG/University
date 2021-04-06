using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicEventsWithListBoxes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Adding items to number listBox
            for (int i = 0; i < 10; i++)
            {
                lbNumbers.Items.Add(i);
            }
            for (int i = 0; i < 10; i++)
            {
                lbNames.Items.Add("Name" + i);
            }
            //Updating count of numbers
            lblCountNumbers.Text = String.Format("Count numbers: {0}", lbNumbers.Items.Count);
            lblCountNames.Text = String.Format("Count names: {0}", lbNames.Items.Count);
        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            //Getting the count of the selected items.
            int selectedItemsLength = lbNumbers.SelectedItems.Count;
            for (int i = 0; i < selectedItemsLength; i++)
            {
                //Checking if the items has already been added.
                if (!lbThird.Items.Contains(lbNumbers.SelectedItems[i]))
                {
                    lbThird.Items.Add(lbNumbers.SelectedItems[i]);
                }
                else
                {
                    MessageBox.Show("Item is already added!", "Added already");
                    return;
                }
            }
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            //Getting the count of the selected items.
            int selectedItemsLength = lbNames.SelectedItems.Count;
            for (int i = 0; i < selectedItemsLength; i++)
            {
                //Checking if the items has already been added.
                if (!lbThird.Items.Contains(lbNames.SelectedItems[i]))
                {
                    lbThird.Items.Add(lbNames.SelectedItems[i]);
                }
                else
                {
                    MessageBox.Show("Item is already added!", "Added already");
                    return;
                }
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            //Getting the count of the items in the third ListBox
            MessageBox.Show(String.Format("Count of items: {0}", lbThird.Items.Count), "Count");
        }

        private void btnClearItem_Click(object sender, EventArgs e)
        {
            //Clearing the selected item in third ListBox
            var selectedItems = lbThird.SelectedItems;

            for (int i = selectedItems.Count - 1; i >= 0; i--)
            {
                lbThird.Items.Remove(selectedItems[i]);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            //Clearing all items in the third ListBox
            lbThird.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbEnter_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Checking if the user has pressed Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!lbThird.Items.Contains(tbEnter.Text))
                {
                    lbThird.Items.Add(tbEnter.Text);
                    tbEnter.Clear();
                } else
                {
                    //Checking if the items has already been added
                    MessageBox.Show("Item is already added!", "Added already");
                    tbEnter.Clear();
                    return;
                }
            }
        }
    }
}
