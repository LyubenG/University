using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerApp
{
    public partial class MainPage : Form
    {
        int counter = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            counter++;
            updateCounter();
        }

        private void lblClickCounter_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            bool sure = true;
            DialogResult dialog = MessageBox.Show("Are you sure that you want to restart score", "Reset",
                MessageBoxButtons.YesNo);

            if (dialog == DialogResult.No)
            {
                sure = false;
            }
            if (sure)
            {
                counter = 0;
                updateCounter();
            }
        }

        private void updateCounter()
        {
            lblClickCounter.Text = counter.ToString();
        }
    }
}
