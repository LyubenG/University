using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockScissorsPaper
{
    public partial class MainForm : Form
    {
        string username = "";
        string userChoice = "";
        string computerChoice = "";
        int userWins = 0;
        int computerWins = 0;
        bool wasReseted = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Checking if the user has entered a username
            if (tbUsername.Text.Trim() == "")
            {
                MessageBox.Show("You must enter a username first!", "Username", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Updating username name and enabling picking a 'weapon'
            username = tbUsername.Text.Trim();
            lblUsername.Text = username;
            tbUsername.Enabled = false;
            btnStart.Enabled = false;
            lblWeapon.Show();
            rbPaper.Enabled = true;
            rbRock.Enabled = true;
            rbScissors.Enabled = true;
            lblScore.Show();
        }

        private void rbRock_Click(object sender, EventArgs e)
        {
            pbUserChoice.Image = Properties.Resources.rock;
            userChoice = "Rock";
            generateRandomChoice();
            checkRoundWinner();
            lblScore.Text = String.Format("Score - {0} : {1}", userWins, computerWins);
            checkGameWinner();

        }

        private void rbScissors_Click(object sender, EventArgs e)
        {
            pbUserChoice.Image = Properties.Resources.Scissors1;
            userChoice = "Scissors";
            generateRandomChoice();
            checkRoundWinner();
            lblScore.Text = String.Format("Score - {0} : {1}", userWins, computerWins);
            checkGameWinner();

        }

        private void rbPaper_Click(object sender, EventArgs e)
        {
            pbUserChoice.Image = Properties.Resources.Paper;
            userChoice = "Paper";
            generateRandomChoice();
            checkRoundWinner();
            lblScore.Text = String.Format("Score - {0} : {1}", userWins, computerWins);
            checkGameWinner();
        }

        private void checkGameWinner()
        {
            //Checking if the user ot computer has won
            if (userWins == 5)
            {
                MessageBox.Show("Congratulations! You have won!", "You Won", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                wasReseted = true;
                resetGame();
            }
            else if (computerWins == 5)
            {
                MessageBox.Show("Sadly you have lost, the computer won", "You Lost", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                wasReseted = true;
                resetGame();
            }
        }

        private void checkRoundWinner()
        {
            //Counting wins
            if (userChoice.Equals("Rock") && computerChoice.Equals("Scissors"))
            {
                userWins++;
            }
            else if (userChoice.Equals("Scissors") && computerChoice.Equals("Paper"))
            {
                userWins++;
            }
            else if (userChoice.Equals("Paper") && computerChoice.Equals("Rock"))
            {
                userWins++;
            }
            else if (userChoice.Equals("Scissors") && computerChoice.Equals("Rock"))
            {
                computerWins++;
            }
            else if (userChoice.Equals("Paper") && computerChoice.Equals("Scissors"))
            {
                computerWins++;
            }
            else if (userChoice.Equals("Rock") && computerChoice.Equals("Paper"))
            {
                computerWins++;
            }
        }

        private void generateRandomChoice()
        {
            //Generating a random number and connecting it to computer's choice
            Random rnd = new Random();
            int randomNumer = rnd.Next(1, 4);
            switch (randomNumer)
            {
                case 1:
                    pbComputerChoice.Image = Properties.Resources.Paper;
                    computerChoice = "Paper";
                    break;
                case 2:
                    pbComputerChoice.Image = Properties.Resources.rock2;
                    computerChoice = "Rock";
                    break;
                case 3:
                    pbComputerChoice.Image = Properties.Resources.Scissors1;
                    computerChoice = "Scissors";
                    break;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void resetGame()
        {
            //If the game ended without using the reset button the username is being saved
            //If the game was reseted with the reset button all settings go to the default.
            if (!wasReseted)
            {
                username = "";
                lblUsername.Text = "Your Username";
                tbUsername.Enabled = true;
                tbUsername.Clear();
            }
            btnStart.Enabled = true;
            userWins = 0;
            computerWins = 0;
            pbUserChoice.Image = default;
            pbComputerChoice.Image = default;
            lblScore.Text = String.Format("Score - {0} : {1}", userWins, computerWins);
            rbPaper.Enabled = false;
            rbRock.Enabled = false;
            rbScissors.Enabled = false;
            rbRock.Checked = false;
            rbPaper.Checked = false;
            rbScissors.Checked = false;
            lblWeapon.Hide();
            lblScore.Hide();
            wasReseted = false;
        }
    }
}
