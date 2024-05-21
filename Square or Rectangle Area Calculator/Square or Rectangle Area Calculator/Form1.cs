using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Square_or_Rectangle_Area_Calculator
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

        private void Area_Calculation()
        {
            double length, breadth, area;
            double.TryParse(textBox1.Text, out length);
            double.TryParse(textBox2.Text, out breadth);
            area = length * breadth;
            label5.Text = "The Area is: " + area.ToString("0.##") + " metre square";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Area_Calculation();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Area_Calculation();
        }
    }
}
