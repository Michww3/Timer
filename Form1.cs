using System;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer;
        int totalSeconds = 0;
        const string timerDefault = "00:00:00";

        public Form1()
        {
            InitializeComponent();
            TimerTextBox.Text = timerDefault;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += UpdateTextBox;
        }

        private void StartButtn_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void StopButtton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            totalSeconds = 0;
            TimerTextBox.Text = timerDefault;
        }
        public void UpdateTextBox(object sender, EventArgs e)
        {
            totalSeconds++;
            int hours = totalSeconds / 3600;
            int minutes = totalSeconds / 60 % 60;
            int seconds = totalSeconds % 60;

            if (hours > 99)
            {
                timer.Stop();
                MessageBox.Show("Timer reset");
                totalSeconds = 0;
                TimerTextBox.Text = timerDefault;
            }

            TimerTextBox.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }
    }
}
