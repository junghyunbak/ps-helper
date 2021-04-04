using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace popup
{
    public partial class popupBox : Form
    {
        const int WM_COPYDATA = 0x4A;

        public struct COPYDATASTRUCT
        {
            public IntPtr dwData;
            public int cbData;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpData;
        }

        protected override void WndProc(ref Message m)
        {
            try
            {
                switch (m.Msg)
                {
                    case WM_COPYDATA:
                        COPYDATASTRUCT cds = (COPYDATASTRUCT)m.GetLParam(typeof(COPYDATASTRUCT));
                        formCall(100, cds.lpData);
                        break;
                    default:
                        base.WndProc(ref m);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public popupBox()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // back ground color transparent
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
            // form size
            ratio = 3;
            formWidth = ClientSize.Width / ratio;
            formHeight = 0;
            this.Size = new Size(formWidth, formHeight);
            screenWidth = SystemInformation.VirtualScreen.Width;
            screenHeight = SystemInformation.VirtualScreen.Height;
            // form location
            this.StartPosition = FormStartPosition.Manual;
            x = new int[4] { 0, screenWidth - formWidth, 0, screenWidth - formWidth };
            y = new int[4] { 0, 0, screenHeight - formHeight, screenHeight - formHeight };
            m = new int[4] { formHeight, formHeight, -formHeight, -formHeight };
            pos = 3;
            this.Location = new Point(x[pos], y[pos]);
            // table Layout
            tableLayoutPanel1.RowStyles.Clear();
        }

        private void formCall(int height, string msg)
        {
            popupItem form = new popupItem(height, msg);
            form.TopLevel = false;
            form.TopMost = true;
            form.ChildFormEvent += EventMethod;
            tableLayoutPanel1.RowStyles.Add(new RowStyle {
                SizeType = SizeType.Absolute,
                Height = height 
            });
            tableLayoutPanel1.Controls.Add(form);
            Renew(height);
            form.Show();
        }

        public void Renew(int height)
        {
            this.Top -= height;
            formHeight += height;
            this.Size = new Size(x[pos], formHeight);
            if (this.Top == y[pos]) Application.Exit();
        }

        public void EventMethod(int height)
        {
            Renew(-height);
        }
    }
}
