using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        int timerSeconds = 0;
        int stopwatchSeconds = 0;
       
        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 1000;
            timer2.Interval = 1000;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            stopwatchSeconds = 0;
            label6.Text = "00:00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerSeconds > 0)
            {
                timerSeconds--;
                label3.Text = TimeSpan.FromSeconds(timerSeconds).ToString(@"mm\:ss");
            }
            else
            {
                timer1.Stop();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Start();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int minutes) && (int.TryParse(textBox2.Text, out int seconds))) 
            {
                timerSeconds = minutes * 60 + seconds;
                label3.Text = TimeSpan.FromSeconds(timerSeconds).ToString(@"mm\:ss");
                timer1.Start();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            stopwatchSeconds++;
            label6.Text = TimeSpan.FromSeconds(stopwatchSeconds).ToString(@"mm\ss");
        }
    }
}
