using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recorder
{

    public partial class fUserInfo : Form
    {
        public class CUserInfo
        {
            public string UserName { get; set; }
            public string Keyboard{ get; set; }
            public string TypingStyle{ get; set; }
            public CUserInfo()
            {
                UserName = "";
                Keyboard = "";
                TypingStyle = "";
            }
        } 
        public CUserInfo info;
        public fUserInfo()
        {
            InitializeComponent();
            info = new CUserInfo();
        }

        private void btn_SaveUserInfo_Click(object sender, EventArgs e)
        {
            info.UserName = tName.Text.Trim();
            info.Keyboard = tKeyboard.Text.Trim();
            if ((info.UserName == "") || (info.Keyboard == "") || (info.TypingStyle == ""))
                MessageBox.Show("Please fill the fileds!");
            else
                DialogResult = DialogResult.OK;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            info.TypingStyle = "1";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            info.TypingStyle = "2";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            info.TypingStyle = "3";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            info.TypingStyle = "4";
        }
    }
}
