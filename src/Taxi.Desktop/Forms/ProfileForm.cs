using Taxi.DataAccess.FileServices;
using Taxi.DataAccess.Interfaces;
using Taxi.Domain.Models.Users;

namespace Taxi.Desktop.Forms
{
    public partial class ProfileForm : Form
    {
        private readonly string fileName = @"C:\\Users\\USER\\Desktop\\taxi-direction\\database\\users.txt";
        private readonly IFileService _fileService;
        private readonly IUser _userService;

        public ProfileForm()
        {
            InitializeComponent();
            _fileService = new FileService();
            _userService = new UserService(_fileService);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                FisrtName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                UserName = textBoxUserName.Text,
                Password = textBoxPassword.Text,
                UpdatedAt = DateTime.UtcNow,
            };

            _userService.UpdateUser(user, fileName);

            AllForm allForm = new AllForm();
            allForm.ShowDialog();
        }
    }
}
