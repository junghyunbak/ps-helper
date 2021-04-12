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
            this.bottomLayout = new System.Windows.Forms.TableLayoutPanel();
            this.bottomLeftPanel = new System.Windows.Forms.Panel();
            this.bottomRightPanel = new System.Windows.Forms.Panel();
            this.topLayout = new System.Windows.Forms.TableLayoutPanel();
            this.minimizedBtn = new System.Windows.Forms.Button();
            this.topLeftPanel = new System.Windows.Forms.Panel();
            this.topRightPanel = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.mainLayout.SuspendLayout();
            this.middleLayout.SuspendLayout();
            this.bottomLayout.SuspendLayout();
            this.topLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // stopwatch
            // 
            this.stopwatch.Enabled = true;
            this.stopwatch.Tick += new System.EventHandler(this.stopwatch_Tick);
            // 
            // pauseResumeBtn
            // 
            this.pauseResumeBtn.FlatAppearance.BorderSize = 0;
            this.pauseResumeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseResumeBtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pauseResumeBtn.Location = new System.Drawing.Point(545, 3);
            this.pauseResumeBtn.Name = "pauseResumeBtn";
            this.pauseResumeBtn.Size = new System.Drawing.Size(113, 88);
            this.pauseResumeBtn.TabIndex = 1;
            this.pauseResumeBtn.Text = "∥";
            this.pauseResumeBtn.UseVisualStyleBackColor = true;
            this.pauseResumeBtn.Click += new System.EventHandler(this.pauseResumeBtn_Click);
            // 
            // lblResult
            // 
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResult.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(122, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(549, 194);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "label1";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeBtn
            // 
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(664, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(113, 88);
            this.closeBtn.TabIndex = 3;
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
            this.mainLayout.Controls.Add(this.bottomLayout, 0, 2);
            this.mainLayout.Controls.Add(this.topLayout, 0, 0);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 3;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.Size = new System.Drawing.Size(800, 400);
            this.mainLayout.TabIndex = 4;
            // 
            // middleLayout
            // 
            this.middleLayout.ColumnCount = 3;
            this.middleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.middleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.middleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.middleLayout.Controls.Add(this.lblResult, 1, 0);
            this.middleLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleLayout.Location = new System.Drawing.Point(3, 103);
            this.middleLayout.Name = "middleLayout";
            this.middleLayout.RowCount = 1;
            this.middleLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.middleLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.middleLayout.Size = new System.Drawing.Size(794, 194);
            this.middleLayout.TabIndex = 1;
            // 
            // bottomLayout
            // 
            this.bottomLayout.ColumnCount = 3;
            this.bottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.5F));
            this.bottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97F));
            this.bottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.5F));
            this.bottomLayout.Controls.Add(this.bottomLeftPanel, 0, 0);
            this.bottomLayout.Controls.Add(this.bottomRightPanel, 2, 0);
            this.bottomLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomLayout.Location = new System.Drawing.Point(3, 303);
            this.bottomLayout.Name = "bottomLayout";
            this.bottomLayout.RowCount = 1;
            this.bottomLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomLayout.Size = new System.Drawing.Size(794, 94);
            this.bottomLayout.TabIndex = 2;
            // 
            // bottomLeftPanel
            // 
            this.bottomLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomLeftPanel.Location = new System.Drawing.Point(3, 3);
            this.bottomLeftPanel.Name = "bottomLeftPanel";
            this.bottomLeftPanel.Size = new System.Drawing.Size(5, 88);
            this.bottomLeftPanel.TabIndex = 0;
            this.bottomLeftPanel.MouseEnter += new System.EventHandler(this.bottomLeftPanel_MouseEnter);
            // 
            // bottomRightPanel
            // 
            this.bottomRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomRightPanel.Location = new System.Drawing.Point(784, 3);
            this.bottomRightPanel.Name = "bottomRightPanel";
            this.bottomRightPanel.Size = new System.Drawing.Size(7, 88);
            this.bottomRightPanel.TabIndex = 1;
            this.bottomRightPanel.MouseEnter += new System.EventHandler(this.bottomRightPanel_MouseEnter);
            // 
            // topLayout
            // 
            this.topLayout.ColumnCount = 6;
            this.topLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.5F));
            this.topLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.topLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.topLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.topLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.topLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.5F));
            this.topLayout.Controls.Add(this.closeBtn, 4, 0);
            this.topLayout.Controls.Add(this.pauseResumeBtn, 3, 0);
            this.topLayout.Controls.Add(this.minimizedBtn, 2, 0);
            this.topLayout.Controls.Add(this.topLeftPanel, 0, 0);
            this.topLayout.Controls.Add(this.topRightPanel, 5, 0);
            this.topLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topLayout.Location = new System.Drawing.Point(3, 3);
            this.topLayout.Name = "topLayout";
            this.topLayout.RowCount = 1;
            this.topLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topLayout.Size = new System.Drawing.Size(794, 94);
            this.topLayout.TabIndex = 0;
            // 
            // minimizedBtn
            // 
            this.minimizedBtn.FlatAppearance.BorderSize = 0;
            this.minimizedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizedBtn.Location = new System.Drawing.Point(426, 3);
            this.minimizedBtn.Name = "minimizedBtn";
            this.minimizedBtn.Size = new System.Drawing.Size(113, 88);
            this.minimizedBtn.TabIndex = 4;
            this.minimizedBtn.Text = "＿";
            this.minimizedBtn.UseVisualStyleBackColor = true;
            this.minimizedBtn.Click += new System.EventHandler(this.minimizedBtn_Click);
            // 
            // topLeftPanel
            // 
            this.topLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topLeftPanel.Location = new System.Drawing.Point(3, 3);
            this.topLeftPanel.Name = "topLeftPanel";
            this.topLeftPanel.Size = new System.Drawing.Size(5, 88);
            this.topLeftPanel.TabIndex = 5;
            this.topLeftPanel.MouseEnter += new System.EventHandler(this.topLeftPanel_MouseEnter);
            // 
            // topRightPanel
            // 
            this.topRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topRightPanel.Location = new System.Drawing.Point(783, 3);
            this.topRightPanel.Name = "topRightPanel";
            this.topRightPanel.Size = new System.Drawing.Size(8, 88);
            this.topRightPanel.TabIndex = 6;
            this.topRightPanel.MouseEnter += new System.EventHandler(this.topRightPanel_MouseEnter);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
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
            this.bottomLayout.ResumeLayout(false);
            this.topLayout.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel bottomLayout;
        private System.Windows.Forms.Panel topLeftPanel;
        private System.Windows.Forms.Panel topRightPanel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel bottomLeftPanel;
        private System.Windows.Forms.Panel bottomRightPanel;
    }
}

