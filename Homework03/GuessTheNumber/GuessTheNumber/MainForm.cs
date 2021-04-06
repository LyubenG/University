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

namespace GuessTheNumber
{
    public partial class MainForm : Form
    {
        int randomNumber = 0;
        int totalTries = 0;
        bool validInput = true;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStart_MouseDown(object sender, MouseEventArgs e)
        {
            btnStart.BackgroundImage = Properties.Resources.ButtonPlayHover1;
        }

        private void btnStart_MouseUp(object sender, MouseEventArgs e)
        {
            btnStart.BackgroundImage = Properties.Resources.PlayButton;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Generating a random number depending on the difficulty level;
            Random rnd = new Random();
            if (cbDifficulty.SelectedIndex == 0)
            {
                randomNumber = rnd.Next(1, 11);
            }
            else if (cbDifficulty.SelectedIndex == 1)
            {
                randomNumber = rnd.Next(1, 51);
            }
            else if (cbDifficulty.SelectedIndex == 2)
            {
                randomNumber = rnd.Next(1, 101);
            }
            else if (cbDifficulty.SelectedIndex == 3)
            {
                randomNumber = rnd.Next(1, 1001);
            }
            else
            {
                MessageBox.Show("You must select a difficulty!");
                return;
            }
            //Enabling / (starting the game) since the user has chosen a difficulty.
            lblGenerated.Show();
            tbNumberGuess.Enabled = true;
            btnCheck.Enabled = true;
            btnStart.Enabled = false;

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            validInput = validateUserInput();

            //Changing the picture telling the user if the number he wrote is smaller or bigger.
            if (validInput)
            {
                totalTries++;
                if (int.Parse(tbNumberGuess.Text) > randomNumber)
                {
                    pbThumbs.Image = Properties.Resources.Down1;
                }
                else if (int.Parse(tbNumberGuess.Text) < randomNumber)
                {
                    pbThumbs.Image = Properties.Resources.Up1;
                }
                else if (int.Parse(tbNumberGuess.Text) == randomNumber)
                {
                    //If the user has guess correctly the number;
                    pbThumbs.Image = Properties.Resources.CorrectGuess;
                    btnCheck.Enabled = false;
                    MessageBox.Show(String.Format("Congratulations, you have won in {0} tries!"
                                                            , totalTries), "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    tbNumberGuess.Clear();
                    cbDifficulty.SelectedIndex = default;
                    return;
                }
                lblTriesLeft.Text = String.Format("You have {0} tries left!", 10 - totalTries);

                //Check if the user has tried 10 times.
                if (totalTries == 10)
                {
                    pbThumbs.Image = Properties.Resources.Lost;
                    MessageBox.Show("You failed to guess the number in 10 tries! Try again.", "You lost!");
                    btnCheck.Enabled = false;
                    return;
                }
            }
        }

        private void btnReset_MouseDown(object sender, MouseEventArgs e)
        {
            //Button click effects.
            btnReset.BackgroundImage = Properties.Resources.ResetButtonHover;
        }

        private void btnReset_MouseUp(object sender, MouseEventArgs e)
        {
            //Button click effects.
            btnReset.BackgroundImage = Properties.Resources.ResetButton1;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Reseting all buttons, textboxes to their default value;
            lblGenerated.Hide();
            pbThumbs.Image = Properties.Resources.NumberHolder2;
            totalTries = 0;
            lblTriesLeft.Text = "You have 10 tries left!";
            tbNumberGuess.Clear();
            tbNumberGuess.Enabled = false;
            btnCheck.Enabled = false;
            btnStart.Enabled = true;
        }

        private bool validateUserInput()
        {
            //Validating that the user has not entered a wrong input;
            Regex regex = new Regex(@"\D+");
            if (regex.IsMatch(tbNumberGuess.Text))
            {
                MessageBox.Show("You must enter a positive number!", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNumberGuess.Clear();
                return false; ;
            }
            return true;
        }
    }
}
