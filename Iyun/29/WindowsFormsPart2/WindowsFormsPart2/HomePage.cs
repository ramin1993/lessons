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
    public partial class HomePage : Form
    {
        private User editedUser; 

        public HomePage(User user)
        {
            InitializeComponent();


                nameEdit.Text = user.Name;
                surnameEdit.Text = user.Surname;
                usernameEdit.Text = user.Username;
                passwordEdit.Text = user.Password;
                aboutUserEdit.Text = user.AboutUser;
                saveUserInfoBtn.Tag = user.Id;

            


        }

        private void EditBtnClick(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(saveUserInfoBtn.Tag);
            editedUser = VirtualDatabase.Users.Find(u => u.Id == userId);

            if (editedUser != null)
            {
                editedUser.Name = nameEdit.Text;
                editedUser.Surname = surnameEdit.Text;
                editedUser.Password = passwordEdit.Text;
                editedUser.AboutUser = aboutUserEdit.Text;
            }
        }

        private void saveUserInfoBtnClick(object sender, EventArgs e)
        {
            if (editedUser != null)
            {
                MessageBox.Show("User melumatlari ugurla editlendi.");

                nameEdit.Text = editedUser.Name;
                surnameEdit.Text = editedUser.Surname;
                passwordEdit.Text = editedUser.Password;
                aboutUserEdit.Text = editedUser.AboutUser;
            }
            this.Close();
            LoginForm newLoginPage = new LoginForm();
            newLoginPage.Show();
        }
    }
}
