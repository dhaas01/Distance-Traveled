using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Traveled
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DistanceTraveled12HoursButton_Click(object sender, EventArgs e)
        {
            int speedMilesPerHour;          // To hold the user's input of the speed of the car.
            double distanceIn12Hours;       // To hold the distance traveled in 12 hours.
            const int HOURS_TRAVELED = 12;  // The number of hours traveled in 12 hours.

            // To bring the user's input for the speed of the car into the variable of speedMilesPerHour.
            speedMilesPerHour = int.Parse(speedTextBox.Text);

            // To calculate the distance that the car traveled in the given hours.
            distanceIn12Hours = speedMilesPerHour * HOURS_TRAVELED;

            // To output the distance that the car went in the given hours.
            calculatedDistance12HoursLabel.Text = distanceIn12Hours.ToString("n1");
        }

        private void DistanceTraveled5HoursButton_Click(object sender, EventArgs e)
        {
            int speedMilesPerHour;          // To hold the user's input of the speed of the car.
            double distanceIn5Hours;        // To hold the distance traveled in 5 hours.
            const int HOURS_TRAVELED = 5;   // The number of hours traveled in 5 hours.

            // To bring the user's input for the speed of the car into the variable of speedMilesPerHour.
            speedMilesPerHour = int.Parse(speedTextBox.Text);

            // To calculate the distance that the car traveled in 5 hours.
            distanceIn5Hours = speedMilesPerHour * HOURS_TRAVELED;

            // To output the distance that the car went in the given hours.
            calculatedDistance5HoursLabel.Text = distanceIn5Hours.ToString("n1");
        }

        private void DistanceTraveled8HoursButton_Click(object sender, EventArgs e)
        {
            int speedMilesPerHour;          // To hold the user's input of the speed of the car.
            double distanceIn8Hours;        // To hold the distance traveled in 8 hours.
            const int HOURS_TRAVELED = 8;   // The number of hours traveled in 8 hours.

            // To bring the user's input for the speed of the car into the variable of speedMilesPerHour.
            speedMilesPerHour = int.Parse(speedTextBox.Text);

            // To calculate the distance that the car traveled in 8 hours.
            distanceIn8Hours = speedMilesPerHour * HOURS_TRAVELED;

            // To output the distance that the car went in 8 hours.
            calculatedDistance8HoursLabel.Text = distanceIn8Hours.ToString("n1");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // To clear the input and output boxes.
            speedTextBox.Text = "";
            calculatedDistance12HoursLabel.Text = "";
            calculatedDistance5HoursLabel.Text = "";
            calculatedDistance8HoursLabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // To close the form.
            this.Close();
        }
    }
}
