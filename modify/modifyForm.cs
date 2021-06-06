using Markdig;
using Markdig.SyntaxHighlighting;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace modify
{
    public partial class modifyForm : Form
    {
        public modifyForm()
        {
            InitializeComponent();
        }

        private string resourcePath = "";
        private Markdig.MarkdownPipeline pipeline;

        private void modifyForm_Load(object sender, EventArgs e)
        {
            menuListBox.SelectedIndex = 0;
            resourcePath = Directory.GetParent(Application.StartupPath).FullName + "\\res\\";
            contentTabControl.SelectedIndex = 0;
            pipeline = new MarkdownPipelineBuilder()
                .UseAdvancedExtensions()
                .UseSyntaxHighlighting()
                .Build();
            webBrowser1.Url = new Uri(string.Format("file:///{0}/../res/preview.html", Application.StartupPath));
            // get .md file name
            DirectoryInfo di = new DirectoryInfo(resourcePath);
            foreach (var item in di.GetFiles("*.md"))
            {
                cboFile.Items.Add(Path.GetFileNameWithoutExtension(item.Name));
            }
            if (cboFile.Items.Count >= 2) cboFile.SelectedIndex = 1;
            // location init
            string filePath = resourcePath + "data.txt";
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(new FileStream(
                    filePath,
                    FileMode.Open
                    )
                );
                string[] spstr = sr.ReadLine().Split(' ');
                sr.Close();
                cboStopwatchLoc.SelectedIndex = int.Parse(spstr[0]);
                cboPopupLoc.SelectedIndex = int.Parse(spstr[1]);
                cboPopupTime.SelectedIndex = int.Parse(spstr[2])-1;
                cboSource.SelectedIndex = int.Parse(spstr[3]);
                cboTarget.SelectedIndex = int.Parse(spstr[4]);
            }
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
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void menuListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            contentTabControl.SelectedIndex = menuListBox.SelectedIndex;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = resourcePath;
            ofd.Filter = "그림 파일 (*.jpg, *.jpeg, *.gif, *.png) | *.jpg; *.jpeg; *.gif; *.png";
            ofd.ShowDialog();
            string source = ofd.FileName;
            string fileName = ofd.SafeFileName;
            string target = resourcePath + fileName;
            if (source == "") return;
            if (source == target)
            {
                // file in a resource folder
                // do nothing
            }
            else if (File.Exists(target))
            {
                // overwrite
                if (MessageBox.Show("덮어쓰시겠습니까?", "경고", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    File.Delete(target);
                    File.Copy(source, target);
                }
            }
            else
            {
                File.Copy(source, target);
            }
            // write an image reference in a markdown editor
            richTextBox1.Text += String.Format("\n![][{0}]\n\n[{0}]: {1}\n"
                , Path.GetFileNameWithoutExtension(ofd.FileName)
                , fileName
                );
        }

        private void chkPreview_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPreview.Checked)
            {
                editTabControl.SelectedIndex = 1;
                string result = Markdown.ToHtml(richTextBox1.Text, pipeline);
                string htmlPath = resourcePath + "preview.html";
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
                webBrowser1.Refresh();
            }
            else
            {
                editTabControl.SelectedIndex = 0;
            }
        }

        private void cboFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFile.SelectedItem == null) return;
            string fileName = cboFile.SelectedItem.ToString();
            if (fileName == "[New File]")
            {
                int cnt = 0;
                FileInfo fi;
                do
                {
                    cnt++;
                    fi = new FileInfo(resourcePath + "newFile" + cnt.ToString() + ".md");
                } while (fi.Exists);
                File.Create(fi.FullName).Close();
                cboFile.Items.Add(Path.GetFileNameWithoutExtension(fi.Name));
                cboFile.SelectedIndex = cboFile.Items.Count - 1;
                txtName.Text = cboFile.SelectedItem.ToString();
            }
            else
            {
                txtName.Text = fileName;
                string filePath = resourcePath + fileName + ".md";
                if (!File.Exists(filePath))
                {
                    cboFile.Items.RemoveAt(cboFile.SelectedIndex);
                    txtName.Text = "";
                    return;
                }
                StreamReader sr = new StreamReader(new FileStream(
                    filePath,
                    FileMode.Open
                    )
                );
                string fileContent = sr.ReadToEnd();
                richTextBox1.Text = fileContent;
                sr.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboFile.SelectedIndex == -1) return;
            if (MessageBox.Show("삭제하시겠습니까?", "경고", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                File.Delete(resourcePath + cboFile.SelectedItem.ToString() + ".md");
                cboFile.Items.RemoveAt(cboFile.SelectedIndex);
                txtName.Text = "";
                richTextBox1.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboFile.SelectedIndex == -1) return;
            string fileName = cboFile.SelectedItem.ToString() + ".md";
            string reName = txtName.Text + ".md";
            // update file content
            string filePath = resourcePath + fileName;
            File.WriteAllText(filePath, string.Empty);
            StreamWriter sw = new StreamWriter(new FileStream(
                filePath,
                FileMode.Open
                )
            );
            sw.WriteLine(richTextBox1.Text);
            sw.Close();
            if (txtName.Text.IndexOf(" ") != -1)
            {
                MessageBox.Show("파일명에 공백을 포함할 수 없습니다.");
                return;
            }
            if (txtName.Text == "exit" || txtName.Text == "all")
            {
                MessageBox.Show("사용할 수 없는 파일명입니다.");
                return;
            }
            MessageBox.Show("저장되었습니다.");
            // update file name
            if (fileName != reName)
            {
                if (File.Exists(resourcePath + reName))
                {
                    MessageBox.Show("이미 존재하는 파일명입니다.");
                    return;
                }
                File.Move(resourcePath + fileName, resourcePath + reName);
                cboFile.Items.RemoveAt(cboFile.SelectedIndex);
                cboFile.Items.Add(Path.GetFileNameWithoutExtension(reName));
                cboFile.SelectedIndex = cboFile.Items.Count - 1;
            }
        }

        private void btnPopupSave_Click(object sender, EventArgs e)
        {
            string filePath = resourcePath + "data.txt";
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(new FileStream(
                    filePath,
                    FileMode.Open
                    )
                );
                string[] spstr = sr.ReadLine().Split(' ');
                sr.Close();
                File.WriteAllText(filePath, string.Empty);
                StreamWriter sw = new StreamWriter(new FileStream(
                    filePath,
                    FileMode.Open
                    )
                );
                sw.WriteLine(
                    spstr[0]
                    + " "
                    + cboPopupLoc.SelectedIndex.ToString()
                    + " "
                    + (cboPopupTime.SelectedIndex + 1).ToString()
                    + " "
                    + spstr[3]
                    + " "
                    + spstr[4]
                );
                sw.Close();
            }
            MessageBox.Show("저장되었습니다.");
        }

        private void btnStopwatchSave_Click(object sender, EventArgs e)
        {
            string filePath = resourcePath + "data.txt";
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(new FileStream(
                    filePath,
                    FileMode.Open
                    )
                );
                string[] spstr = sr.ReadLine().Split(' ');
                sr.Close();
                File.WriteAllText(filePath, string.Empty);
                StreamWriter sw = new StreamWriter(new FileStream(
                    filePath,
                    FileMode.Open
                    )
                );
                sw.WriteLine(
                    cboStopwatchLoc.SelectedIndex.ToString()
                    + " "
                    + spstr[1]
                    + " "
                    + spstr[2]
                    + " "
                    + spstr[3]
                    + " "
                    + spstr[4]
                );
                sw.Close();
            }
            MessageBox.Show("저장되었습니다.");
        }

        private void btnTranslateSave_Click(object sender, EventArgs e)
        {
            string filePath = resourcePath + "data.txt";
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(new FileStream(
                    filePath,
                    FileMode.Open
                    )
                );
                string[] spstr = sr.ReadLine().Split(' ');
                sr.Close();
                File.WriteAllText(filePath, string.Empty);
                StreamWriter sw = new StreamWriter(new FileStream(
                    filePath,
                    FileMode.Open
                    )
                );
                sw.WriteLine(
                    spstr[0]
                    + " "
                    + spstr[1]
                    + " "
                    + spstr[2]
                    + " "
                    + cboSource.SelectedIndex.ToString()
                    + " "
                    + cboTarget.SelectedIndex.ToString()
                );
                sw.Close();
            }
            MessageBox.Show("저장되었습니다.");
        }
    }
}
