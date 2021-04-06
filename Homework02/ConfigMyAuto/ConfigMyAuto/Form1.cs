using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigMyAuto
{
    public partial class MainPage : Form
    {
        double basePrice = 7800;
        public MainPage()
        {
            InitializeComponent();
        }

        private void rbBmw_CheckedChanged(object sender, EventArgs e)
        {
            basePrice = 7800;
            panelTotalSum.Hide();
            picAllCars.Image = Properties.Resources.FirstCarBmw;
            lblYear.Text = "Year: 2018";
            lblCondition.Text = "Condition: Used";
            lblKilometersDriven.Text = "Kilometers Driven: 76 435 km";
            lblBasePrice.Text = "Base Price = 7,800$";
        }

        private void rbMercedes_CheckedChanged(object sender, EventArgs e)
        {
            basePrice = 30500;

            //Hiding panel with the total sum if user tried to purchase a car earlier.
            panelTotalSum.Hide();

            //Changing info and picture of car.
            picAllCars.Image = Properties.Resources.SecondCarAudi_1;
            lblYear.Text = "Year: 2015";
            lblCondition.Text = "Condition: New";
            lblKilometersDriven.Text = "Kilometers Driven: 0 km";
            lblBasePrice.Text = "Base Price = 30,500$";

            //Uncheking additional features in case they were selected in previous purchase.
            uncheckFeatures();
        }

        private void rbAudi_CheckedChanged(object sender, EventArgs e)
        {
            basePrice = 13200;
            panelTotalSum.Hide();
            picAllCars.Image = Properties.Resources.ThirdCarMercedes;
            lblYear.Text = "Year: 2016";
            lblCondition.Text = "Condition: Used";
            lblKilometersDriven.Text = "Kilometers Driven: 150 300 km";
            lblBasePrice.Text = "Base Price = 13,200$";
            uncheckFeatures();
        }

        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            lblSavedMoney.Hide();
            //Validating that the user has selected a payment method.
            if (!rbCheck.Checked && !rbInCash.Checked && !rbCreditCard.Checked)
            {
                MessageBox.Show("You must select a payment method!",
                    "Select payment method", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            bool threeFeaturesChecked = false;
            double totalSum = basePrice;
            bool haveSavedMoney = false;
            double savedMoney = 0;

            //Checking wether all features are selected.
            if (cbFogLights.Checked && cbChains.Checked && cbAbsOption.Checked)
            {
                threeFeaturesChecked = true;
                haveSavedMoney = true;
                savedMoney = 0.1 * 65;
                totalSum = basePrice + 65 - savedMoney;

            }

            //Checking which additional features are selected.
            if (!threeFeaturesChecked)
            {
                if (cbAbsOption.Checked)
                {
                    totalSum += 30;
                }
                if (cbChains.Checked)
                {
                    totalSum += 20;
                }
                if (cbFogLights.Checked)
                {
                    totalSum += 15;
                }
            }


            //Checking wether the user selected to pay in cash.
            if (rbInCash.Checked)
            {
                haveSavedMoney = true;
                savedMoney += 0.05 * totalSum;
                totalSum -= 0.05 * totalSum;
            }
            panelTotalSum.Show();
            lblTotal.Text = String.Format("Your total is: {0:0.##}$", totalSum);

            //Checking if the user has saved any money.
            if (haveSavedMoney)
            {

                lblSavedMoney.Text = String.Format("You saved: {0:0.##}$", savedMoney);
                lblSavedMoney.Show();
            }
        }

        private void uncheckFeatures()
        {
            cbAbsOption.Checked = false;
            cbChains.Checked = false;
            cbFogLights.Checked = false;

            rbCreditCard.Checked = false;
            rbInCash.Checked = false;
            rbCheck.Checked = false;
        }
    }
}

