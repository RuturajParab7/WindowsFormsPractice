using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeApplication
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int start;

            if (!int.TryParse(txtStart.Text, out start) || start < 0)
            {
                lblResult.Text = "Please enter a valid non-negative number.";
                return;
            }

            string output = "";
            int counter = start;

            while (counter >= 0)
            {
                output += $"Countdown: {counter}\n";
                counter--;
            }

            lblResult.Text = output;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int baseNum, limit;

            if (!int.TryParse(txtBase.Text, out baseNum) || baseNum <= 0)
            {
                lblResult.Text = "Enter a valid positive base number.";
                return;
            }

            if (!int.TryParse(txtLimit.Text, out limit) || limit <= 0)
            {
                lblResult.Text = "Enter a valid positive limit.";
                return;
            }

            string output = "";

            for (int i = 1; i <= limit; i++)
            {
                int result = baseNum * i;

                if (result % 2 == 0)
                {
                    continue; // Skip even results
                }

                if (result > 100)
                {
                    output += $"Stopped early at {result} (exceeds 100)\n";
                    break; // Stop if result exceeds 100
                }

                output += $"{baseNum} x {i} = {result}\n";
            }

            tblResult.Text = output;
        }
    }
}
