namespace PomodoroApp
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private int lapses = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Timer Started");
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
