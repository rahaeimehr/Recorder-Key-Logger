using System.Windows.Forms;
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
            ApplicationConfiguration.Initialize();
            fm = new fMain();
            Application.AddMessageFilter(new KeyPressFilter());
            Application.Run(new fMain());
        }
        private class KeyPressFilter : IMessageFilter
        {
            public bool PreFilterMessage(ref Message m)
            {

                if (m.Msg == 0x100 && ((int)m.LParam & 0x40000000) == 0)
                {
                    Control.IsKeyLocked(Keys.CapsLock);
                    fm.addMessage($"Down = {m.WParam}, {((int)m.LParam & 0xFFFF0000) >> 16}");
                }
                if (m.Msg == 0x101)
                {
                    fm.addMessage($"Up = {m.WParam}");
                }

                return false;
            }
        }
    }

}