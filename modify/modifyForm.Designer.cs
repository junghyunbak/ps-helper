namespace modify
{
    partial class modifyForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.titleBarLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.minimizedBtn = new System.Windows.Forms.Button();
            this.closedBtn = new System.Windows.Forms.Button();
            this.menuLayout = new System.Windows.Forms.TableLayoutPanel();
            this.line = new System.Windows.Forms.Panel();
            this.sidebarLayout = new System.Windows.Forms.TableLayoutPanel();
            this.menuListBox = new System.Windows.Forms.ListBox();
            this.contentTabControl = new System.Windows.Forms.TabControl();
            this.helperTabPage = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.cboFile = new System.Windows.Forms.ComboBox();
            this.editTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.chkPreview = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stopwatchTabPage = new System.Windows.Forms.TabPage();
            this.btnStopwatchSave = new System.Windows.Forms.Button();
            this.cboStopwatchLoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.popupTabPage = new System.Windows.Forms.TabPage();
            this.btnPopupSave = new System.Windows.Forms.Button();
            this.cboPopupTime = new System.Windows.Forms.ComboBox();
            this.cboPopupLoc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnTranslateSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboTarget = new System.Windows.Forms.ComboBox();
            this.cboSource = new System.Windows.Forms.ComboBox();
            this.mainLayout.SuspendLayout();
            this.titleBarLayout.SuspendLayout();
            this.menuLayout.SuspendLayout();
            this.sidebarLayout.SuspendLayout();
            this.contentTabControl.SuspendLayout();
            this.helperTabPage.SuspendLayout();
            this.editTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.stopwatchTabPage.SuspendLayout();
            this.popupTabPage.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.titleBarLayout, 0, 0);
            this.mainLayout.Controls.Add(this.menuLayout, 0, 1);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Margin = new System.Windows.Forms.Padding(0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(782, 553);
            this.mainLayout.TabIndex = 0;
            // 
            // titleBarLayout
            // 
            this.titleBarLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(183)))));
            this.titleBarLayout.ColumnCount = 3;
            this.titleBarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.titleBarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.titleBarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.titleBarLayout.Controls.Add(this.lblTitle, 0, 0);
            this.titleBarLayout.Controls.Add(this.minimizedBtn, 1, 0);
            this.titleBarLayout.Controls.Add(this.closedBtn, 2, 0);
            this.titleBarLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleBarLayout.Location = new System.Drawing.Point(0, 0);
            this.titleBarLayout.Margin = new System.Windows.Forms.Padding(0);
            this.titleBarLayout.Name = "titleBarLayout";
            this.titleBarLayout.RowCount = 1;
            this.titleBarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.titleBarLayout.Size = new System.Drawing.Size(782, 40);
            this.titleBarLayout.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(650, 40);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "설정";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseMove);
            // 
            // minimizedBtn
            // 
            this.minimizedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(183)))));
            this.minimizedBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minimizedBtn.FlatAppearance.BorderSize = 0;
            this.minimizedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizedBtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.minimizedBtn.ForeColor = System.Drawing.Color.White;
            this.minimizedBtn.Location = new System.Drawing.Point(656, 0);
            this.minimizedBtn.Margin = new System.Windows.Forms.Padding(0);
            this.minimizedBtn.Name = "minimizedBtn";
            this.minimizedBtn.Size = new System.Drawing.Size(62, 40);
            this.minimizedBtn.TabIndex = 3;
            this.minimizedBtn.Text = "―";
            this.minimizedBtn.UseVisualStyleBackColor = false;
            this.minimizedBtn.Click += new System.EventHandler(this.minimizedBtn_Click);
            // 
            // closedBtn
            // 
            this.closedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(183)))));
            this.closedBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closedBtn.FlatAppearance.BorderSize = 0;
            this.closedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closedBtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.closedBtn.ForeColor = System.Drawing.Color.White;
            this.closedBtn.Location = new System.Drawing.Point(718, 0);
            this.closedBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closedBtn.Name = "closedBtn";
            this.closedBtn.Size = new System.Drawing.Size(64, 40);
            this.closedBtn.TabIndex = 3;
            this.closedBtn.Text = "×";
            this.closedBtn.UseVisualStyleBackColor = false;
            this.closedBtn.Click += new System.EventHandler(this.closedBtn_Click);
            // 
            // menuLayout
            // 
            this.menuLayout.ColumnCount = 3;
            this.menuLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.menuLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.menuLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.menuLayout.Controls.Add(this.line, 1, 0);
            this.menuLayout.Controls.Add(this.sidebarLayout, 0, 0);
            this.menuLayout.Controls.Add(this.contentTabControl, 2, 0);
            this.menuLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuLayout.Location = new System.Drawing.Point(3, 43);
            this.menuLayout.Name = "menuLayout";
            this.menuLayout.RowCount = 1;
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuLayout.Size = new System.Drawing.Size(776, 507);
            this.menuLayout.TabIndex = 2;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.SystemColors.ControlLight;
            this.line.Dock = System.Windows.Forms.DockStyle.Fill;
            this.line.Location = new System.Drawing.Point(155, 0);
            this.line.Margin = new System.Windows.Forms.Padding(0);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(1, 507);
            this.line.TabIndex = 0;
            // 
            // sidebarLayout
            // 
            this.sidebarLayout.ColumnCount = 1;
            this.sidebarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sidebarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.sidebarLayout.Controls.Add(this.menuListBox, 0, 1);
            this.sidebarLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebarLayout.Location = new System.Drawing.Point(0, 0);
            this.sidebarLayout.Margin = new System.Windows.Forms.Padding(0);
            this.sidebarLayout.Name = "sidebarLayout";
            this.sidebarLayout.RowCount = 3;
            this.sidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.sidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.sidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.sidebarLayout.Size = new System.Drawing.Size(155, 507);
            this.sidebarLayout.TabIndex = 1;
            // 
            // menuListBox
            // 
            this.menuListBox.BackColor = System.Drawing.SystemColors.Control;
            this.menuListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menuListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuListBox.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuListBox.FormattingEnabled = true;
            this.menuListBox.ItemHeight = 27;
            this.menuListBox.Items.AddRange(new object[] {
            "helper",
            "stopwatch",
            "popup",
            "translate"});
            this.menuListBox.Location = new System.Drawing.Point(0, 101);
            this.menuListBox.Margin = new System.Windows.Forms.Padding(0);
            this.menuListBox.Name = "menuListBox";
            this.menuListBox.Size = new System.Drawing.Size(155, 152);
            this.menuListBox.TabIndex = 0;
            this.menuListBox.SelectedIndexChanged += new System.EventHandler(this.menuListBox_SelectedIndexChanged);
            // 
            // contentTabControl
            // 
            this.contentTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.contentTabControl.Controls.Add(this.helperTabPage);
            this.contentTabControl.Controls.Add(this.stopwatchTabPage);
            this.contentTabControl.Controls.Add(this.popupTabPage);
            this.contentTabControl.Controls.Add(this.tabPage3);
            this.contentTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.contentTabControl.Location = new System.Drawing.Point(156, 0);
            this.contentTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.contentTabControl.Name = "contentTabControl";
            this.contentTabControl.SelectedIndex = 0;
            this.contentTabControl.Size = new System.Drawing.Size(620, 507);
            this.contentTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.contentTabControl.TabIndex = 2;
            // 
            // helperTabPage
            // 
            this.helperTabPage.Controls.Add(this.btnSave);
            this.helperTabPage.Controls.Add(this.btnDelete);
            this.helperTabPage.Controls.Add(this.btnChoose);
            this.helperTabPage.Controls.Add(this.cboFile);
            this.helperTabPage.Controls.Add(this.editTabControl);
            this.helperTabPage.Controls.Add(this.chkPreview);
            this.helperTabPage.Controls.Add(this.txtName);
            this.helperTabPage.Controls.Add(this.label6);
            this.helperTabPage.Controls.Add(this.label5);
            this.helperTabPage.Controls.Add(this.label4);
            this.helperTabPage.Controls.Add(this.label1);
            this.helperTabPage.Location = new System.Drawing.Point(4, 5);
            this.helperTabPage.Name = "helperTabPage";
            this.helperTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.helperTabPage.Size = new System.Drawing.Size(612, 498);
            this.helperTabPage.TabIndex = 0;
            this.helperTabPage.Text = "tabPage1";
            this.helperTabPage.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(341, 446);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 26);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(215, 446);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 26);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(110, 405);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(120, 26);
            this.btnChoose.TabIndex = 6;
            this.btnChoose.Text = "choose file";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // cboFile
            // 
            this.cboFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFile.FormattingEnabled = true;
            this.cboFile.Items.AddRange(new object[] {
            "[New File]"});
            this.cboFile.Location = new System.Drawing.Point(109, 35);
            this.cboFile.Name = "cboFile";
            this.cboFile.Size = new System.Drawing.Size(463, 23);
            this.cboFile.TabIndex = 5;
            this.cboFile.SelectedIndexChanged += new System.EventHandler(this.cboFile_SelectedIndexChanged);
            // 
            // editTabControl
            // 
            this.editTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.editTabControl.Controls.Add(this.tabPage1);
            this.editTabControl.Controls.Add(this.tabPage2);
            this.editTabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.editTabControl.Location = new System.Drawing.Point(102, 126);
            this.editTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.editTabControl.Name = "editTabControl";
            this.editTabControl.SelectedIndex = 0;
            this.editTabControl.Size = new System.Drawing.Size(475, 228);
            this.editTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.editTabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(467, 219);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(461, 213);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser1);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(467, 219);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(461, 213);
            this.webBrowser1.TabIndex = 5;
            // 
            // chkPreview
            // 
            this.chkPreview.AutoSize = true;
            this.chkPreview.Location = new System.Drawing.Point(110, 367);
            this.chkPreview.Name = "chkPreview";
            this.chkPreview.Size = new System.Drawing.Size(78, 19);
            this.chkPreview.TabIndex = 3;
            this.chkPreview.Text = "preview";
            this.chkPreview.UseVisualStyleBackColor = true;
            this.chkPreview.CheckedChanged += new System.EventHandler(this.chkPreview_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(463, 25);
            this.txtName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "picture:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "content:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "file:";
            // 
            // stopwatchTabPage
            // 
            this.stopwatchTabPage.Controls.Add(this.btnStopwatchSave);
            this.stopwatchTabPage.Controls.Add(this.cboStopwatchLoc);
            this.stopwatchTabPage.Controls.Add(this.label2);
            this.stopwatchTabPage.Location = new System.Drawing.Point(4, 5);
            this.stopwatchTabPage.Name = "stopwatchTabPage";
            this.stopwatchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.stopwatchTabPage.Size = new System.Drawing.Size(612, 498);
            this.stopwatchTabPage.TabIndex = 1;
            this.stopwatchTabPage.Text = "tabPage2";
            this.stopwatchTabPage.UseVisualStyleBackColor = true;
            // 
            // btnStopwatchSave
            // 
            this.btnStopwatchSave.Location = new System.Drawing.Point(480, 430);
            this.btnStopwatchSave.Name = "btnStopwatchSave";
            this.btnStopwatchSave.Size = new System.Drawing.Size(75, 23);
            this.btnStopwatchSave.TabIndex = 2;
            this.btnStopwatchSave.Text = "save";
            this.btnStopwatchSave.UseVisualStyleBackColor = true;
            this.btnStopwatchSave.Click += new System.EventHandler(this.btnStopwatchSave_Click);
            // 
            // cboStopwatchLoc
            // 
            this.cboStopwatchLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStopwatchLoc.FormattingEnabled = true;
            this.cboStopwatchLoc.Items.AddRange(new object[] {
            "leftTop",
            "RightTop",
            "leftBottom",
            "RightBottom"});
            this.cboStopwatchLoc.Location = new System.Drawing.Point(128, 50);
            this.cboStopwatchLoc.Name = "cboStopwatchLoc";
            this.cboStopwatchLoc.Size = new System.Drawing.Size(121, 23);
            this.cboStopwatchLoc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "location : ";
            // 
            // popupTabPage
            // 
            this.popupTabPage.Controls.Add(this.btnPopupSave);
            this.popupTabPage.Controls.Add(this.cboPopupTime);
            this.popupTabPage.Controls.Add(this.cboPopupLoc);
            this.popupTabPage.Controls.Add(this.label7);
            this.popupTabPage.Controls.Add(this.label3);
            this.popupTabPage.Location = new System.Drawing.Point(4, 5);
            this.popupTabPage.Name = "popupTabPage";
            this.popupTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.popupTabPage.Size = new System.Drawing.Size(612, 498);
            this.popupTabPage.TabIndex = 2;
            this.popupTabPage.Text = "tabPage3";
            this.popupTabPage.UseVisualStyleBackColor = true;
            // 
            // btnPopupSave
            // 
            this.btnPopupSave.Location = new System.Drawing.Point(480, 430);
            this.btnPopupSave.Name = "btnPopupSave";
            this.btnPopupSave.Size = new System.Drawing.Size(75, 23);
            this.btnPopupSave.TabIndex = 2;
            this.btnPopupSave.Text = "save";
            this.btnPopupSave.UseVisualStyleBackColor = true;
            this.btnPopupSave.Click += new System.EventHandler(this.btnPopupSave_Click);
            // 
            // cboPopupTime
            // 
            this.cboPopupTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPopupTime.FormattingEnabled = true;
            this.cboPopupTime.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboPopupTime.Location = new System.Drawing.Point(233, 93);
            this.cboPopupTime.Name = "cboPopupTime";
            this.cboPopupTime.Size = new System.Drawing.Size(87, 23);
            this.cboPopupTime.TabIndex = 1;
            // 
            // cboPopupLoc
            // 
            this.cboPopupLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPopupLoc.FormattingEnabled = true;
            this.cboPopupLoc.Items.AddRange(new object[] {
            "leftBottom",
            "RightBottom"});
            this.cboPopupLoc.Location = new System.Drawing.Point(128, 50);
            this.cboPopupLoc.Name = "cboPopupLoc";
            this.cboPopupLoc.Size = new System.Drawing.Size(192, 23);
            this.cboPopupLoc.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "popup duration (minute) : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "location : ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnTranslateSave);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.cboTarget);
            this.tabPage3.Controls.Add(this.cboSource);
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(612, 498);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnTranslateSave
            // 
            this.btnTranslateSave.Location = new System.Drawing.Point(480, 430);
            this.btnTranslateSave.Name = "btnTranslateSave";
            this.btnTranslateSave.Size = new System.Drawing.Size(75, 23);
            this.btnTranslateSave.TabIndex = 2;
            this.btnTranslateSave.Text = "save";
            this.btnTranslateSave.UseVisualStyleBackColor = true;
            this.btnTranslateSave.Click += new System.EventHandler(this.btnTranslateSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "language : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "to";
            // 
            // cboTarget
            // 
            this.cboTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTarget.FormattingEnabled = true;
            this.cboTarget.Items.AddRange(new object[] {
            "ko",
            "en"});
            this.cboTarget.Location = new System.Drawing.Point(247, 50);
            this.cboTarget.Name = "cboTarget";
            this.cboTarget.Size = new System.Drawing.Size(67, 23);
            this.cboTarget.TabIndex = 0;
            // 
            // cboSource
            // 
            this.cboSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSource.FormattingEnabled = true;
            this.cboSource.Items.AddRange(new object[] {
            "ko",
            "en"});
            this.cboSource.Location = new System.Drawing.Point(136, 50);
            this.cboSource.Name = "cboSource";
            this.cboSource.Size = new System.Drawing.Size(67, 23);
            this.cboSource.TabIndex = 0;
            // 
            // modifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.mainLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "modifyForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.modifyForm_FormClosing);
            this.Load += new System.EventHandler(this.modifyForm_Load);
            this.mainLayout.ResumeLayout(false);
            this.titleBarLayout.ResumeLayout(false);
            this.titleBarLayout.PerformLayout();
            this.menuLayout.ResumeLayout(false);
            this.sidebarLayout.ResumeLayout(false);
            this.contentTabControl.ResumeLayout(false);
            this.helperTabPage.ResumeLayout(false);
            this.helperTabPage.PerformLayout();
            this.editTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.stopwatchTabPage.ResumeLayout(false);
            this.stopwatchTabPage.PerformLayout();
            this.popupTabPage.ResumeLayout(false);
            this.popupTabPage.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel titleBarLayout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button minimizedBtn;
        private System.Windows.Forms.Button closedBtn;
        private System.Windows.Forms.TableLayoutPanel menuLayout;
        private System.Windows.Forms.Panel line;
        private System.Windows.Forms.TableLayoutPanel sidebarLayout;
        private System.Windows.Forms.ListBox menuListBox;
        private System.Windows.Forms.TabControl contentTabControl;
        private System.Windows.Forms.TabPage helperTabPage;
        private System.Windows.Forms.TabPage stopwatchTabPage;
        private System.Windows.Forms.TabPage popupTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboFile;
        private System.Windows.Forms.TabControl editTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.CheckBox chkPreview;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.ComboBox cboStopwatchLoc;
        private System.Windows.Forms.Button btnStopwatchSave;
        private System.Windows.Forms.ComboBox cboPopupLoc;
        private System.Windows.Forms.Button btnPopupSave;
        private System.Windows.Forms.ComboBox cboPopupTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnTranslateSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboTarget;
        private System.Windows.Forms.ComboBox cboSource;
    }
}

