using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(value1.Text);
            double second = Convert.ToDouble(value2.Text);
            resultBox.Text = Convert.ToString(first + second);
        }

        private void subractButton_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(value1.Text);
            double second = Convert.ToDouble(value2.Text);
            resultBox.Text = Convert.ToString(first - second);
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(value1.Text);
            double second = Convert.ToDouble(value2.Text);
            resultBox.Text = Convert.ToString(first * second);
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(value1.Text);
            double second = Convert.ToDouble(value2.Text);
            resultBox.Text = Convert.ToString(first / second);
        }

        private void useResult1_Click(object sender, EventArgs e)
        {
            value1.Text = resultBox.Text;
            value2.Clear();
        }

        private void UseResult2_Click(object sender, EventArgs e)
        {
            value2.Text = resultBox.Text;
            value1.Clear();
        }
    }
}
