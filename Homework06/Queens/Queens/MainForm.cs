using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queens
{
    public partial class MainForm : Form
    {
        bool admin = false;
        readonly string filePath = "fortunes.txt";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Making width smaller so the ListBox is not visible.
            this.Width = 500;
            lblFortune.Parent = pbFortune;
            lblFortune.BackColor = Color.Transparent;

            updateListBox();
        }

        private void updateListBox()
        {
            //Method used for updating the listbox with fortunes.
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                if (!lbFortunes.Items.Contains(line))
                {
                    lbFortunes.Items.Add(String.Format(line));
                }
            }
        }

        private void tbAddFortune_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Adding fortune whenever enter is pressed.
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                tbAddFortune.Hide();
                lblAdd.Hide();

                using (FileStream fs = new FileStream(filePath, FileMode.Append))
                {
                    using (StreamWriter writer = new StreamWriter(fs))
                    {
                        writer.WriteLine(String.Format("\"{0}\"", tbAddFortune.Text));
                    }
                }
                updateListBox();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Showing textbox and label for adding fortunes.
            tbAddFortune.Show();
            lblAdd.Show();
        }

        private void btnGetFortune_Click(object sender, EventArgs e)
        {
            //Generating random number and picking a random fortune according to the number picked.
            string[] lines = File.ReadAllLines(filePath);
            Random rnd = new Random();
            int randomLineNumber = rnd.Next(0, lines.Length);
            string line = lines[randomLineNumber];

            lblFortune.Text = line;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Removing a fortune from the listbox and the text document.
            int selectedIndex = lbFortunes.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Select a fortune to be deleted and click again!");
                return;
            }
            lbFortunes.Items.RemoveAt(selectedIndex);
            string[] arrLine = new string[lbFortunes.Items.Count];
            for (int i = 0; i < lbFortunes.Items.Count; i++)
            {
                arrLine[i] = lbFortunes.GetItemText(lbFortunes.Items[i]);
            }
            //Rewriting the textdocument without the removed element.
            File.WriteAllLines(filePath, arrLine);

            this.Width = 860;

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //Checking whether the admin panel is showed already or not.
            if (admin)
            {
                admin = false;
                btnRemove.Enabled = false;
                btnChange.Enabled = false;
                this.Width = 500;
            }
            else
            {
                admin = true;
                btnRemove.Enabled = true;
                btnChange.Enabled = true;
                this.Width = 860;
            }

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbFortunes.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Select a fortune to be changed and click again!");
                return;
            }
            //Getting the selected element and removing the "" for easier user experience.
            tbEdit.Text = lbFortunes.GetItemText(lbFortunes.SelectedItem).Replace("\"","");
            lblEdit.Show();
            tbEdit.Show();
        }

        private void tbEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Editing element
            int selectedIndex = lbFortunes.SelectedIndex;
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                lbFortunes.Items[selectedIndex] = String.Format("\"{0}\"",tbEdit.Text);
                string[] arrLine = File.ReadAllLines(filePath);
                arrLine[selectedIndex] = String.Format("\"{0}\"", tbEdit.Text);
                File.WriteAllLines(filePath, arrLine);
                tbEdit.Hide();
                tbEdit.Clear();
                lblEdit.Hide(); 
                }
        }
    }
}
