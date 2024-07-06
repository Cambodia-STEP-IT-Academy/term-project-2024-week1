using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace PomodoroApp
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private int timeLeft;
        private int lapses = 0;
        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
            
        }
        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second interval
            timer.Tick += Timer_Tick;
        }
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            timeLeft = (int)WorkDuration.Value * 60; // Convert minutes to seconds
            UpdateWaitingTimeLabel();
            timer.Start();
            ButtonStart.Enabled = false;
            ButtonStop.Enabled = true;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                UpdateWaitingTimeLabel();
            }
            else
            {
                timer.Stop();
                ButtonStart.Enabled = true;
                ButtonStop.Enabled = false;
                lapses++;
                Lapses.Text = $"Lapses: {lapses}";
                Alarm();
                MessageBox.Show("Time's up! Take a break.");
            }
        }
        private void UpdateWaitingTimeLabel()
        {
            int minutes = timeLeft / 60;
            int seconds = timeLeft % 60;
            WaitingTime.Text = string.Format("{0:D2}:{1:D2}", minutes, seconds);
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Timer Stopped");
        }

        private void WorkDuration_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
