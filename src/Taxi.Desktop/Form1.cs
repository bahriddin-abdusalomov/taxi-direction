using Taxi.DataAccess.FileServices;
using Taxi.DataAccess.Interfaces;
using Taxi.Desktop.Forms;
using Taxi.Domain.Models.Users;

namespace Taxi.Desktop
{
    public partial class Form1 : Form
    {
        private readonly IFileService _fileService;
        private readonly IUser _userService;
        private readonly string fileName = @"C:\\Users\\USER\\Desktop\\taxi-direction\\database\\users.txt";
        public Form1()
        {
            InitializeComponent();
            _fileService = new FileService();
            _userService = new UserService(_fileService);
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;

            int count = 0;

            if (string.IsNullOrEmpty(textBoxFirstName.Text))
            {
                label4.ForeColor = Color.Red;
                count++;
            }
            if (string.IsNullOrEmpty(textBoxLastName.Text))
            {
                label5.ForeColor = Color.Red;
                count++;
            }
            if (string.IsNullOrEmpty(textBoxUserName.Text))
            {
                label7.ForeColor = Color.Red;
                count++;
            }
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                label6.ForeColor = Color.Red;
                count++;
            }

            if (count == 0)
            {

                _fileService.CreateFile(fileName);

                User user = new User()
                {
                    FisrtName = textBoxFirstName.Text,
                    LastName = textBoxLastName.Text,
                    UserName = textBoxUserName.Text,
                    Password = textBoxPassword.Text,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                };

                _userService.CreateUser(user, fileName);
                AllForm allForm = new AllForm();
                allForm.ShowDialog();
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
    }
}