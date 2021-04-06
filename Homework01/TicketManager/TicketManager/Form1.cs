using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketManager
{
    public partial class MainPage : Form
    {
        string kindOfTickets = "";
        int pricePerTicket = 0;
        double totalSum = 0;
        bool validInput = true;

        public MainPage()
        {
            InitializeComponent();
            DateTime dateTime = DateTime.UtcNow.Date;
            lblDate.Text = dateTime.ToString("d");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_MouseHover(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("About page is under maintance!");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculatePirce_Click(object sender, EventArgs e)
        {
            ValidateIsNotEmpty();
            ValidateHasOnlyNumbers();
            CheckPrice();
            lblSum.Text = String.Format("Your total sum is: {0}$", totalSum);
        }

        private void ValidateIsNotEmpty()
        {
            if (txtFieldAmountTickets.Text.Trim() == "")
            {
                MessageBox.Show("You should enter a value!");
                validInput = false;
            }
        }
        
        private void ValidateHasOnlyNumbers()
        {
            Regex regex = new Regex("^[0-9]+$");
            bool hasOnlyNumbers = regex.IsMatch(txtFieldAmountTickets.Text);
            if (!hasOnlyNumbers)
            {
                MessageBox.Show("Field accepts only numbers!");
                validInput = false;
                txtFieldAmountTickets.Clear();
            }
        }

        private void CheckPrice()
        {
            if (validInput)
            {
                string theText = txtFieldAmountTickets.Text;
                int numberOfTickets = int.Parse(theText);

                if (radioChild.Checked)
                {
                    kindOfTickets = "Ticket For Children";
                    pricePerTicket = 3;
                }
                else if (radioStudent.Checked)
                {
                    kindOfTickets = "Ticket For University Students";
                    pricePerTicket = 5;
                }
                else if (radioSchoolStudent.Checked)

                {
                    kindOfTickets = "Ticket For School Students";
                    pricePerTicket = 4;
                }

                totalSum = pricePerTicket * numberOfTickets;
            }
        }
    }
}
