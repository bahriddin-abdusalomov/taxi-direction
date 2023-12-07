using Taxi.DataAccess.FileServices;
using Taxi.DataAccess.Interfaces;
using Taxi.Domain.Models.Directions;

namespace Taxi.Desktop.Forms
{
    public partial class TaxiForm : Form
    {
        private readonly IFileService _fileService;
        private readonly IDirection _directionService;
        private readonly string fileName = @"C:\\Users\\USER\\Desktop\\taxi-direction\\database\\direction.txt";

        public TaxiForm()
        {
            InitializeComponent();
            _fileService = new FileService();
            _directionService = new DirectionService();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            labelStartTime.Text = "Start time:";
            labelEndTime.Text = "End time:";
            labelTime.Text = "Time to go:";
            labelSpeed.Text = "Avarage time:";

            Direction direction = new Direction();

            int[] qiymatlar = { 50, 60, 70, 80, 90, 100 };

            Random random = new Random();

            int[] tanlanganQiymatlar = new int[3];

            for (int i = 0; i < 3; i++)
            {
                int tanlanganIndex = random.Next(qiymatlar.Length);
                tanlanganQiymatlar[i] = qiymatlar[tanlanganIndex];
            }

            double speed = tanlanganQiymatlar.Sum(x => x) / 3;
            double time = double.Parse(textBoxDistance.Text) / speed;

            labelStartTime.Text = labelStartTime.Text + "   " + DateTime.Now.ToString();
            labelEndTime.Text = labelEndTime.Text + "   " + DateTime.Now.AddHours(time);
            labelTime.Text = labelTime.Text + "   " + time.ToString();
            labelSpeed.Text = labelSpeed.Text + "   " + speed.ToString();

            direction.Id = _fileService.GetNumberOfLines(fileName) + 1;
            direction.From = textBoxFrom.Text;
            direction.Destination = textBoxDestination.Text;
            direction.Speed = speed;
            direction.Time = time;
            direction.Distance = textBoxDistance.Text;
            direction.StartAt = DateTime.Now;
            direction.EndAt = DateTime.Now.AddHours(time);

            if (File.Exists(fileName))
            {
                _directionService.CreateDirection(direction, fileName);
            }
            else
            {
                _fileService.CreateFile(fileName);
                _directionService.CreateDirection(direction, fileName);
            }
        }

        private void TaxiForm_Load(object sender, EventArgs e)
        {

        }
    }
}
