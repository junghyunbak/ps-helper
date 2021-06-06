namespace stopwatch
{
    partial class stopwatchForm
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
            this.components = new System.ComponentModel.Container();
            this.stopwatch = new System.Windows.Forms.Timer(this.components);
            this.pauseResumeBtn = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.middleLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnLeft = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tblLogPage = new System.Windows.Forms.TableLayoutPanel();
            this.tblLog = new System.Windows.Forms.TableLayoutPanel();
            this.lblLog = new System.Windows.Forms.Label();
            this.txtExponent = new System.Windows.Forms.TextBox();
            this.lbLogNotice = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnRight = new System.Windows.Forms.Button();
            this.topLayout = new System.Windows.Forms.TableLayoutPanel();
            this.minimizedBtn = new System.Windows.Forms.Button();
            this.tblCombPage = new System.Windows.Forms.TableLayoutPanel();
            this.lblCombNotice = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCombN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCombR = new System.Windows.Forms.TextBox();
            this.mainLayout.SuspendLayout();
            this.middleLayout.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tblLogPage.SuspendLayout();
            this.tblLog.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.topLayout.SuspendLayout();
            this.tblCombPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stopwatch
            // 
            this.stopwatch.Enabled = true;
            this.stopwatch.Tick += new System.EventHandler(this.stopwatch_Tick);
            // 
            // pauseResumeBtn
            // 
            this.pauseResumeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pauseResumeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pauseResumeBtn.FlatAppearance.BorderSize = 0;
            this.pauseResumeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.pauseResumeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.pauseResumeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseResumeBtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pauseResumeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.pauseResumeBtn.Location = new System.Drawing.Point(546, 6);
            this.pauseResumeBtn.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pauseResumeBtn.Name = "pauseResumeBtn";
            this.pauseResumeBtn.Size = new System.Drawing.Size(117, 91);
            this.pauseResumeBtn.TabIndex = 1;
            this.pauseResumeBtn.TabStop = false;
            this.pauseResumeBtn.Text = "∥";
            this.pauseResumeBtn.UseVisualStyleBackColor = true;
            this.pauseResumeBtn.Click += new System.EventHandler(this.pauseResumeBtn_Click);
            // 
            // lblResult
            // 
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResult.Font = new System.Drawing.Font("Verdana", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.lblResult.Location = new System.Drawing.Point(3, 3);
            this.lblResult.Margin = new System.Windows.Forms.Padding(0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(620, 179);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "label1";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeBtn
            // 
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.closeBtn.Location = new System.Drawing.Point(663, 6);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(117, 91);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.TabStop = false;
            this.closeBtn.Text = "×";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // mainLayout
            // 
            this.mainLayout.BackColor = System.Drawing.Color.Transparent;
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.middleLayout, 0, 1);
            this.mainLayout.Controls.Add(this.topLayout, 0, 0);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Margin = new System.Windows.Forms.Padding(0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 3;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainLayout.Size = new System.Drawing.Size(800, 400);
            this.mainLayout.TabIndex = 4;
            // 
            // middleLayout
            // 
            this.middleLayout.BackColor = System.Drawing.Color.Transparent;
            this.middleLayout.ColumnCount = 3;
            this.middleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.middleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.middleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.middleLayout.Controls.Add(this.btnLeft, 0, 0);
            this.middleLayout.Controls.Add(this.tabControl1, 1, 0);
            this.middleLayout.Controls.Add(this.btnRight, 2, 0);
            this.middleLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleLayout.Location = new System.Drawing.Point(0, 100);
            this.middleLayout.Margin = new System.Windows.Forms.Padding(0);
            this.middleLayout.Name = "middleLayout";
            this.middleLayout.RowCount = 1;
            this.middleLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.middleLayout.Size = new System.Drawing.Size(800, 200);
            this.middleLayout.TabIndex = 1;
            // 
            // btnLeft
            // 
            this.btnLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btnLeft.Location = new System.Drawing.Point(10, 0);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(70, 200);
            this.btnLeft.TabIndex = 6;
            this.btnLeft.TabStop = false;
            this.btnLeft.Text = "〈";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(83, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(634, 194);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tabPage1.Controls.Add(this.lblResult);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(626, 185);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tabPage2.Controls.Add(this.tblLogPage);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(626, 185);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // tblLogPage
            // 
            this.tblLogPage.ColumnCount = 1;
            this.tblLogPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLogPage.Controls.Add(this.tblLog, 0, 0);
            this.tblLogPage.Controls.Add(this.lbLogNotice, 0, 1);
            this.tblLogPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLogPage.Location = new System.Drawing.Point(3, 3);
            this.tblLogPage.Name = "tblLogPage";
            this.tblLogPage.RowCount = 2;
            this.tblLogPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblLogPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblLogPage.Size = new System.Drawing.Size(620, 179);
            this.tblLogPage.TabIndex = 2;
            // 
            // tblLog
            // 
            this.tblLog.ColumnCount = 2;
            this.tblLog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblLog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tblLog.Controls.Add(this.lblLog, 0, 0);
            this.tblLog.Controls.Add(this.txtExponent, 1, 0);
            this.tblLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLog.Location = new System.Drawing.Point(3, 3);
            this.tblLog.Name = "tblLog";
            this.tblLog.RowCount = 1;
            this.tblLog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLog.Size = new System.Drawing.Size(614, 119);
            this.tblLog.TabIndex = 1;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLog.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.lblLog.Location = new System.Drawing.Point(3, 0);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(208, 119);
            this.lblLog.TabIndex = 0;
            this.lblLog.Text = "Log₂";
            this.lblLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtExponent
            // 
            this.txtExponent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExponent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtExponent.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExponent.Location = new System.Drawing.Point(214, 48);
            this.txtExponent.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.txtExponent.Name = "txtExponent";
            this.txtExponent.Size = new System.Drawing.Size(390, 23);
            this.txtExponent.TabIndex = 2;
            this.txtExponent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExponent_KeyPress);
            // 
            // lbLogNotice
            // 
            this.lbLogNotice.AutoSize = true;
            this.lbLogNotice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLogNotice.Font = new System.Drawing.Font("Verdana", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.lbLogNotice.Location = new System.Drawing.Point(3, 125);
            this.lbLogNotice.Name = "lbLogNotice";
            this.lbLogNotice.Size = new System.Drawing.Size(614, 54);
            this.lbLogNotice.TabIndex = 2;
            this.lbLogNotice.Text = "press enter key";
            this.lbLogNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tabPage3.Controls.Add(this.tblCombPage);
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(626, 185);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // btnRight
            // 
            this.btnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btnRight.Location = new System.Drawing.Point(720, 0);
            this.btnRight.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(70, 200);
            this.btnRight.TabIndex = 8;
            this.btnRight.TabStop = false;
            this.btnRight.Text = "〉";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // topLayout
            // 
            this.topLayout.BackColor = System.Drawing.Color.Transparent;
            this.topLayout.ColumnCount = 5;
            this.topLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.topLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.topLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.topLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.topLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.topLayout.Controls.Add(this.minimizedBtn, 1, 0);
            this.topLayout.Controls.Add(this.pauseResumeBtn, 2, 0);
            this.topLayout.Controls.Add(this.closeBtn, 3, 0);
            this.topLayout.Location = new System.Drawing.Point(0, 0);
            this.topLayout.Margin = new System.Windows.Forms.Padding(0);
            this.topLayout.Name = "topLayout";
            this.topLayout.RowCount = 1;
            this.topLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topLayout.Size = new System.Drawing.Size(792, 97);
            this.topLayout.TabIndex = 0;
            // 
            // minimizedBtn
            // 
            this.minimizedBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minimizedBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.minimizedBtn.FlatAppearance.BorderSize = 0;
            this.minimizedBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimizedBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minimizedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizedBtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.minimizedBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.minimizedBtn.Location = new System.Drawing.Point(429, 6);
            this.minimizedBtn.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.minimizedBtn.Name = "minimizedBtn";
            this.minimizedBtn.Size = new System.Drawing.Size(117, 91);
            this.minimizedBtn.TabIndex = 4;
            this.minimizedBtn.TabStop = false;
            this.minimizedBtn.Text = "＿";
            this.minimizedBtn.UseVisualStyleBackColor = true;
            this.minimizedBtn.Click += new System.EventHandler(this.minimizedBtn_Click);
            // 
            // tblCombPage
            // 
            this.tblCombPage.ColumnCount = 1;
            this.tblCombPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCombPage.Controls.Add(this.lblCombNotice, 0, 1);
            this.tblCombPage.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tblCombPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCombPage.Location = new System.Drawing.Point(3, 3);
            this.tblCombPage.Name = "tblCombPage";
            this.tblCombPage.RowCount = 2;
            this.tblCombPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblCombPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblCombPage.Size = new System.Drawing.Size(620, 179);
            this.tblCombPage.TabIndex = 0;
            // 
            // lblCombNotice
            // 
            this.lblCombNotice.AutoSize = true;
            this.lblCombNotice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCombNotice.Font = new System.Drawing.Font("Verdana", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.lblCombNotice.Location = new System.Drawing.Point(3, 125);
            this.lblCombNotice.Name = "lblCombNotice";
            this.lblCombNotice.Size = new System.Drawing.Size(614, 54);
            this.lblCombNotice.TabIndex = 0;
            this.lblCombNotice.Text = "press enter key";
            this.lblCombNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txtCombN, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCombR, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(614, 119);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtCombN
            // 
            this.txtCombN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCombN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCombN.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombN.Location = new System.Drawing.Point(122, 48);
            this.txtCombN.Margin = new System.Windows.Forms.Padding(0);
            this.txtCombN.Name = "txtCombN";
            this.txtCombN.Size = new System.Drawing.Size(122, 23);
            this.txtCombN.TabIndex = 0;
            this.txtCombN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCombN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCombN_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label1.Location = new System.Drawing.Point(247, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 119);
            this.label1.TabIndex = 1;
            this.label1.Text = "C";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCombR
            // 
            this.txtCombR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCombR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCombR.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombR.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCombR.Location = new System.Drawing.Point(366, 48);
            this.txtCombR.Margin = new System.Windows.Forms.Padding(0);
            this.txtCombR.Name = "txtCombR";
            this.txtCombR.Size = new System.Drawing.Size(122, 23);
            this.txtCombR.TabIndex = 2;
            this.txtCombR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCombR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCombR_KeyPress);
            // 
            // stopwatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.mainLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "stopwatchForm";
            this.Text = "Form1";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.stopwatchForm_FormClosing);
            this.Load += new System.EventHandler(this.stopwatchForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.stopwatchForm_Paint);
            this.mainLayout.ResumeLayout(false);
            this.middleLayout.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tblLogPage.ResumeLayout(false);
            this.tblLogPage.PerformLayout();
            this.tblLog.ResumeLayout(false);
            this.tblLog.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.topLayout.ResumeLayout(false);
            this.tblCombPage.ResumeLayout(false);
            this.tblCombPage.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer stopwatch;
        private System.Windows.Forms.Button pauseResumeBtn;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel topLayout;
        private System.Windows.Forms.TableLayoutPanel middleLayout;
        private System.Windows.Forms.Button minimizedBtn;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tblLog;
        private System.Windows.Forms.TextBox txtExponent;
        private System.Windows.Forms.TableLayoutPanel tblLogPage;
        private System.Windows.Forms.Label lbLogNotice;
        private System.Windows.Forms.TableLayoutPanel tblCombPage;
        private System.Windows.Forms.Label lblCombNotice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtCombN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCombR;
    }
}

