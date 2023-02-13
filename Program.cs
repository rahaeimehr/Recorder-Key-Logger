using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Recorder
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        static fMain fm;
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            fm = new fMain();
            Application.AddMessageFilter(new KeyPressFilter());
            try
            {
                Application.Run(fm);
            }
            catch
            {

            }
        }
        private class KeyPressFilter : IMessageFilter
        {
            public bool PreFilterMessage(ref Message m)
            {

                if (m.Msg == 0x100 && ((int)m.LParam & 0x40000000) == 0)
                {
                    fm.registerKeyEvent(DateTime.Now.Ticks, KeyEventType.KeyPressed, m.WParam, m.LParam);
                }
                if (m.Msg == 0x101)
                {
                    fm.registerKeyEvent(DateTime.Now.Ticks, KeyEventType.KeyReleased, m.WParam, m.LParam);
                }

                return false;
            }
        }
    }

}