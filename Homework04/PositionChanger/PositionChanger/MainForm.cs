using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PositionChanger
{
    public partial class MainForm : Form
    {
        bool validInput = false;
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Adding random chars to the listbox.
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                lbElements.Items.Add((char)rnd.Next(64, 91));
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Made a button for exiting the program because default ones are ugly. 
            Application.Exit();
        }

        private void tbAddElement_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Checking if the user has pressed enter & if the input is not already in the collection.
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                string elementToBeAdded = tbAddElement.Text;
                if (!lbElements.Items.Contains(elementToBeAdded))
                {
                    lbElements.Items.Add(elementToBeAdded);
                }
                tbAddElement.Clear();
            }
        }

        private void btnBottom_Click(object sender, EventArgs e)
        {
            //Validating that the user has selected a element from the ListBox then moving them around.
            validInput = hasUserSelected();
            if (validInput)
            {
                int lastIndex = lbElements.Items.Count;
                moveItem(lastIndex - 1);
            }
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            //Validating that the user has selected a element from the ListBox then moving them around.
            validInput = hasUserSelected();
            if (validInput)
            {
                moveItem(0);
            }
        }

        private void btnOneUp_Click(object sender, EventArgs e)
        {
            //Validating that the user has selected a element from the ListBox then moving them around.
            validInput = hasUserSelected();
            if (validInput)
            {
                int indexOfSelected = lbElements.SelectedIndex;
                if (indexOfSelected == 0)
                {
                    MessageBox.Show("You have selected the top item. It can't go any further.", "Error");
                    return;
                }
                moveItem(indexOfSelected - 1);
            }
        }

        private void btnOneDown_Click(object sender, EventArgs e)
        {
            //Validating that the user has selected a element from the ListBox then moving them around.
            validInput = hasUserSelected();
            if (validInput)
            {
                int indexOfSelected = lbElements.SelectedIndex;
                if (indexOfSelected == lbElements.Items.Count - 1)
                {
                    MessageBox.Show("You have selected the bottom item. It can't go any further.", "Error");
                    return;
                }
                moveItem(indexOfSelected + 1);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Removing Selected Item
            lbElements.Items.Remove(lbElements.SelectedItem);
        }

        private bool hasUserSelected()
        {
            //Checks if the user has selected a element from the ListBox.
            if (lbElements.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a element from the ListBox!", "Error");
                return false;
            }
            return true;
        }

        private void moveItem(int index)
        {
            //Method used for moving items;
            int indexOfSelected = lbElements.SelectedIndex;
            string toBeSaved = lbElements.SelectedItem.ToString();

            lbElements.Items[indexOfSelected] = lbElements.Items[index];
            lbElements.Items[index] = toBeSaved;
            lbElements.SelectedIndex = -1;
        }
    }
}
