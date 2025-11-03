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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age = 25;
            string name = "Alice";

            labelName.Text = "Name: " + name;
            labelAge.Text = "Age: " + age.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double price = 99.99;
            bool isAvailable = true;

            Price.Text = "Price: " + price;
            Avialiblity.Text = "In stock: " + isAvailable;
        }


        private void btnShowCarBrand_Click(object sender, EventArgs e)
        {
            Car myCar = new Car();
            myCar.Brand = "Tesla";

            string result = myCar.ShowBrand();
            labelCarBrand.Text = result;
        }

        private void btnShowConstants_Click(object sender, EventArgs e)
        {
            string result = $"Value of Pi: {MathConstants.Pi}\n" +
                    $"Speed of Light: {MathConstants.SpeedOfLight}";

            labelConstants.Text = result;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            const double pi = 3.14159;
            double r;

            if (double.TryParse(txtRadius.Text, out r))
            {
                double area = pi * r * r;
                lblResult.Text = $"Radius: {r}, Area: {area}";
            }
            else
            {
                lblResult.Text = "Please enter a valid number.";
            }
        }


        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double num1, num2;

            if (double.TryParse(txtNum1.Text, out num1) && double.TryParse(txtNum2.Text, out num2))
            {
                string result = $"Addition: {num1 + num2}\n" +
                                $"Subtraction: {num1 - num2}\n" +
                                $"Multiplication: {num1 * num2}\n" +
                                $"Division: {(num2 != 0 ? (num1 / num2).ToString() : "Cannot divide by zero")}\n" +
                                $"Modulus: {(num2 != 0 ? (num1 % num2).ToString() : "Cannot mod by zero")}";

                ArithmeticResult.Text = result;
            }
            else
            {
                ArithmeticResult.Text = "Please enter valid numbers.";
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void labelName_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBoxIterations.Items.Clear();

            for (int i = 0; i<=5; i++)
            {
                listBoxIterations.Items.Add("Iterations : " + i);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
