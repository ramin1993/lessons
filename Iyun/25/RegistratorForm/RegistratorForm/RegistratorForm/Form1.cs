using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistratorForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {


        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userName.Text))
            {
                warningLabel.Text = "Bu xana bos ola bilmez.";
            }
            if (string.IsNullOrEmpty(password.Text))
            {
                warninPaswordLab.Text = "Sifre daxil edin.";
            }else if (char.IsDigit(password.Text[0]))
            {
                warninPaswordLab.Text = "Sifrede reqemden istifade edin.";
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
