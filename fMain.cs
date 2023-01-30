using System.Runtime.InteropServices;
using System.IO;

namespace Recorder
{
    public partial class fMain : Form
    {
        string datasetFolderPath ="";
        string fileID = "";
        const int RECORD_PERIOD = 5;
        const int NOISE_PERIOD = 2;

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int record(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        int countdown,recordPeriod;
        public fMain()
        {
            Microsoft.VisualBasic.Devices.Audio a = new Microsoft.VisualBasic.Devices.Audio();
            
            InitializeComponent();

            datasetFolderPath =  AppDomain.CurrentDomain.BaseDirectory + @"dataset\";
            Random r = new Random();

            fileID = r.Next(0, 1000000).ToString().PadLeft(6,'0');
            if (!Directory.Exists(datasetFolderPath))
            {
                Directory.CreateDirectory(datasetFolderPath);
                Console.WriteLine("Folder created successfully at: " + datasetFolderPath);
            }
            else
            {
                Console.WriteLine("Folder already exists at: " + datasetFolderPath);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            countdown = NOISE_PERIOD;
            label1.Text = $"{countdown}";
            record("open new Type waveaudio Alias recsound", "", 0, 0);
            record("record recsound", "", 0, 0);
            label1.Visible = true;
            textBox1.Enabled = false;
            textBox1.Text = "";
            tmr_countdown.Enabled = true;
        }
        public void addMessage(string s)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            recordPeriod--;
            label1.Text = $"Remaining time is {recordPeriod}";
            if (recordPeriod == 0)
            {
                timer1.Stop();
                timer1.Enabled = false;
                textBox1.Enabled = false;
                string tmp = $"save recsound \"{datasetFolderPath}{DateTime.Now.Ticks}_{fileID}.wav\"";
                record(tmp, "", 0, 0);
                record("close recsound", "", 0, 0);
                MessageBox.Show("done");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
               
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = e.KeyCode.ToString();
        }

        private void tmr_countdown_Tick(object sender, EventArgs e)
        {
            countdown--;
            label1.Text = $"{countdown}";
            if (countdown == 0)
            {
                tmr_countdown.Enabled = false;
                recordPeriod = RECORD_PERIOD;
                timer1.Interval = 1000;
                timer1.Enabled = true;
                timer1.Start();                
                textBox1.Enabled = true;
                textBox1.Focus();
            }
        }
    }
}