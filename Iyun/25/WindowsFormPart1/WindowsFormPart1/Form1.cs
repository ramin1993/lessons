using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormPart1
{
    public partial class MyNewForm : Form
    {
        public MyNewForm()
        {
            InitializeComponent();
        }

        private void clickEvent_Click(object sender, EventArgs e)
        {
            string msg = this.SendMessage.Text;
            if(msg=="")
            {                
                msg = "Bu xana bos ola bilmez";                
            }
            else
            {
                ShowMessage showMessage = new ShowMessage(msg);
                showMessage.Show();

            }

                       
        }


    }
}
