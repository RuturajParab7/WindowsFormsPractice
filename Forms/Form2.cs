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

        private void btnCompare_Click(object sender, EventArgs e)
        {
            int a, b;

            if (int.TryParse(txtA.Text, out a) && int.TryParse(txtB.Text, out b))
            {
                string result = $"{a} > {b}: {a > b}\n" +
                $"{a} == {b}: {a == b}";
                lblResult.Text = result;
            }
            else
            {
                lblResult.Text = "Please enter valid integers.";
            }
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            string day = cmbDay.SelectedItem?.ToString();
            string result;

            switch (day)
            {
                case "Monday":
                    result = "Weekday\nActivity: Kickstart work\nMessage: Fresh start, stay focused!";
                    break;
                case "Tuesday":
                    result = "Weekday\nActivity: Deep work\nMessage: Keep the momentum going!";
                    break;
                case "Wednesday":
                    result = "Weekday\nActivity: Midweek review\nMessage: You're halfway there!";
                    break;
                case "Thursday":
                    result = "Weekday\nActivity: Planning\nMessage: Prep for the weekend!";
                    break;
                case "Friday":
                    result = "Weekday\nActivity: Wrap-up\nMessage: Finish strong!";
                    break;
                case "Saturday":
                    result = "Weekend\nActivity: Relax or explore\nMessage: Recharge and enjoy!";
                    break;
                case "Sunday":
                    result = "Weekend\nActivity: Reflect and reset\nMessage: Plan your week ahead!";
                    break;
                default:
                    result = "Please select a valid day.";
                    break;
            }

            Res.Text = result;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
