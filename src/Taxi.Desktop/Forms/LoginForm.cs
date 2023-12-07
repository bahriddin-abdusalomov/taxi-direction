using System.Text.RegularExpressions;

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
            string login = textBoxUserName.Text + " " + textBoxPassword.Text;
            string data = "";

            if (File.Exists(fileName))
            {
                if (File.Exists(fileName))
                {
                     data = File.ReadAllText(fileName);
                }

                Regex regex = new Regex(login);
                Match match = regex.Match(data);

                if (match.Success)
                {
                    AllForm allForm = new AllForm();
                    allForm.ShowDialog();
                }
                else
                {
                    labelPassword.ForeColor = Color.Red;
                    labelUserName.ForeColor = Color.Red;
                }
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            Form1 register = new Form1();
            register.ShowDialog();
        }
    }
}
