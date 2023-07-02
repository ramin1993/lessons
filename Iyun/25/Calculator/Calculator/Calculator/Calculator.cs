using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }


        string clickedOperator = "";
        double tot = 0;

        private void GetMathOperator_Click(object sender, EventArgs e)
        {
            clickedOperator = ((Button)sender).Text;
        }

        private void EqualsBtn_Click(object sender, EventArgs e)
        {
            double a, b;
            if (!double.TryParse(writeVala.Text, out a) || !double.TryParse(writeValb.Text, out b))
            {
                Result.Text = "Reqem daxil edin.";
                return;
            }

            switch (clickedOperator)
            {
                case "+":
                    tot = a + b;
                    Result.Text = tot.ToString();
                    break;
                case "-":
                    tot = a - b;
                    Result.Text = tot.ToString();
                    break;
                case "/":
                    if (b == 0)
                    {
                        Result.Text = "Eded sifira bolune bilmez.";
                        return;
                    }
                    tot = a / b;
                    Result.Text = tot.ToString();
                    break;
                case "*":
                    tot = a * b;
                    Result.Text = tot.ToString();
                    break;
                default:
                    Result.Text = "Secim edilmemisdir.";
                    break;
            }
        }
    }
}
