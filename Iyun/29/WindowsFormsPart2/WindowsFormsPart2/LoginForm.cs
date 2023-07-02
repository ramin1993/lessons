using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPart2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            usernameTextBox.TextChanged += ChangeInputBackColor;
            passwordTextBox.TextChanged += ChangeInputBackColor;
        }

        private void LoginMethod(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            User foundUser = VirtualDatabase.Users.Find(m => m.Username == username && m.Password == password);

            if (foundUser != null)
            {
                HomePage homePage = new HomePage(foundUser);
                homePage.Show();
            }
            else
            {
                MessageBox.Show("İstifadəçi məlumatları yanlışdır!", "Xəta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void TextboxEnterColor(object sender, EventArgs e)
        //{
        //    TextBox textBox = (TextBox)sender;
        //    textBox.BackColor = Color.Yellow;
        //}

        //private void TextboxLeaveColor(object sender, EventArgs e)
        //{
        //    TextBox textBox = (TextBox)sender;
        //    textBox.BackColor = Color.White;
        //}

        private void showPassword(object sender, EventArgs e)
        {
            hidePasswordIcon.Visible = true;
            showPasswordIcon.Visible = false;
            passwordTextBox.UseSystemPasswordChar = true;

        }

        private void hidePassword(object sender, EventArgs e)
        {
            hidePasswordIcon.Visible = false;
            showPasswordIcon.Visible = true;
            passwordTextBox.UseSystemPasswordChar=!passwordTextBox.UseSystemPasswordChar;
        }


        private void ChangeInputBackColor(object sender, EventArgs e)
        {
            
            if (usernameTextBox.Text.Length > 0 && passwordTextBox.Text.Length > 0)
            {
                usernameTextBox.BackColor = Color.White;
                passwordTextBox.BackColor = Color.Yellow;
            }
            else
            {
                usernameTextBox.BackColor = Color.Yellow;
                passwordTextBox.BackColor = Color.White;
            }


        }
    }
}
