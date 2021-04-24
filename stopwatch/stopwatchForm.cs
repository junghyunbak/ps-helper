using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using libMessage;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace stopwatch
{
    public partial class stopwatchForm : Form
    {
        public stopwatchForm()
        {
            InitializeComponent();
        }

        int ratio;
        int pos;
        int[] x;
        int[] y;
        int[] m;
        int formWidth;
        int formHeight;
        int screenWidth;
        int screenHeight;

        private void stopwatchForm_Load(object sender, EventArgs e)
        {
            // form size
            ratio = 3;
            formWidth = ClientSize.Width / ratio;
            formHeight = ClientSize.Height / ratio;
            this.Size = new Size(formWidth, formHeight);
            screenWidth = SystemInformation.VirtualScreen.Width;
            screenHeight = SystemInformation.VirtualScreen.Height;
            // form location
            this.StartPosition = FormStartPosition.Manual;
            x = new int[4] { 0, screenWidth - formWidth, 0, screenWidth - formWidth };
            y = new int[4] { 0, 0, screenHeight - formHeight, screenHeight - formHeight };
            m = new int[4] { formWidth, -formWidth, formWidth, -formWidth};
            pos = 1;
            this.Location = new Point(x[pos], y[pos]);
            this.BackColor = Color.FromArgb(230, 230, 230);
            // form border
            FormBorderStyle = FormBorderStyle.None;
            rx = 15;
            ry = 15;
            borderWidth = 3.0f;
            UpdateRegion();
            // set process list
            setProcessList();
        }

        // border

        int rx = 0;
        int ry = 0;
        float borderWidth = 0;
        GraphicsPath borderGp;
        GraphicsPath gp;
        Brush brush = new SolidBrush(Color.FromArgb(210, 210, 210));

        private void UpdateRegion()
        {
            // rounded
            gp = new GraphicsPath();
            borderGp = new GraphicsPath();
            int dx = 2 * rx;
            int dy = 2 * ry;
            gp.AddArc(new Rectangle(0, 0, dx, dy), 180, 90);
            borderGp.AddArc(new RectangleF(borderWidth, borderWidth, dx, dy), 180, 90);
            gp.AddArc(new Rectangle(ClientSize.Width - dx, 0, dx, dy), 270, 90);
            borderGp.AddArc(new RectangleF(ClientSize.Width - dx - borderWidth, borderWidth, dx, dy), 270, 90);
            gp.AddArc(new Rectangle(ClientSize.Width - dx, ClientSize.Height - dy, dx, dy), 0, 90);
            borderGp.AddArc(new RectangleF(ClientSize.Width - dx - borderWidth, ClientSize.Height - dy - borderWidth, dx, dy), 0, 90);
            gp.AddArc(new Rectangle(0, ClientSize.Height - dy, dx, dy), 90, 90);
            borderGp.AddArc(new RectangleF(borderWidth, ClientSize.Height - dy - borderWidth, dx, dy), 90, 90);
            gp.CloseAllFigures();
            borderGp.CloseAllFigures();
            Region = new Region(gp);
        }

        private void stopwatchForm_Paint(object sender, PaintEventArgs e)
        {
            Region r = Region.Clone();
            r.Exclude(new Region(borderGp));
            e.Graphics.FillRegion(brush, r);
        }

        // stopwatch

        private DateTime startTime = DateTime.Now;
        private DateTime endTime;
        string currentTime;
        int second = 0;

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
        [DllImport("user32.dll")]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int SW_SHOWMAXIMIZED = 3;

        /*
            0 : understand
            1 : solution 
            2 : coding & debug
            3 : etc
        */
        int[] step = new int[4] { 0, 0, 0, 0 };
        Dictionary<string, int> dic = new Dictionary<string, int>();

        private void setProcessList()
        {
            dic["chrome"] = 0;
            dic["Photoshop"] = 1;
            dic["gvim"] = 2;
            dic["cmd"] = 2;
        }

        private void stopwatch_Tick(object sender, EventArgs e)
        {
            TimeSpan span = new TimeSpan(DateTime.Now.Ticks - startTime.Ticks + endTime.Ticks);
            currentTime = span.ToString("hh\\:mm\\:ss\\.ffffff");
            lblResult.Text = span.ToString("hh\\:mm\\:ss");
            if (second != span.Seconds)
            {
                IntPtr handle = IntPtr.Zero;
                uint pid = 0;
                Process ps = null;
                handle = GetForegroundWindow();
                GetWindowThreadProcessId(handle, out pid);
                ps = Process.GetProcessById((int)pid);
                if (dic.ContainsKey(ps.ProcessName)) step[dic[ps.ProcessName]]++;
                else step[3]++;
                second = span.Seconds;
            }
        }

        private void pauseResumeBtn_Click(object sender, EventArgs e)
        {
            if (pauseResumeBtn.Text == "∥")
            {
                pauseResumeBtn.Text = "▶";
                endTime = DateTime.Parse(currentTime);
            }
            else
            {
                pauseResumeBtn.Text = "∥";
                startTime = DateTime.Now;
            }
            stopwatch.Enabled = !stopwatch.Enabled;
        }

        // close

        Send post = new Send();

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizedBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void stopwatchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            string msg = "s";
            for (int i = 0; i < 4; i++)
            {
                msg += '.';
                msg += Convert.ToString(step[i]);
            }
            post.sendMessage(msg);
        }
    }
}
