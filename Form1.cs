using System;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer;
        int totalMilliseconds = 0;
        const string timerDefault = "00:00:00:000";

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
            totalMilliseconds = 0;
            TimerTextBox.Text = timerDefault;
        }
        public void UpdateTextBox(object sender, EventArgs e)
        {
            totalMilliseconds += 1000;
            int hours = totalMilliseconds / 3600000;
            int minutes = (totalMilliseconds % 3600000) / 60000;
            int seconds = (totalMilliseconds % 60000) / 1000;
            int milliseconds = totalMilliseconds % 1000;

            TimerTextBox.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}:{milliseconds:D3}";
        }
    }
}
