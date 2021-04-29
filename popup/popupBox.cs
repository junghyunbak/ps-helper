using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Collections;

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
                        formCall(110, cds.lpData);
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
        int formWidth;
        int formHeight;
        int screenWidth;
        int screenHeight;
        int buttonHeight;
        int whitespace;

        private void Form1_Load(object sender, EventArgs e)
        {
            // back ground color transparent
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
            // get screen size
            screenWidth = SystemInformation.VirtualScreen.Width;
            screenHeight = SystemInformation.VirtualScreen.Height;
            // set form size
            ratio = 3;
            formWidth = ClientSize.Width / ratio;
            formHeight = clearBtnLayout.Height;
            this.Size = new Size(formWidth, formHeight);
            this.MaximumSize = new Size(formWidth, screenHeight);
            // calculate real whitespace
            buttonHeight = clearBtn.Height;
            whitespace = (formHeight-buttonHeight)/2;
            // set form location
            pos = 3;
            x = new int[4] { 0, screenWidth - formWidth, 0, screenWidth - formWidth };
            y = new int[4] { 0, 0, screenHeight, screenHeight };
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(x[pos], y[pos] - whitespace);
            // set table Layout
            popupItemPanel.RowStyles.Clear();
        }

        int childCount = 0;
        Queue childHandle = new Queue();

        private void formCall(int height, string msg)
        {
            // make form
            popupItem form = new popupItem(height, msg);
            form.TopLevel = false;
            form.ChildFormEvent += EventMethod;
            form.Padding = new Padding(0, whitespace, 0, 0);
            popupItemPanel.RowStyles.Add(new RowStyle {
                SizeType = SizeType.Absolute,
                Height = height 
            });
            popupItemPanel.Controls.Add(form);
            childCount++;
            // size renew
            Renew(height);
            // form show
            form.Show();
            // keep child form handle
            IntPtr hWnd = form.Handle;
            childHandle.Enqueue(hWnd);
            // check form boundary
            chkFormBoundary();
        }

        public void chkFormBoundary()
        {
            if (this.Top < 0) 
            {
                Form theForm = null;
                while (theForm == null)
                {
                    theForm = getForm((IntPtr)childHandle.Dequeue());
                }
                theForm.Close();
            }
        }

        bool clearBtnActive = false;

        public void Renew(int height)
        {
            this.Top -= height;
            formHeight += height;
            this.Size = new Size(x[pos], formHeight);
            if (childCount == 0)
            {
                this.Close();
            }
            else if (childCount == 1)
            {
                if (clearBtnActive)
                {
                    this.Top += buttonHeight + whitespace;
                    clearBtnActive = false;
                }
            }
            else {
                if (!clearBtnActive)
                {
                    this.Top -= buttonHeight + whitespace;
                    clearBtnActive = true;
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            popupItemPanel.Focus(); // remove button focus
            Form theForm = null;
            while (childHandle.Count > 0)
            {
                theForm = getForm((IntPtr)childHandle.Dequeue());
                if (theForm != null){
                    theForm.Close();
                    Delay(500);
                }
            }
        }

        public void EventMethod(int height)
        {
            childCount--;
            Renew(-height);
        }

        // handle to Form

        static public Form getForm(IntPtr handle)
        {
            return handle == IntPtr.Zero ? null : Control.FromHandle(handle) as Form;
        }

        // delay

        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);
            while (AfterWards >= ThisMoment) {
                Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }

        // hidden timer

        private void hiddenTimer_Tick(object sender, EventArgs e)
        {

        }

        private void popupItemPanel_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
