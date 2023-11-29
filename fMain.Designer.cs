namespace Recorder
{
    partial class fMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lst_EventLogger = new System.Windows.Forms.ListBox();
            this.btnRecording = new System.Windows.Forms.Button();
            this.tmr_recording = new System.Windows.Forms.Timer(this.components);
            this.lCounter = new System.Windows.Forms.Label();
            this.tmr_countdown = new System.Windows.Forms.Timer(this.components);
            this.lGeneralMessage = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpRandom = new System.Windows.Forms.TabPage();
            this.tTypeArea = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpText = new System.Windows.Forms.TabPage();
            this.lSentenceCounter = new System.Windows.Forms.Label();
            this.btnStartSentence = new System.Windows.Forms.Button();
            this.tTypedSentence = new System.Windows.Forms.TextBox();
            this.tPromptSentence = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tpWord = new System.Windows.Forms.TabPage();
            this.lWordCounter = new System.Windows.Forms.Label();
            this.btnStartWord = new System.Windows.Forms.Button();
            this.tTypedWord = new System.Windows.Forms.TextBox();
            this.tPromptWord = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tpRandom.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tpText.SuspendLayout();
            this.tpWord.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_EventLogger
            // 
            this.lst_EventLogger.BackColor = System.Drawing.Color.Teal;
            this.lst_EventLogger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_EventLogger.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lst_EventLogger.FormattingEnabled = true;
            this.lst_EventLogger.ItemHeight = 15;
            this.lst_EventLogger.Location = new System.Drawing.Point(0, 0);
            this.lst_EventLogger.Name = "lst_EventLogger";
            this.lst_EventLogger.Size = new System.Drawing.Size(472, 100);
            this.lst_EventLogger.TabIndex = 0;
            // 
            // btnRecording
            // 
            this.btnRecording.Location = new System.Drawing.Point(24, 62);
            this.btnRecording.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecording.Name = "btnRecording";
            this.btnRecording.Size = new System.Drawing.Size(115, 29);
            this.btnRecording.TabIndex = 0;
            this.btnRecording.Text = "Start Recording";
            this.btnRecording.UseVisualStyleBackColor = true;
            this.btnRecording.Click += new System.EventHandler(this.btnRecording_Click);
            // 
            // tmr_recording
            // 
            this.tmr_recording.Interval = 1000;
            this.tmr_recording.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lCounter
            // 
            this.lCounter.AutoSize = true;
            this.lCounter.Location = new System.Drawing.Point(158, 69);
            this.lCounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lCounter.Name = "lCounter";
            this.lCounter.Size = new System.Drawing.Size(97, 15);
            this.lCounter.TabIndex = 1;
            this.lCounter.Text = "Get ready to type";
            // 
            // tmr_countdown
            // 
            this.tmr_countdown.Interval = 1000;
            this.tmr_countdown.Tick += new System.EventHandler(this.tmr_countdown_Tick);
            // 
            // lGeneralMessage
            // 
            this.lGeneralMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lGeneralMessage.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lGeneralMessage.ForeColor = System.Drawing.Color.Red;
            this.lGeneralMessage.Location = new System.Drawing.Point(0, 0);
            this.lGeneralMessage.Name = "lGeneralMessage";
            this.lGeneralMessage.Size = new System.Drawing.Size(472, 40);
            this.lGeneralMessage.TabIndex = 5;
            this.lGeneralMessage.Text = "Please do not talk while recording!";
            this.lGeneralMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpRandom);
            this.tabControl1.Controls.Add(this.tpText);
            this.tabControl1.Controls.Add(this.tpWord);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(472, 404);
            this.tabControl1.TabIndex = 6;
            // 
            // tpRandom
            // 
            this.tpRandom.Controls.Add(this.tTypeArea);
            this.tpRandom.Controls.Add(this.panel2);
            this.tpRandom.Location = new System.Drawing.Point(4, 24);
            this.tpRandom.Name = "tpRandom";
            this.tpRandom.Padding = new System.Windows.Forms.Padding(3);
            this.tpRandom.Size = new System.Drawing.Size(464, 376);
            this.tpRandom.TabIndex = 0;
            this.tpRandom.Text = "Random text";
            this.tpRandom.UseVisualStyleBackColor = true;
            // 
            // tTypeArea
            // 
            this.tTypeArea.BackColor = System.Drawing.Color.Black;
            this.tTypeArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tTypeArea.Enabled = false;
            this.tTypeArea.ForeColor = System.Drawing.Color.White;
            this.tTypeArea.Location = new System.Drawing.Point(3, 112);
            this.tTypeArea.Margin = new System.Windows.Forms.Padding(1);
            this.tTypeArea.Multiline = true;
            this.tTypeArea.Name = "tTypeArea";
            this.tTypeArea.Size = new System.Drawing.Size(458, 261);
            this.tTypeArea.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lCounter);
            this.panel2.Controls.Add(this.btnRecording);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 109);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Do not correct your typos (NO backspaces)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "In this section, please type a fake email or essay. ";
            // 
            // tpText
            // 
            this.tpText.Controls.Add(this.lSentenceCounter);
            this.tpText.Controls.Add(this.btnStartSentence);
            this.tpText.Controls.Add(this.tTypedSentence);
            this.tpText.Controls.Add(this.tPromptSentence);
            this.tpText.Controls.Add(this.label5);
            this.tpText.Controls.Add(this.label4);
            this.tpText.Controls.Add(this.label3);
            this.tpText.Location = new System.Drawing.Point(4, 24);
            this.tpText.Name = "tpText";
            this.tpText.Padding = new System.Windows.Forms.Padding(3);
            this.tpText.Size = new System.Drawing.Size(464, 376);
            this.tpText.TabIndex = 1;
            this.tpText.Text = "Specific Text";
            this.tpText.UseVisualStyleBackColor = true;
            // 
            // lSentenceCounter
            // 
            this.lSentenceCounter.AutoSize = true;
            this.lSentenceCounter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lSentenceCounter.ForeColor = System.Drawing.Color.Maroon;
            this.lSentenceCounter.Location = new System.Drawing.Point(8, 155);
            this.lSentenceCounter.Name = "lSentenceCounter";
            this.lSentenceCounter.Size = new System.Drawing.Size(34, 21);
            this.lSentenceCounter.TabIndex = 6;
            this.lSentenceCounter.Text = "----";
            // 
            // btnStartSentence
            // 
            this.btnStartSentence.Location = new System.Drawing.Point(183, 82);
            this.btnStartSentence.Name = "btnStartSentence";
            this.btnStartSentence.Size = new System.Drawing.Size(75, 23);
            this.btnStartSentence.TabIndex = 5;
            this.btnStartSentence.Text = "Start";
            this.btnStartSentence.UseVisualStyleBackColor = true;
            this.btnStartSentence.Click += new System.EventHandler(this.btnStartSentence_Click);
            // 
            // tTypedSentence
            // 
            this.tTypedSentence.Enabled = false;
            this.tTypedSentence.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tTypedSentence.Location = new System.Drawing.Point(8, 223);
            this.tTypedSentence.Multiline = true;
            this.tTypedSentence.Name = "tTypedSentence";
            this.tTypedSentence.Size = new System.Drawing.Size(444, 29);
            this.tTypedSentence.TabIndex = 4;
            this.tTypedSentence.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tTypedSentence_KeyUp);
            // 
            // tPromptSentence
            // 
            this.tPromptSentence.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tPromptSentence.Location = new System.Drawing.Point(8, 188);
            this.tPromptSentence.Name = "tPromptSentence";
            this.tPromptSentence.ReadOnly = true;
            this.tPromptSentence.Size = new System.Drawing.Size(444, 29);
            this.tPromptSentence.TabIndex = 4;
            this.tPromptSentence.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Do not correct your typos (NO backspaces)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Press Enter after typing each sentence.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(410, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "In this section, I will show some English words one by one. Please type them.";
            // 
            // tpWord
            // 
            this.tpWord.Controls.Add(this.lWordCounter);
            this.tpWord.Controls.Add(this.btnStartWord);
            this.tpWord.Controls.Add(this.tTypedWord);
            this.tpWord.Controls.Add(this.tPromptWord);
            this.tpWord.Controls.Add(this.label6);
            this.tpWord.Controls.Add(this.label7);
            this.tpWord.Controls.Add(this.label8);
            this.tpWord.Location = new System.Drawing.Point(4, 24);
            this.tpWord.Name = "tpWord";
            this.tpWord.Padding = new System.Windows.Forms.Padding(3);
            this.tpWord.Size = new System.Drawing.Size(464, 376);
            this.tpWord.TabIndex = 2;
            this.tpWord.Text = "Fixed Words";
            this.tpWord.UseVisualStyleBackColor = true;
            // 
            // lWordCounter
            // 
            this.lWordCounter.AutoSize = true;
            this.lWordCounter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lWordCounter.ForeColor = System.Drawing.Color.Maroon;
            this.lWordCounter.Location = new System.Drawing.Point(131, 151);
            this.lWordCounter.Name = "lWordCounter";
            this.lWordCounter.Size = new System.Drawing.Size(34, 21);
            this.lWordCounter.TabIndex = 12;
            this.lWordCounter.Text = "----";
            // 
            // btnStartWord
            // 
            this.btnStartWord.Location = new System.Drawing.Point(183, 82);
            this.btnStartWord.Name = "btnStartWord";
            this.btnStartWord.Size = new System.Drawing.Size(75, 23);
            this.btnStartWord.TabIndex = 11;
            this.btnStartWord.Text = "Start";
            this.btnStartWord.UseVisualStyleBackColor = true;
            this.btnStartWord.Click += new System.EventHandler(this.btnStartWord_Click);
            // 
            // tTypedWord
            // 
            this.tTypedWord.Enabled = false;
            this.tTypedWord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tTypedWord.Location = new System.Drawing.Point(131, 221);
            this.tTypedWord.Multiline = true;
            this.tTypedWord.Name = "tTypedWord";
            this.tTypedWord.Size = new System.Drawing.Size(175, 29);
            this.tTypedWord.TabIndex = 9;
            this.tTypedWord.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tTypedWord_KeyUp);
            // 
            // tPromptWord
            // 
            this.tPromptWord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tPromptWord.Location = new System.Drawing.Point(131, 186);
            this.tPromptWord.Name = "tPromptWord";
            this.tPromptWord.ReadOnly = true;
            this.tPromptWord.Size = new System.Drawing.Size(175, 29);
            this.tPromptWord.TabIndex = 10;
            this.tPromptWord.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Do not correct your typos (NO backspaces)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Press Enter after typing each word.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(430, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "In this section, I will show some English sentences one by one. Please type them." +
    "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lst_EventLogger);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 100);
            this.panel1.TabIndex = 7;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 544);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lGeneralMessage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataSet Generator";
            this.tabControl1.ResumeLayout(false);
            this.tpRandom.ResumeLayout(false);
            this.tpRandom.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tpText.ResumeLayout(false);
            this.tpText.PerformLayout();
            this.tpWord.ResumeLayout(false);
            this.tpWord.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRecording;
        private System.Windows.Forms.Timer tmr_recording;
        private Label lCounter;
        private System.Windows.Forms.Timer tmr_countdown;
        private Label lGeneralMessage;
        private TabControl tabControl1;
        private TabPage tpRandom;
        private TabPage tpText;
        private Panel panel1;
        private ListBox lst_EventLogger;
        private Panel panel2;
        private TabPage tpWord;
        private Label label1;
        private Label label2;
        private TextBox tTypeArea;
        private Button btnStartSentence;
        private TextBox tTypedSentence;
        private TextBox tPromptSentence;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnStartWord;
        private TextBox tTypedWord;
        private TextBox tPromptWord;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lSentenceCounter;
        private Label lWordCounter;
    }
}