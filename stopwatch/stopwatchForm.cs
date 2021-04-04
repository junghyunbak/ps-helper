using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using libMessage;

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
        int fontSize;
        int formWidth;
        int formHeight;
        int screenWidth;
        int screenHeight;

        private void stopwatchForm_Load(object sender, EventArgs e)
        {
            // label design
            fontSize = 23;
            lblResult.Text = "00:00:00";
            lblResult.ForeColor = Color.FromArgb(171, 171, 171);
            lblResult.Font = new Font("굴림", fontSize, FontStyle.Bold);
            // button design 
            pauseResumeBtn.Font = new Font(pauseResumeBtn.Font, FontStyle.Bold);
            pauseResumeBtn.ForeColor = Color.FromArgb(171, 171, 171);
            pauseResumeBtn.FlatAppearance.BorderColor = Color.FromArgb(230, 230, 230);
            closeBtn.Font = new Font(closeBtn.Font, FontStyle.Bold);
            closeBtn.ForeColor = Color.FromArgb(171, 171, 171);
            closeBtn.FlatAppearance.BorderColor = Color.FromArgb(230, 230, 230);
            minimizedBtn.Font = new Font(minimizedBtn.Font, FontStyle.Bold);
            minimizedBtn.ForeColor = Color.FromArgb(171, 171, 171);
            minimizedBtn.FlatAppearance.BorderColor = Color.FromArgb(230, 230, 230);
            // form size
            ratio = 3;
            formWidth = ClientSize.Width/ratio;
            formHeight = ClientSize.Height/ratio;
            this.Size = new Size(formWidth, formHeight);
            screenWidth = SystemInformation.VirtualScreen.Width;
            screenHeight = SystemInformation.VirtualScreen.Height;
            // form location
            this.StartPosition = FormStartPosition.Manual;
            x = new int[4] { 0, screenWidth-formWidth, 0, screenWidth-formWidth};
            y = new int[4] { 0, 0, screenHeight-formHeight, screenHeight-formHeight};
            m = new int[4] { formHeight, formHeight, -formHeight, -formHeight};
            pos = 1;
            this.Location = new Point(x[pos], y[pos]);
            this.BackColor = Color.FromArgb(230, 230, 230);
            // form border
            FormBorderStyle = FormBorderStyle.None;
            rx = 15;
            ry = 15;
            borderWidth = 3.0f;
            UpdateRegion();
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

        private void stopwatch_Tick(object sender, EventArgs e)
        {
            TimeSpan span = new TimeSpan(DateTime.Now.Ticks - startTime.Ticks + endTime.Ticks);
            currentTime = span.ToString("hh\\:mm\\:ss\\.ffffff");
            lblResult.Text = span.ToString("hh\\:mm\\:ss");
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
            post.sendMessage("elapsed time : " + lblResult.Text);
        }

        // form move

        private DateTime start;

        public void moveForm()
        {
            int ny = y[pos] + m[pos];
            if(this.Top != ny)
            {
                start = DateTime.Now;
                timer.Enabled = true;
                this.Top = ny;
            }
        }

        private void topLeftPanel_MouseEnter(object sender, EventArgs e)
        {
            if(pos == 0) moveForm();
        }

        private void topRightPanel_MouseEnter(object sender, EventArgs e)
        {
            if(pos == 1) moveForm();
        }

        private void bottomRightPanel_MouseEnter(object sender, EventArgs e)
        {
            if(pos == 3) moveForm();
        }

        private void bottomLeftPanel_MouseEnter(object sender, EventArgs e)
        {
            if(pos == 2) moveForm();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan span = new TimeSpan(DateTime.Now.Ticks - start.Ticks);
            Console.WriteLine(span.Seconds);
            if (span.Seconds == 4)
            {
                this.Top = y[pos];
                timer.Enabled = false;
            }
        }
    }
}
