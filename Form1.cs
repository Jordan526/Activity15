using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity15_1
{
    public partial class Form1 : Form
    {
        int dayOfMonth;
        static int luckyNumber;
        public Form1()
        {
            InitializeComponent();
        }
     
        
        public void userBirthDay()
        {
            dayOfMonth = 0;
            if (birthmonthComboBox.SelectedIndex == 0 || birthmonthComboBox.SelectedIndex == 2 || birthmonthComboBox.SelectedIndex == 4 || birthmonthComboBox.SelectedIndex == 6 || birthmonthComboBox.SelectedIndex == 7 || birthmonthComboBox.SelectedIndex == 9 || birthmonthComboBox.SelectedIndex == 11)
            {
                dayOfMonth = 31;
            }
            //calculate if leap year or not
            else if (birthmonthComboBox.SelectedIndex == 1)
            {
                int year = Int32.Parse(birthyearComboBox.Text);
               
                if (year % 400 == 0)
                    dayOfMonth = 29;
                if (year % 100 == 0)
                    dayOfMonth = 28;
                if (year % 4 == 0)
                    dayOfMonth = 29;
                else
                    dayOfMonth = 28;
            }
            else
                dayOfMonth = 30;

            if (birthmonthComboBox.SelectedIndex != -1)
            {
                birthdayComboBox.Items.Clear();
                for (int i = 0; i < dayOfMonth; i++)
                {
                    birthdayComboBox.Items.Add(i + 1);
                }
                birthdayComboBox.Text = dayOfMonth.ToString();
            }


        }
        private void birthmonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            userBirthDay();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birthyearComboBox.Text = "";
        }

        private void birthyearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            userBirthDay();

        }
        
        private void generateLuckyNumberButton_Click(object sender, EventArgs e)
        {
            if (birthyearComboBox.SelectedIndex != -1 && birthmonthComboBox.SelectedIndex != -1 && birthdayComboBox.SelectedIndex != -1 && animalComboBox.SelectedIndex != -1)
            {
                //calculation lucky number
                luckyNumber = (birthyearComboBox.SelectedIndex + birthmonthComboBox.SelectedIndex + birthdayComboBox.SelectedIndex + animalComboBox.SelectedIndex);
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Please Fill The Above Form");
            }
        }
        public int getLuckyNumber()
        {
            return luckyNumber;
        }

       
    }
}