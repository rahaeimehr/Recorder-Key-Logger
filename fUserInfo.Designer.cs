namespace Recorder
{
    partial class fUserInfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.tKeyboard = new System.Windows.Forms.TextBox();
            this.btn_SaveUserInfo = new System.Windows.Forms.Button();
            this.t_policy = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Keyboard:";
            // 
            // tKeyboard
            // 
            this.tKeyboard.Location = new System.Drawing.Point(105, 25);
            this.tKeyboard.Name = "tKeyboard";
            this.tKeyboard.Size = new System.Drawing.Size(171, 23);
            this.tKeyboard.TabIndex = 1;
            // 
            // btn_SaveUserInfo
            // 
            this.btn_SaveUserInfo.Enabled = false;
            this.btn_SaveUserInfo.Location = new System.Drawing.Point(159, 407);
            this.btn_SaveUserInfo.Name = "btn_SaveUserInfo";
            this.btn_SaveUserInfo.Size = new System.Drawing.Size(130, 23);
            this.btn_SaveUserInfo.TabIndex = 6;
            this.btn_SaveUserInfo.Text = "Proceed ...";
            this.btn_SaveUserInfo.UseVisualStyleBackColor = true;
            this.btn_SaveUserInfo.Click += new System.EventHandler(this.btn_SaveUserInfo_Click);
            // 
            // t_policy
            // 
            this.t_policy.Location = new System.Drawing.Point(37, 88);
            this.t_policy.Multiline = true;
            this.t_policy.Name = "t_policy";
            this.t_policy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.t_policy.Size = new System.Drawing.Size(509, 270);
            this.t_policy.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(36, 369);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(213, 19);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "I agree to the terms and conditions.";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(311, 407);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(130, 23);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Terms and conditions:";
            // 
            // fUserInfo
            // 
            this.AcceptButton = this.btn_SaveUserInfo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(583, 456);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.t_policy);
            this.Controls.Add(this.btn_SaveUserInfo);
            this.Controls.Add(this.tKeyboard);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Participant Info";
            this.Load += new System.EventHandler(this.fUserInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private TextBox tKeyboard;
        private Button btn_SaveUserInfo;
        private TextBox t_policy;
        private CheckBox checkBox1;
        private Button btn_exit;
        private Label label1;
    }
}