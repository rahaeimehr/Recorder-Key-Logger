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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUserInfo));
            this.label2 = new System.Windows.Forms.Label();
            this.tKeyboard = new System.Windows.Forms.TextBox();
            this.btn_SaveUserInfo = new System.Windows.Forms.Button();
            this.t_policy = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.r_agree = new System.Windows.Forms.RadioButton();
            this.r_disagree = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Keyboard:";
            // 
            // tKeyboard
            // 
            this.tKeyboard.Location = new System.Drawing.Point(120, 33);
            this.tKeyboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tKeyboard.Name = "tKeyboard";
            this.tKeyboard.Size = new System.Drawing.Size(195, 27);
            this.tKeyboard.TabIndex = 1;
            // 
            // btn_SaveUserInfo
            // 
            this.btn_SaveUserInfo.Enabled = false;
            this.btn_SaveUserInfo.Location = new System.Drawing.Point(182, 543);
            this.btn_SaveUserInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SaveUserInfo.Name = "btn_SaveUserInfo";
            this.btn_SaveUserInfo.Size = new System.Drawing.Size(149, 31);
            this.btn_SaveUserInfo.TabIndex = 6;
            this.btn_SaveUserInfo.Text = "Proceed ...";
            this.btn_SaveUserInfo.UseVisualStyleBackColor = true;
            this.btn_SaveUserInfo.Click += new System.EventHandler(this.btn_SaveUserInfo_Click);
            // 
            // t_policy
            // 
            this.t_policy.Location = new System.Drawing.Point(42, 117);
            this.t_policy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.t_policy.Multiline = true;
            this.t_policy.Name = "t_policy";
            this.t_policy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.t_policy.Size = new System.Drawing.Size(581, 231);
            this.t_policy.TabIndex = 7;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(355, 543);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(149, 31);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Terms and conditions:";
            // 
            // r_agree
            // 
            this.r_agree.AutoSize = true;
            this.r_agree.Location = new System.Drawing.Point(42, 491);
            this.r_agree.Name = "r_agree";
            this.r_agree.Size = new System.Drawing.Size(70, 24);
            this.r_agree.TabIndex = 12;
            this.r_agree.TabStop = true;
            this.r_agree.Text = "Agree";
            this.r_agree.UseVisualStyleBackColor = true;
            this.r_agree.CheckedChanged += new System.EventHandler(this.r_agree_CheckedChanged);
            // 
            // r_disagree
            // 
            this.r_disagree.AutoSize = true;
            this.r_disagree.Location = new System.Drawing.Point(198, 491);
            this.r_disagree.Name = "r_disagree";
            this.r_disagree.Size = new System.Drawing.Size(89, 24);
            this.r_disagree.TabIndex = 13;
            this.r_disagree.TabStop = true;
            this.r_disagree.Text = "Disagree";
            this.r_disagree.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(41, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(581, 129);
            this.label3.TabIndex = 11;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // fUserInfo
            // 
            this.AcceptButton = this.btn_SaveUserInfo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(666, 608);
            this.ControlBox = false;
            this.Controls.Add(this.r_disagree);
            this.Controls.Add(this.r_agree);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.t_policy);
            this.Controls.Add(this.btn_SaveUserInfo);
            this.Controls.Add(this.tKeyboard);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private Button btn_exit;
        private Label label1;
        private RadioButton r_agree;
        private RadioButton r_disagree;
        private Label label3;
    }
}