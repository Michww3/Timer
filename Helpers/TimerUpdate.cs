using System.Windows.Forms;
using Timer.Config;

namespace Timer.Helpers
{
    public class TimerUpdate
    {
        public static void Update(ref int totalSeconds, System.Windows.Forms.Timer timer, Label TimerTextBox)
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
                TimerTextBox.Text = Strings.timerDefault;
            }

            TimerTextBox.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }
    }
}
