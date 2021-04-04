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
        // form size
        int ratio;
        int formWidth;
        int formHeight;
        // program result
        int height;
        string msg;

        public popupItem(int height, string msg)
        {
            this.height = height;
            this.msg = msg;
            InitializeComponent();
        }

        private void popupItem_Load(object sender, EventArgs e)
        {
            // back ground color transparent
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
            // form size
            ratio = 3;
            formWidth = ClientSize.Width / ratio;
            formHeight = ClientSize.Height;
            this.Size = new Size(formWidth, formHeight);
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
            this.ChildFormEvent(height);
            this.Close();
        }
    }
}
