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

        private void button1_Click(object sender, EventArgs e)
        {
            int A, B;

            if (!int.TryParse(txtA.Text, out A) || !int.TryParse(txtB.Text, out B))
            {
                lblResult.Text = "Please enter valid integers for A and B.";
                return;
            }

            string output = "";

            int C;

            // Simple Assignment
            C = A + B;
            output += $"C = A + B → C = {C}\n";

            // Add and Assign
            C += A;
            output += $"C += A → C = {C}\n";

            // Subtract and Assign
            C -= B;
            output += $"C -= B → C = {C}\n";

            // Multiply and Assign
            C *= A;
            output += $"C *= A → C = {C}\n";

            // Divide and Assign (avoid divide by zero)
            if (B != 0)
            {
                C /= B;
                output += $"C /= B → C = {C}\n";
            }
            else
            {
                output += $"C /= B → Cannot divide by zero\n";
            }

            // Modulus and Assign
            if (A != 0)
            {
                C %= A;
                output += $"C %= A → C = {C}\n";
            }
            else
            {
                output += $"C %= A → Cannot perform modulus by zero\n";
            }

            // Left Shift and Assign
            C <<= 2;
            output += $"C <<= 2 → C = {C}\n";

            // Right Shift and Assign
            C >>= 1;
            output += $"C >>= 1 → C = {C}\n";

            // Bitwise AND and Assign
            C &= 2;
            output += $"C &= 2 → C = {C}\n";

            // Bitwise XOR and Assign
            C ^= 2;
            output += $"C ^= 2 → C = {C}\n";

            // Bitwise OR and Assign
            C |= 2;
            output += $"C |= 2 → C = {C}\n";

            AssignOps.Text = output;
        }


        int secretNumber = 7;
        bool guessedCorrectly = false;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int guess;

            if (!int.TryParse(txtGuess.Text, out guess))
            {
                lblFeedback.Text = "Please enter a valid number.";
                return;
            }

            // Simulate the do-while loop behavior
            if (!guessedCorrectly)
            {
                lblFeedback.Text = $"Number to be guessed is: {guess}\n";

                if (guess < secretNumber)
                {
                    lblFeedback.Text += "Too low! Try again.";
                }
                else if (guess > secretNumber)
                {
                    lblFeedback.Text += "Too high! Try again.";
                }
                else
                {
                    lblFeedback.Text += "🎉 Congratulations! You guessed the correct number.";
                    guessedCorrectly = true;
                }
            }
            else
            {
                lblFeedback.Text = "Game over. You already guessed it!";
            }
        }
    }
}
