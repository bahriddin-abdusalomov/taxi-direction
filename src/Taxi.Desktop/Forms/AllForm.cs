namespace Taxi.Desktop.Forms
{
    public partial class AllForm : Form
    {
        public AllForm()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void myProfile_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.ShowDialog();
        }

        private void service_Click(object sender, EventArgs e)
        {
            TaxiForm taxiForm = new TaxiForm();
            taxiForm.ShowDialog();
        }
    }
}
