using Taxi.DataAccess.FileServices;
using Taxi.DataAccess.Interfaces;

namespace Taxi.Desktop.Forms
{
    public partial class HistoryForm : Form
    {
        private readonly IDirection _directionService;
        private readonly string fileName = @"C:\\Users\\USER\\Desktop\\taxi-direction\\database\\direction.txt";

        public HistoryForm()
        {
            InitializeComponent();
            _directionService = new DirectionService();
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            string data = _directionService.GetAllDirection(fileName);

            textBoxAllHistory.Text = data;
        }
    }
}
