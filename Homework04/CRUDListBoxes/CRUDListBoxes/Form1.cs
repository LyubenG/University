using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDListBoxes
{
    public partial class MainForm : Form
    {
        bool validInput = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Adding 20 elements to the listBox
            for (int i = 1; i < 21; i++)
            {
                lbElements.Items.Add("Element" + i);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string elementToBeAdded = tbAddElement.Text.Trim();
            int countOfItems = lbElements.Items.Count;

            //Checking if the element is already in the listBox or if the text is empty.
            validInput = validateInput(elementToBeAdded);
            if (validInput)
            {
                lbElements.Items.Add(elementToBeAdded);
            }

            tbAddElement.Clear();

        }

        private void btnRemoveElement_Click(object sender, EventArgs e)
        {
            //Clearing the selected item in the ListBox
            var selectedItems = lbElements.SelectedItems;

            if (lbElements.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select a element!", "Error");
                return;
            }

            for (int i = selectedItems.Count - 1; i >= 0; i--)
            {
                lbElements.Items.Remove(selectedItems[i]);
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            //Clearing all items in the ListBox
            lbElements.Items.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Checking if the user has selected element to be edited.
            if (lbElements.SelectedIndex == -1)
            {
                MessageBox.Show("You must select the item you want to be edited!", "Select a item");
                return;
            }

            //Enabling controls to change the element and disabling other buttons while the element is not changed.
            lblChange.Show();
            tbUpdate.Show();
            lblPressEnter.Show();
            enableButtons(false);

        }

        private void tbUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Checking if the user has pressed enter.
            if (e.KeyChar == (char)Keys.Enter)
            {
                int selectedItem = lbElements.SelectedIndex;
                string newElement = tbUpdate.Text.Trim();

                //Validating input
                validInput = validateInput(newElement);
                if (validInput)
                {
                    lbElements.Items[selectedItem] = newElement;
                }

                //Clearing the textbox for next uses and enabling the buttons back.
                tbUpdate.Clear();
                lblChange.Hide();
                tbUpdate.Hide();
                lblPressEnter.Hide();
                enableButtons(true);

            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            //Sorting items.
            if (lbElements.Sorted)
            {
                MessageBox.Show("Elements are already sorted!", "Already Sorted");
                return;
            }
            lbElements.Sorted = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Showing search textbox & labels.
            lblSearch.Show();
            tbSearch.Show();
            lblEnter.Show();
            enableButtons(false);
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool foundElement = false;
            string elementToBeSearched = tbSearch.Text;
            if (e.KeyChar == (char)Keys.Enter)
            {
                //Going through every single element and comparing it to the element that the user searches.
                //Was going to use Contains method but then i would not be able to find the index and select it.
                for (int i = 0; i < lbElements.Items.Count; i++)
                {
                    if (lbElements.Items[i].Equals(elementToBeSearched))
                    {
                        //If there is a match, we save the index.
                        int index = i;
                        MessageBox.Show(String.Format("The listBox Contains the element you were looking for! It's on {0} index", index + 1)
                            , "Found element");
                        lbElements.SelectedIndex = index;
                        foundElement = true;
                        break;
                    }
                }

                if (!foundElement)
                {
                    MessageBox.Show("The listBox does not contain the element you were looking for!", "Haven't found element");
                }

                //Clearing the textbox for next uses and enabling the buttons back.
                lblSearch.Hide();
                tbSearch.Hide();
                lblEnter.Hide();
                tbSearch.Clear();
                enableButtons(true);
            }
        }

        private bool validateInput(string element)
        {
            //Validating user input.
            if (!(element == null || element == "") && !lbElements.Items.Contains(element))
            {
                return true;
            }
            MessageBox.Show("You must enter a item that is not empty or already present in the list.", "Error");
            return false;
        }

        private void enableButtons(bool v)
        {
            //Enabling / Disabling buttons.
            foreach (Control c in Controls)
            {
                if (c is Button)
                {
                    c.Enabled = v;
                }
            }
        }
    }
}