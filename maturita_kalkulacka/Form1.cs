using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maturita_kalkulacka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelSecondary.Text = "";
        }

        string operation = "";
        bool operationPerformed = false;
        double result = 0;

        private void buttonNumbers_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (labelPrimary.Text == "0" && button.Text != "," || operationPerformed)
            {
                labelPrimary.Text = "";
            }

            if (button.Text == ",")
            {
                if (!labelPrimary.Text.Contains(","))
                {
                    labelPrimary.Text += ",";
                }
            }
            else
            {
                labelPrimary.Text += button.Text;
            }
        }

        private void buttonOperations_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            operationPerformed = true;
            result = double.Parse(labelPrimary.Text);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            operation = "";
            operationPerformed = false;
            result = 0;
            labelPrimary.Text = "0";
            labelSecondary.Text = "";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    labelPrimary.Text = (result + double.Parse(labelPrimary.Text)).ToString();
                    break;
                case "-":
                    labelPrimary.Text = (result - double.Parse(labelPrimary.Text)).ToString();
                    break;
                case "*":
                    labelPrimary.Text = (result * double.Parse(labelPrimary.Text)).ToString();
                    break;
                case "/":
                    labelPrimary.Text = (result / double.Parse(labelPrimary.Text)).ToString();
                    break;
            }
        }
    }
}
