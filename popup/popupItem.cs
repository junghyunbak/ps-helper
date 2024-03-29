﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        int lapse = 1;
        string[] spstring;

        public popupItem(int height, string msg)
        {
            this.height = height;
            spstring = msg.Split('|');
            InitializeComponent();
        }

        private void parsingMessage()
        {
            if(spstring[0] == "s") // stopwatch
            {
                lblMessage.Dock = DockStyle.Top;
                chart.Dock = DockStyle.Fill;
                int total = 0;
                for (int i = 1; i < spstring.Length; i++) total += int.Parse(spstring[i]);
                int hour = total / 3600;
                int minute = (total - hour * 3600) / 60;
                int second = total - hour * 3600 - minute * 60;
                string msg = "elapsed time : " + setDigit(hour, minute, second) + "\n";
                lblMessage.Text = msg;
                int n = spstring.Length;
                for(int i = 1; i < n; i++)
                {
                    chart.Series["Series1"].Points.Add(int.Parse(spstring[n-i]));
                }
            }
            else if (spstring[0] == "t" || spstring[0] == "h" || spstring[0] == "c") // translate
            {
                lblMessage.Dock = DockStyle.Fill;
                lblMessage.Padding = new Padding(10, 10, 10, 10);
                lblMessage.Text = spstring[1];
            }
        }

        private string setDigit(int hour, int minute, int second)
        {
            string h = Convert.ToString(hour);
            if (h.Length == 1) h = "0" + h;
            string m = Convert.ToString(minute);
            if (m.Length == 1) m = "0" + m;
            string s = Convert.ToString(second);
            if (s.Length == 1) s = "0" + s;
            return h + ":" + m + ":" + s;
        }

        private string resourcePath = "";

        private void popupItem_Load(object sender, EventArgs e)
        {
            resourcePath = Directory.GetParent(Application.StartupPath).FullName + "\\res\\";
            // end time
            string filePath = resourcePath + "data.txt";
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(new FileStream(
                    filePath,
                    FileMode.Open
                    )
                );
                string[] spstr = sr.ReadLine().Split(' ');
                lapse = int.Parse(spstr[2]);
                sr.Close();
            }
            // back ground color transparent
            this.BackColor = Color.Turquoise;
            this.TransparencyKey = this.BackColor;
            // remove button focus
            lblMessage.Focus();
            // parsing message
            parsingMessage();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            lblMessage.Focus(); // remove button focus
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
