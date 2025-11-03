namespace PracticeApplication
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.Label();
            this.Avialiblity = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnShowIterations = new System.Windows.Forms.Button();
            this.listBoxIterations = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowCarBrand = new System.Windows.Forms.Button();
            this.labelCarBrand = new System.Windows.Forms.Label();
            this.btnShowConstants = new System.Windows.Forms.Button();
            this.labelConstants = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Alice Button";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(344, 67);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 16);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(531, 67);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(32, 16);
            this.labelAge.TabIndex = 2;
            this.labelAge.Text = "Age";
            this.labelAge.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Stock";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(344, 179);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(44, 16);
            this.Price.TabIndex = 4;
            this.Price.Text = "label1";
            this.Price.Click += new System.EventHandler(this.label1_Click);
            // 
            // Avialiblity
            // 
            this.Avialiblity.AutoSize = true;
            this.Avialiblity.Location = new System.Drawing.Point(519, 179);
            this.Avialiblity.Name = "Avialiblity";
            this.Avialiblity.Size = new System.Drawing.Size(44, 16);
            this.Avialiblity.TabIndex = 5;
            this.Avialiblity.Text = "label2";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(594, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 36);
            this.button3.TabIndex = 6;
            this.button3.Text = "Wanna VOTE?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnShowIterations
            // 
            this.btnShowIterations.Location = new System.Drawing.Point(24, 13);
            this.btnShowIterations.Name = "btnShowIterations";
            this.btnShowIterations.Size = new System.Drawing.Size(227, 34);
            this.btnShowIterations.TabIndex = 7;
            this.btnShowIterations.Text = "Print Iterations";
            this.btnShowIterations.UseVisualStyleBackColor = true;
            this.btnShowIterations.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBoxIterations
            // 
            this.listBoxIterations.HideSelection = false;
            this.listBoxIterations.Location = new System.Drawing.Point(24, 67);
            this.listBoxIterations.Name = "listBoxIterations";
            this.listBoxIterations.Size = new System.Drawing.Size(227, 202);
            this.listBoxIterations.TabIndex = 8;
            this.listBoxIterations.UseCompatibleStateImageBehavior = false;
            this.listBoxIterations.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 307);
            this.label1.MaximumSize = new System.Drawing.Size(500, 500);
            this.label1.MinimumSize = new System.Drawing.Size(5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "See car brands here";
            // 
            // btnShowCarBrand
            // 
            this.btnShowCarBrand.Location = new System.Drawing.Point(24, 336);
            this.btnShowCarBrand.Name = "btnShowCarBrand";
            this.btnShowCarBrand.Size = new System.Drawing.Size(150, 29);
            this.btnShowCarBrand.TabIndex = 10;
            this.btnShowCarBrand.Text = "Show car brand";
            this.btnShowCarBrand.UseVisualStyleBackColor = true;
            this.btnShowCarBrand.Click += new System.EventHandler(this.btnShowCarBrand_Click);
            // 
            // labelCarBrand
            // 
            this.labelCarBrand.AutoSize = true;
            this.labelCarBrand.Location = new System.Drawing.Point(71, 387);
            this.labelCarBrand.Name = "labelCarBrand";
            this.labelCarBrand.Size = new System.Drawing.Size(0, 16);
            this.labelCarBrand.TabIndex = 11;
            // 
            // btnShowConstants
            // 
            this.btnShowConstants.Location = new System.Drawing.Point(384, 259);
            this.btnShowConstants.Name = "btnShowConstants";
            this.btnShowConstants.Size = new System.Drawing.Size(163, 27);
            this.btnShowConstants.TabIndex = 12;
            this.btnShowConstants.Text = "Show Constants";
            this.btnShowConstants.UseVisualStyleBackColor = true;
            this.btnShowConstants.Click += new System.EventHandler(this.btnShowConstants_Click);
            // 
            // labelConstants
            // 
            this.labelConstants.AutoSize = true;
            this.labelConstants.Location = new System.Drawing.Point(585, 264);
            this.labelConstants.Name = "labelConstants";
            this.labelConstants.Size = new System.Drawing.Size(189, 16);
            this.labelConstants.TabIndex = 13;
            this.labelConstants.Text = "Values of pi and speed of light:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.labelConstants);
            this.Controls.Add(this.btnShowConstants);
            this.Controls.Add(this.labelCarBrand);
            this.Controls.Add(this.btnShowCarBrand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxIterations);
            this.Controls.Add(this.btnShowIterations);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Avialiblity);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Avialiblity;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnShowIterations;
        private System.Windows.Forms.ListView listBoxIterations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowCarBrand;
        private System.Windows.Forms.Label labelCarBrand;
        private System.Windows.Forms.Button btnShowConstants;
        private System.Windows.Forms.Label labelConstants;
    }
}

