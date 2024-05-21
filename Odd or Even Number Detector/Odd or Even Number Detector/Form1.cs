using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odd_or_Even_Number_Detector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = null;
            MaximizeBox = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int inputValue, Remainder;
            Int32.TryParse(textBox1.Text, out inputValue);
            inputValue = Math.Abs(inputValue);
            Remainder = inputValue % 2;

            if (Remainder == 0) label4.Text = "The number which you have entered is an: ";
            if (Remainder == 0) label5.Text = "Even Number";
            if (Remainder == 0) label4.Text = "The number which you have entered is an: ";
            if (Remainder == 1) label5.Text = "Odd Number";
            
        }
    }
}
