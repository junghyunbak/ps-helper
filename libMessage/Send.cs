using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace libMessage
{
    public class Send
    {
        // process communication

        const int WM_COPYDATA = 0x4A;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, ref COPYDATASTRUCT lParam);

        public struct COPYDATASTRUCT
        {
            public IntPtr dwData;
            public int cbData;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpData;
        }

        public void sendMessage(string msg)
        {
            // get popup path
            string startupPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string filePath = startupPath + "\\popup.exe";
            // execute popup
            Process[] processList;
            processList = Process.GetProcessesByName("popup");
            bool running = true;
            while (processList.Length <= 0)
            {
                running = false;
                Process.Start(filePath);
                processList = Process.GetProcessesByName("popup");
            }
            if (!running) Thread.Sleep(500);
            // send message
            byte[] buff = System.Text.Encoding.Default.GetBytes(msg);
            COPYDATASTRUCT cds = new COPYDATASTRUCT();
            cds.dwData = IntPtr.Zero;
            cds.cbData = buff.Length + 1;
            cds.lpData = msg;
            SendMessage(processList[0].MainWindowHandle, WM_COPYDATA, 0, ref cds);
        }
    }
}
