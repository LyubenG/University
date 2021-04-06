using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnterData_Click(object sender, EventArgs e)
        {
            //Checking if both textboxes are filled in
            if (tbNameAuthor.Text == "" || tbBookName.Text == "")
            {
                MessageBox.Show("You must enter name of the  book and author!", "Error");
                return;
            }

            //Getting the name of author and book and then making it one string.
            string bookName = tbBookName.Text;
            string authorName = tbNameAuthor.Text;

            string both = String.Format("{0} - {1}", bookName, authorName);
            //Checking if the book is already added
            if (lbBooks.Items.Contains(both))
            {
                MessageBox.Show("Book already added!", "Book added");
                return;
            }
            //Adding it to the library then clearing the textboxes.
            lbBooks.Items.Add(both);
            tbBookName.Clear();
            tbNameAuthor.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Showing textboxes and labels for searching
            lblAuthorSearch.Show();
            lblNameToSearch.Show();
            tbAuthorSearch.Show();
            tbSearchName.Show();
            btnSearchNow.Show();

            //Disabling other options till this one is done
            btnEdit.Enabled = false;
            btnRemove.Enabled = false;
            btnSort.Enabled = false;
        }

        private void btnSearchNow_Click(object sender, EventArgs e)
        {
            //Checking if both textboxes are filled in
            bool foundElement = false;
            if (tbAuthorSearch.Text == "" || tbSearchName.Text == "")
            {
                MessageBox.Show("You must enter name of the  book and author!", "Error");
                return;
            }
            string bookName = tbBookName.Text;
            string authorName = tbNameAuthor.Text;
            string both = String.Format("{0} - {1}", bookName, authorName);

            //Going through all books.
            for (int i = 0; i < lbBooks.Items.Count; i++)
            {
                if (lbBooks.Items[i].Equals(both))
                {
                    //If there is a match, we save the index.
                    int index = i;
                    MessageBox.Show(String.Format("The library found the book you were looking for! It's on {0} index", index + 1)
                        , "Found element");
                    lbBooks.SelectedIndex = index;
                    foundElement = true;
                    break;
                }
            }

            //If the book and author were not found.
            if (!foundElement)
            {
                MessageBox.Show("The library did not find the book you were looking for!", "Haven't found element");
            }

            //Hiding searching textboxes and labels.
            lblAuthorSearch.Hide();
            lblNameToSearch.Hide();
            tbAuthorSearch.Hide();
            tbSearchName.Hide();
            btnSearchNow.Hide();

            //Enabling other options
            btnEdit.Enabled = true;
            btnRemove.Enabled = true;
            btnSort.Enabled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            var selectedItems = lbBooks.SelectedItems;
            //Checking if there is a selected item.
            if (lbBooks.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select a element!", "Error");
                return;
            }

            for (int i = selectedItems.Count - 1; i >= 0; i--)
            {
                lbBooks.Items.Remove(selectedItems[i]);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            //Sorting items.
            if (lbBooks.Sorted)
            {
                MessageBox.Show("Books were already sorted!", "Already sorted!");
                return;
            }
            lbBooks.Sorted = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Checking if there is a selected item.
            if (lbBooks.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select a first element!", "Error");
                return;
            }
            //Getting old name of book and author then splitting by - 
            int selectedItem = lbBooks.SelectedIndex;
            string both = lbBooks.GetItemText(lbBooks.Items[selectedItem]);
            string[] array = both.Split('-');
            string oldName = array[0];
            string oldAuthor = array[1];
            tbAuthorEdit.Text = oldAuthor;
            tbNameEdit.Text = oldName;

            //Showing edit textboxes and labels.
            lblEditAuthor.Show();
            lblEditName.Show();
            tbAuthorEdit.Show();
            tbNameEdit.Show();
            btnEditNow.Show();

            btnSearch.Enabled = false;
            btnRemove.Enabled = false;
            btnSort.Enabled = false;
 
    }

        private void btnEditNow_Click(object sender, EventArgs e)
        {
            int selectedItem = lbBooks.SelectedIndex;
            string newName = tbNameEdit.Text;
            string newAuthor = tbAuthorEdit.Text;
            string both = String.Format("{0} - {1}", newName, newAuthor);

            if (tbNameEdit.Text == "" || tbNameAuthor.Text == "")

            {
                MessageBox.Show("You must enter book author and book name", "Error!");
                return;
            }

            lbBooks.Items[selectedItem] = both;
            MessageBox.Show("The book and author has been edited!", "Edit done");
            lblEditAuthor.Hide();
            lblEditName.Hide();
            tbAuthorEdit.Hide();
            tbNameEdit.Hide();
            btnEditNow.Hide();

            btnSearch.Enabled = true;
            btnRemove.Enabled = true;
            btnSort.Enabled = true;
        }
    }
}
