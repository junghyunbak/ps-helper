using Markdig;
using Markdig.SyntaxHighlighting;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace markdown
{
    public partial class markdownForm : Form
    {
        string fileName = "";
        private string resourcePath = "";
        private Markdig.MarkdownPipeline pipeline;

        public markdownForm(string str)
        {
            InitializeComponent();
            fileName = str;
        }

        private void markdownForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = fileName;
            // markdig
            resourcePath = Directory.GetParent(Application.StartupPath).FullName + "\\res\\";
            string filePath = resourcePath + fileName + ".md";
            StreamReader sr = new StreamReader(new FileStream(
                filePath,
                FileMode.Open
                )
            );
            pipeline = new MarkdownPipelineBuilder()
                .UseAdvancedExtensions()
                .UseSyntaxHighlighting()
                .Build();
            string result = Markdown.ToHtml(sr.ReadToEnd(), pipeline);
            string htmlPath = resourcePath + "main.html";
            string cssLink = "<link rel= \"stylesheet\" href= \"style.css\">\n";
            string incoding = "<meta http-equiv='Content-Type' content='text/html;charset=UTF-8'>\n";
            File.WriteAllText(htmlPath, string.Empty);
            StreamWriter sw = new StreamWriter(new FileStream(
                htmlPath,
                FileMode.Open
                )
            );
            sw.WriteLine(cssLink + incoding + result);
            sw.Close();
            sr.Close();
            webBrowser.Url = new Uri(string.Format("file:///{0}/../res/main.html", Application.StartupPath));
        }

        private void minimizedBtn_Click(object sender, EventArgs e)
        {
            lblTitle.Focus();
            this.WindowState = FormWindowState.Minimized;
        }

        private void closedBtn_Click(object sender, EventArgs e)
        {
            lblTitle.Focus();
            Application.Exit();
        }

        private Point mousePoint;

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void lblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void markdownForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Escape) Application.Exit();
        }
    }
}
