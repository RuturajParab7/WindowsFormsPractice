namespace PracticeApplication
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPrompt = new System.Windows.Forms.Label();
            this.btnCheckAge = new System.Windows.Forms.Button();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.btnShowRectangle = new System.Windows.Forms.Button();
            this.labelRectangle = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.Res = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.NumLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPrompt
            // 
            this.labelPrompt.AutoSize = true;
            this.labelPrompt.Location = new System.Drawing.Point(287, 35);
            this.labelPrompt.MinimumSize = new System.Drawing.Size(0, 7);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(114, 16);
            this.labelPrompt.TabIndex = 0;
            this.labelPrompt.Text = "What is your age?";
            // 
            // btnCheckAge
            // 
            this.btnCheckAge.Location = new System.Drawing.Point(290, 76);
            this.btnCheckAge.Name = "btnCheckAge";
            this.btnCheckAge.Size = new System.Drawing.Size(175, 26);
            this.btnCheckAge.TabIndex = 1;
            this.btnCheckAge.Text = "Check eligiblity";
            this.btnCheckAge.UseVisualStyleBackColor = true;
            this.btnCheckAge.Click += new System.EventHandler(this.btnCheckAge_Click);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(407, 32);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 22);
            this.textBoxAge.TabIndex = 2;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(343, 131);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 16);
            this.labelResult.TabIndex = 3;
            // 
            // btnShowRectangle
            // 
            this.btnShowRectangle.Location = new System.Drawing.Point(26, 16);
            this.btnShowRectangle.Name = "btnShowRectangle";
            this.btnShowRectangle.Size = new System.Drawing.Size(175, 38);
            this.btnShowRectangle.TabIndex = 4;
            this.btnShowRectangle.Text = "Show Rectangle Details";
            this.btnShowRectangle.UseVisualStyleBackColor = true;
            this.btnShowRectangle.Click += new System.EventHandler(this.btnShowRectangle_Click);
            // 
            // labelRectangle
            // 
            this.labelRectangle.AutoSize = true;
            this.labelRectangle.Location = new System.Drawing.Point(83, 76);
            this.labelRectangle.Name = "labelRectangle";
            this.labelRectangle.Size = new System.Drawing.Size(0, 16);
            this.labelRectangle.TabIndex = 5;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(37, 197);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 22);
            this.txtA.TabIndex = 6;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(37, 259);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 7;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(143, 223);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(94, 30);
            this.btnCompare.TabIndex = 8;
            this.btnCompare.Text = "COMPARE";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(259, 230);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(45, 16);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Result";
            // 
            // cmbDay
            // 
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Items.AddRange(new object[] {
            "Monday",
            "",
            "Tuesday",
            "",
            "Wednesday",
            "",
            "Thursday",
            "",
            "Friday",
            "",
            "Saturday",
            "",
            "Sunday"});
            this.cmbDay.Location = new System.Drawing.Point(21, 345);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(180, 24);
            this.cmbDay.TabIndex = 10;
            this.cmbDay.Text = "Select a day of the week";
            this.cmbDay.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(224, 340);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(98, 32);
            this.btnAnalyze.TabIndex = 11;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // Res
            // 
            this.Res.AutoSize = true;
            this.Res.Location = new System.Drawing.Point(365, 348);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(45, 16);
            this.Res.TabIndex = 12;
            this.Res.Text = "Result";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(612, 197);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(130, 22);
            this.txtNum.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumLbl
            // 
            this.NumLbl.AutoSize = true;
            this.NumLbl.Location = new System.Drawing.Point(654, 324);
            this.NumLbl.Name = "NumLbl";
            this.NumLbl.Size = new System.Drawing.Size(44, 16);
            this.NumLbl.TabIndex = 15;
            this.NumLbl.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nested if statements";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(86, 487);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 22);
            this.txtAge.TabIndex = 17;
            // 
            // txtIncome
            // 
            this.txtIncome.Location = new System.Drawing.Point(86, 526);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(100, 22);
            this.txtIncome.TabIndex = 18;
            this.txtIncome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Enter age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Enter income";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(26, 563);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(133, 33);
            this.btnCheck.TabIndex = 21;
            this.btnCheck.Text = "Check status";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 615);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "label4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(474, 508);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(474, 563);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "GRADES OF STUDENTS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 513);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "NAME";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 563);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "MARKS";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(592, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 39);
            this.button2.TabIndex = 28;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(764, 537);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "label8";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(869, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 39);
            this.button3.TabIndex = 30;
            this.button3.Text = "GO TO PAGE 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 694);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.Res);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.labelRectangle);
            this.Controls.Add(this.btnShowRectangle);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.btnCheckAge);
            this.Controls.Add(this.labelPrompt);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrompt;
        private System.Windows.Forms.Button btnCheckAge;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button btnShowRectangle;
        private System.Windows.Forms.Label labelRectangle;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Label Res;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label NumLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
    }
}