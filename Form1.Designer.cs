namespace Activity15_1
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
            this.birthyearLabel = new System.Windows.Forms.Label();
            this.birthmonthLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.favoriteAnimalLabel = new System.Windows.Forms.Label();
            this.birthyearComboBox = new System.Windows.Forms.ComboBox();
            this.birthmonthComboBox = new System.Windows.Forms.ComboBox();
            this.birthdayComboBox = new System.Windows.Forms.ComboBox();
            this.animalComboBox = new System.Windows.Forms.ComboBox();
            this.generateLuckyNumberButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // birthyearLabel
            // 
            this.birthyearLabel.AutoSize = true;
            this.birthyearLabel.Location = new System.Drawing.Point(24, 66);
            this.birthyearLabel.Name = "birthyearLabel";
            this.birthyearLabel.Size = new System.Drawing.Size(104, 13);
            this.birthyearLabel.TabIndex = 0;
            this.birthyearLabel.Text = "Enter your birth year:";
            // 
            // birthmonthLabel
            // 
            this.birthmonthLabel.AutoSize = true;
            this.birthmonthLabel.Location = new System.Drawing.Point(24, 115);
            this.birthmonthLabel.Name = "birthmonthLabel";
            this.birthmonthLabel.Size = new System.Drawing.Size(113, 13);
            this.birthmonthLabel.TabIndex = 1;
            this.birthmonthLabel.Text = "Enter your birth month:";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(24, 165);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(101, 13);
            this.birthdayLabel.TabIndex = 2;
            this.birthdayLabel.Text = "Enter your birth day:";
            // 
            // favoriteAnimalLabel
            // 
            this.favoriteAnimalLabel.AutoSize = true;
            this.favoriteAnimalLabel.Location = new System.Drawing.Point(24, 213);
            this.favoriteAnimalLabel.Name = "favoriteAnimalLabel";
            this.favoriteAnimalLabel.Size = new System.Drawing.Size(129, 13);
            this.favoriteAnimalLabel.TabIndex = 3;
            this.favoriteAnimalLabel.Text = "Enter your favorite animal:";
            // 
            // birthyearComboBox
            // 
            this.birthyearComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            ""});
            this.birthyearComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.birthyearComboBox.FormattingEnabled = true;
            this.birthyearComboBox.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.birthyearComboBox.Location = new System.Drawing.Point(178, 58);
            this.birthyearComboBox.Name = "birthyearComboBox";
            this.birthyearComboBox.Size = new System.Drawing.Size(121, 21);
            this.birthyearComboBox.TabIndex = 4;
            // 
            // birthmonthComboBox
            // 
            this.birthmonthComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "January",
            "February",
            "March",
            "April ",
            "May ",
            "June",
            "July ",
            "August",
            "September",
            "October",
            "November ",
            "Decemeber"});
            this.birthmonthComboBox.FormattingEnabled = true;
            this.birthmonthComboBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April ",
            "May ",
            "June",
            "July ",
            "August",
            "September",
            "October",
            "November ",
            "Decemeber"});
            this.birthmonthComboBox.Location = new System.Drawing.Point(178, 107);
            this.birthmonthComboBox.Name = "birthmonthComboBox";
            this.birthmonthComboBox.Size = new System.Drawing.Size(121, 21);
            this.birthmonthComboBox.TabIndex = 5;
            // 
            // birthdayComboBox
            // 
            this.birthdayComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.birthdayComboBox.FormattingEnabled = true;
            this.birthdayComboBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.birthdayComboBox.Location = new System.Drawing.Point(178, 157);
            this.birthdayComboBox.Name = "birthdayComboBox";
            this.birthdayComboBox.Size = new System.Drawing.Size(121, 21);
            this.birthdayComboBox.TabIndex = 6;
            // 
            // animalComboBox
            // 
            this.animalComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Cat",
            "Dog",
            "Goose",
            "Monkey",
            "Turtle",
            "Shark",
            "Praying Mantis",
            "Centipede",
            "Loch Ness Monster",
            "Bigfoot",
            "Sasquach",
            "Snowman",
            "Pig",
            "Bear",
            "Butterfly",
            "Moth",
            "Tarantula",
            "T-Rex"});
            this.animalComboBox.FormattingEnabled = true;
            this.animalComboBox.Items.AddRange(new object[] {
            "Cat",
            "Dog",
            "Goose",
            "Monkey",
            "Turtle",
            "Shark",
            "Praying Mantis",
            "Centipede",
            "Loch Ness Monster",
            "Bigfoot",
            "Sasquach",
            "Snowman",
            "Pig",
            "Bear",
            "Butterfly",
            "Moth",
            "Tarantula",
            "T-Rex"});
            this.animalComboBox.Location = new System.Drawing.Point(178, 205);
            this.animalComboBox.Name = "animalComboBox";
            this.animalComboBox.Size = new System.Drawing.Size(121, 21);
            this.animalComboBox.TabIndex = 7;
            // 
            // generateLuckyNumberButton
            // 
            this.generateLuckyNumberButton.Location = new System.Drawing.Point(125, 257);
            this.generateLuckyNumberButton.Name = "generateLuckyNumberButton";
            this.generateLuckyNumberButton.Size = new System.Drawing.Size(214, 73);
            this.generateLuckyNumberButton.TabIndex = 8;
            this.generateLuckyNumberButton.Text = "Generate Your Lucky Number Here!!!";
            this.generateLuckyNumberButton.UseVisualStyleBackColor = true;
            this.generateLuckyNumberButton.Click += new System.EventHandler(this.generateLuckyNumberButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 351);
            this.Controls.Add(this.generateLuckyNumberButton);
            this.Controls.Add(this.animalComboBox);
            this.Controls.Add(this.birthdayComboBox);
            this.Controls.Add(this.birthmonthComboBox);
            this.Controls.Add(this.birthyearComboBox);
            this.Controls.Add(this.favoriteAnimalLabel);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.birthmonthLabel);
            this.Controls.Add(this.birthyearLabel);
            this.Name = "Form1";
            this.Text = "Lucky Numbers!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label birthyearLabel;
        private System.Windows.Forms.Label birthmonthLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label favoriteAnimalLabel;
        private System.Windows.Forms.ComboBox birthyearComboBox;
        private System.Windows.Forms.ComboBox birthmonthComboBox;
        private System.Windows.Forms.ComboBox birthdayComboBox;
        private System.Windows.Forms.ComboBox animalComboBox;
        private System.Windows.Forms.Button generateLuckyNumberButton;
    }
}

