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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCheckAge_Click(object sender, EventArgs e)
        {
            int age;
            bool isValid = int.TryParse(textBoxAge.Text, out age);

            if (!isValid)
            {
                labelResult.Text = "Please enter a valid number.";
                return; 
            }

            if (age >= 18)
                labelResult.Text = "You are eligible to vote!";
            else
                labelResult.Text = "Sorry, you must be 18+ to vote.";
        }

        private void btnShowRectangle_Click(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle();
            r.AcceptDetails();

            string details = r.DisplayDetails();
            labelRectangle.Text = details;


        }
    }
}
