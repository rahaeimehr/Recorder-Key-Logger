using System.Runtime.InteropServices;
using System.IO;

namespace Recorder
{
    public partial class Form1 : Form
    {
        string datasetFolderPath ="";
        string audioFileName = "";
        string fileID = "";
        const int RECORD_PERIOD = 5;
        const int NOISE_PERIOD = 2;

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int record(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        int countdown,recordPeriod;
        public Form1()
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            recordPeriod--;
            label1.Text = $"Remaining time is {recordPeriod}";
            if (recordPeriod == 0)
            {
                timer1.Stop();
                timer1.Enabled = false;
                textBox1.Enabled = false;
                string tmp = $"save recsound '{datasetFolderPath}{DateTime.Now.Ticks}_{fileID}.wav'";
                //tmp = "save recsound d:\\1.wav";
                //tmp = "save recsound \"D:\\Augusta University\\research\\Acoustic Side Channel Attack\\Recorder\\Recorder\\bin\\Debug\\net6.0-windows\\dataset\\638104427825170780_010115.wav'";
                textBox2.Text = tmp;
                record(tmp, "", 0, 0);
                record("close recsound", "", 0, 0);
                MessageBox.Show("done");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label2.Text = DateTime.Now.Ticks.ToString();
            
            if (Control.ModifierKeys != Keys.None)
            {
                label2.Text = Control.ModifierKeys.ToString();
            } 
               
            
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