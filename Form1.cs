using System;
using System.Windows.Forms;
using Timer.Helpers;
using Timer.Config;

namespace Timer
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer;
        int totalSeconds = 0;

        public Form1()
        {
            InitializeComponent();
            TimerLabel.Text = Strings.timerDefault;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += UpdateTimerText;
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
            TimerLabel.Text = Strings.timerDefault;
            timer.Stop();
        }

        public void UpdateTimerText(object sender, EventArgs e)
        {
            TimerUpdate.Update(ref totalSeconds, timer, TimerLabel);
        }

    }
}
