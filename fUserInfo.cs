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
            public string Keyboard{ get; set; }
            public CUserInfo()
            {
                Keyboard = "";
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
            info.Keyboard = tKeyboard.Text.Trim();
            DialogResult = DialogResult.OK;
        }


        private void fUserInfo_Load(object sender, EventArgs e)
        {
            try
            {
                t_policy.Text = System.IO.File.ReadAllText("policy.txt");
            }catch
            {
                MessageBox.Show("The policy file is missed.");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btn_SaveUserInfo.Enabled = checkBox1.Checked;
        }
    }
}
