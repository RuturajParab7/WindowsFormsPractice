using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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

        private void button1_Click(object sender, EventArgs e)
        {
            int a;

            if (int.TryParse(txtNum.Text, out a))
            {
                string message;

                if (a <= 10)
                {
                    message = "The number is less than or equal to 10";
                }

                else if(a>10 && a<=50)
                {
                    message = "The number is greater than 10 and less than or equal to 50";
                }

                else if (a>50 && a <= 100)
                {
                    message = "The number is greater than 50 but less than or equal to 100";
                }

                else
                {
                    message = "Number greater than century";
                }

                NumLbl.Text = $"{message}\n The actual value of a is : {a}";
                

            }
            else
            {
                NumLbl.Text = "Enter a valid number";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int age;
            double income;

            if (int.TryParse(txtAge.Text, out age))
            {
                if (double.TryParse(txtIncome.Text, out income))
                {
                    if (age >= 21)
                    {
                        if (income >= 25000)
                        {
                            label4.Text = "Loan Approved!";
                        }
                        else
                        {
                            label4.Text = "Income too low for loan eligibility.";
                        }
                    }
                    else
                    {
                        label4.Text = "Age must be at least 21.";
                    }
                }
                else
                {
                    label4.Text = "Please enter a valid income.";
                }
            }
            else
            {
                label4.Text = "Please enter a valid age.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int marks;

            if (string.IsNullOrWhiteSpace(name))
            {
                label8.Text = "Please enter the student's name.";
                return;
            }

            if (!int.TryParse(textBox2.Text, out marks))
            {
                label8.Text = "Please enter valid marks.";
                return;
            }

            // Create and use the Student object
            Student student = new Student
            {
                Name = name,
                Marks = marks
            };

            student.EvaluateGrade();

            label8.Text = $"Student: {student.Name}\nMarks: {student.Marks}\nGrade: {student.Grade}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();  // Create instance of Form3
            form3.Show();               // Show Form3
            this.Hide();
        }
    }
}
