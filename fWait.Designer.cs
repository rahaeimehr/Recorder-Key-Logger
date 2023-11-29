namespace Recorder
{
    partial class fWait
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lCounter = new System.Windows.Forms.Label();
            this.tmr_countdown = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(64, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please be patient and quiet";
            // 
            // lCounter
            // 
            this.lCounter.AutoSize = true;
            this.lCounter.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lCounter.Location = new System.Drawing.Point(173, 85);
            this.lCounter.Name = "lCounter";
            this.lCounter.Size = new System.Drawing.Size(23, 28);
            this.lCounter.TabIndex = 1;
            this.lCounter.Text = "7";
            // 
            // tmr_countdown
            // 
            this.tmr_countdown.Interval = 1000;
            this.tmr_countdown.Tick += new System.EventHandler(this.tmr_countdown_Tick);
            // 
            // fWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 175);
            this.Controls.Add(this.lCounter);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fWait";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fWait";
            this.Load += new System.EventHandler(this.fWait_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lCounter;
        private System.Windows.Forms.Timer tmr_countdown;
    }
}