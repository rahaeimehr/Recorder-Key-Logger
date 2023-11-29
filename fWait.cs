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
    public partial class fWait : Form
    {
        int NOISE_PERIOD = 7;
        int countdown;
        public fWait()
        {
            InitializeComponent();
        }

        private void fWait_Load(object sender, EventArgs e)
        {
            countdown = NOISE_PERIOD;
            lCounter.Text = $"{countdown}";
            tmr_countdown.Enabled = true;

        }

        private void tmr_countdown_Tick(object sender, EventArgs e)
        {
            if(countdown>0)
            {
                countdown--;
                lCounter.Text = $"{countdown}";
            }
            else
            {
                tmr_countdown.Enabled=false;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
