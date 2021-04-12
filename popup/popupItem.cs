using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace popup
{
    public partial class popupItem : Form
    {
        // delegate event
        public delegate void ChildFormSendDataHandler(int height);
        public event ChildFormSendDataHandler ChildFormEvent;
        // program result
        int height;
        int lapse;
        string msg;

        public popupItem(int height, string msg)
        {
            this.height = height;
            this.msg = msg;
            InitializeComponent();
        }

        private void popupItem_Load(object sender, EventArgs e)
        {
            // end time
            lapse = 1;
            // back ground color transparent
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
            // button design
            closeBtn.Font = new Font(closeBtn.Font, FontStyle.Bold);
            closeBtn.ForeColor = Color.White;
            closeBtn.FlatAppearance.BorderColor = Color.Black;
            // lbl
            lblMessage.ForeColor = Color.White;
            lblMessage.Text = msg;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DateTime startTime = DateTime.Now;

        private void closeTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan span = new TimeSpan(DateTime.Now.Ticks - startTime.Ticks);
            if(lapse == span.Minutes)
            {
                this.Close();
            }
        }

        private void popupItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ChildFormEvent(height);
        }
    }
}
