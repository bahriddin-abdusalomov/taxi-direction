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
    public partial class TaxiForm : Form
    {
        public TaxiForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
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
            labelTime.Text = labelTime.Text +"   "+time.ToString();
            labelSpeed.Text = labelSpeed.Text + "   " + speed.ToString();
        }
    }
}
