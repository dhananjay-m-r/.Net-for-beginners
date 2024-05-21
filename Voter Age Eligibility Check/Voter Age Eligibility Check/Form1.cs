using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voter_Age_Eligibility_Check
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int inputValue;
            Int32.TryParse(textBox1.Text, out inputValue);

            if (inputValue < 18)
            {
                label4.Text = "Sorry! You are NOT Eligible to vote";
                label4.ForeColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                label4.Text = "You are Eligible to vote";
                label4.ForeColor = Color.FromArgb(0, 128, 0);
            }

        }
    }
}
