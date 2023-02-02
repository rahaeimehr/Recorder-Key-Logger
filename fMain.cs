using System.Runtime.InteropServices;
using System.IO;


//using OfficeOpenXml;

namespace Recorder
{
    public enum KeyEventType
    {
        KeyPressed = 0,
        KeyReleased = 1
    }
    public partial class fMain : Form
    {
        string datasetFolderPath ="";
        const int RECORD_PERIOD = 60;
        const int NOISE_PERIOD = 5;
        string[] fileNames = {"random" , "text" , "words" };
        string eventsDetail = "";
        long baseTick = 0;
        int sentenceCounter = 0;
        string[] sentences;
        int wordCounter = 0;
        string[] words;

        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int WM_APPCOMMAND = 0x319;
        [DllImport("user32.dll")]

        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int record(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        int countdown,recordPeriod;
        fUserInfo userInfo;
        public fMain()
        {
            Microsoft.VisualBasic.Devices.Audio a = new Microsoft.VisualBasic.Devices.Audio();
            
            InitializeComponent();

            datasetFolderPath =  AppDomain.CurrentDomain.BaseDirectory + @"dataset\";

            Random r = new Random();
            if (!Directory.Exists(datasetFolderPath))
            {
                Directory.CreateDirectory(datasetFolderPath);
            }
            datasetFolderPath += DateTime.Now.Ticks.ToString() + r.Next(0, 1000).ToString().PadLeft(3, '0')+"\\";
            Directory.CreateDirectory(datasetFolderPath);

            userInfo = new fUserInfo();
            if (userInfo.ShowDialog() != DialogResult.OK)
            {
                Close();
                return;
            }
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);

            string msg = "Name:" + userInfo.info.UserName;
            msg += "\nKeyboard:" + userInfo.info.Keyboard;
            msg += "\nStyle:" + userInfo.info.TypingStyle;
            File.WriteAllText($"{datasetFolderPath}info.txt", msg);
        }

        public void registerKeyEvent(long ticks, KeyEventType e, IntPtr wCode, IntPtr lCode)
        {
            
            
            int lParam =(int)(ulong)(lCode);

            /*int repeatCount = (int)(lParam & 0xFFFF);
            int scanCode = (int)((lParam & 0xFF0000) >> 16);
            int extendedKey = (int)((lParam & 0x1000000) >> 24);
            int contextCode = (int)((lParam & 0x20000000) >> 29);
            int previousState = (int)((lParam & 0x40000000) >> 30);
            int transitionState = (int)((lParam & 0x80000000) >> 31);
            string msg = $"Repeat count:  {repeatCount}, Scan code: {scanCode}, Extended key: {extendedKey}," +
                $"Context code: {contextCode}, Previous state: {previousState}, Transition state: {transitionState}";
            */

            addMessage($"{ticks - baseTick},{(int)e},{wCode:X},{((ulong)lCode & 0x0FFF0000) >> 16:X}," +
                $"{Control.IsKeyLocked(Keys.CapsLock)},{Control.ModifierKeys == Keys.Shift}");

/*            if (e == KeyEventType.KeyPressed)
                addMessage($"Down = {wCode:X}, {((ulong)lCode &0x0FFF0000) >> 16:X}," +
                    $"{Control.IsKeyLocked(Keys.CapsLock)} , {Control.ModifierKeys == Keys.Shift}");
            else if(e == KeyEventType.KeyReleased)
                addMessage($"Up = {wCode:X}, {((ulong)lCode & 0x0FFF0000) >> 16:X}," +
                    $"{Control.IsKeyLocked(Keys.CapsLock)} , {Control.ModifierKeys == Keys.Shift}");*/
        }
        public void addMessage(string s)
        {
            lst_EventLogger.Items.Insert(0,s);
            eventsDetail += s + "\n";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            recordPeriod--;
            lCounter.Text = $"Remaining time is {recordPeriod}";
            if (recordPeriod == 0)
            {
                tmr_recording.Stop();
                tmr_recording.Enabled = false;
                tTypeArea.Enabled = false;
                string tmp = $"save recsound \"{datasetFolderPath}{fileNames[0]}.wav\"";
                record(tmp, "", 0, 0);
                record("close recsound", "", 0, 0);
                File.WriteAllText($"{datasetFolderPath}{fileNames[0]}.txt",eventsDetail);
                MessageBox.Show("Thanks! Let's do the next experiment!");
                tabControl1.SelectedTab = tpText;
               
            }
        }

        private void btnRecording_Click(object sender, EventArgs e)
        {
            btnRecording.Enabled = false;
            countdown = NOISE_PERIOD;
            lCounter.Visible = false;
            lCounter.Text = $"{countdown}";
            lCounter.Visible = true;
            eventsDetail = "";
            lst_EventLogger.Items.Clear();
            baseTick = DateTime.Now.Ticks;
            /*
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var package = new ExcelPackage();             
            var worksheet = package.Workbook.Worksheets.Add("Random Text");
            worksheet.Cells[1, 1].Value = "Name";
            worksheet.Cells[1, 2].Value = "Age";
            worksheet.Cells[2, 1].Value = "John Doe";
            worksheet.Cells[2, 2].Value = 30;
            worksheet.Cells[3, 1].Value = "Jane Doe";
            worksheet.Cells[3, 2].Value = 25;
            package.SaveAs($"{fileID}.xlsx");
            */
            record("open new Type waveaudio Alias recsound", "", 0, 0);
            record("record recsound", "", 0, 0);
            tTypeArea.Enabled = false;
            tTypeArea.Text = "";
            tmr_countdown.Enabled = true;

        }

        private void btnStartSentence_Click(object sender, EventArgs e)
        {
            btnStartSentence.Enabled = false;
            tTypedSentence.Enabled = true;
            tTypedSentence.Text = "";
            tTypedSentence.Focus();
            eventsDetail = "";
            lst_EventLogger.Items.Clear();
            record("open new Type waveaudio Alias recsound", "", 0, 0);
            record("record recsound", "", 0, 0);
            baseTick = DateTime.Now.Ticks;
            sentences = File.ReadAllLines("text.txt");
            tPromptSentence.Text = sentences[0];
            SetSentanceCounter();
            

        }
        void SetSentanceCounter()
        {
            lSentenceCounter.Text = $"{sentenceCounter+1}/{sentences.Length}";
        }
        void SetWordCounter()
        {
            lWordCounter.Text = $"{wordCounter + 1}/{words.Length}";
        }

        private void tTypedSentence_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sentenceCounter++;
                if (sentences.Length > sentenceCounter)
                {
                    tPromptSentence.Text = sentences[sentenceCounter];
                    tTypedSentence.Text = "";
                    SetSentanceCounter();
                    tTypedSentence.Focus();
                    
                }
                else
                {
                    string tmp = $"save recsound \"{datasetFolderPath}{fileNames[1]}.wav\"";
                    record(tmp, "", 0, 0);
                    record("close recsound", "", 0, 0);
                    File.WriteAllText($"{datasetFolderPath}{fileNames[1]}.txt", eventsDetail);
                    eventsDetail = "";
                    tTypedSentence.Enabled = false;
                    MessageBox.Show("Done! One more experiment :)");
                    tabControl1.SelectedTab = tpWord;
                   
                }
            }
        }

        private void tTypedWord_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                wordCounter++;
                if (words.Length > wordCounter)
                {
                    tPromptWord.Text = words[wordCounter];
                    tTypedWord.Text = "";
                    tTypedWord.Focus();
                    SetWordCounter();
                }
                else
                {
                    string tmp = $"save recsound \"{datasetFolderPath}{fileNames[2]}.wav\"";
                    record(tmp, "", 0, 0);
                    record("close recsound", "", 0, 0);
                    File.WriteAllText($"{datasetFolderPath}{fileNames[2]}.txt", eventsDetail);
                    eventsDetail = "";
                    tTypedWord.Enabled = false;
                    MessageBox.Show("Thanks for your contribution!");
                    Close();
                }
            }

        }

        private void btnStartWord_Click(object sender, EventArgs e)
        {
            btnStartWord.Enabled = false;
            eventsDetail = "";
            lst_EventLogger.Items.Clear();
            words = File.ReadAllLines("words.txt");
            record("open new Type waveaudio Alias recsound", "", 0, 0);
            record("record recsound", "", 0, 0);
            baseTick = DateTime.Now.Ticks;
            tPromptWord.Text = words[0];
            SetWordCounter();
            wordCounter = 0;
            tTypedWord.Enabled = true;
            tTypedWord.Text = "";
            tTypedWord.Focus();
        }

        private void tmr_countdown_Tick(object sender, EventArgs e)
        {
            countdown--;
            lCounter.Text = $"{countdown}";
            if (countdown == 0)
            {
                tmr_countdown.Enabled = false;
                recordPeriod = RECORD_PERIOD;
                tmr_recording.Interval = 1000;
                tmr_recording.Enabled = true;
                tmr_recording.Start();                
                tTypeArea.Enabled = true;
                tTypeArea.Focus();
            }
        }
    }
}