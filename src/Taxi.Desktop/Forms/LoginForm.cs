using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxi.Desktop.Forms
{
    public partial class LoginForm : Form
    {
        private readonly string fileName = @"C:\\Users\\USER\\Desktop\\taxi-direction\\database\\users.txt";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked == true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            string login = string.Format("{0} {1}", textBoxUserName.Text, textBoxPassword);
            string data = "";

            if (File.Exists(fileName))
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    data = sr.ReadToEnd();
                }

                if (data.Contains(login))
                {

                }
                else
                {
                    textBoxUserName.ForeColor = Color.Red;
                    textBoxPassword.ForeColor = Color.Red;
                }
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            Form1 register = new Form1();
            register.ShowDialog();
            this.Hide();
        }
    }
}
