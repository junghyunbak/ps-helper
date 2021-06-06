namespace markdown
{
    partial class markdownForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.titleBarLayout = new System.Windows.Forms.TableLayoutPanel();
            this.minimizedBtn = new System.Windows.Forms.Button();
            this.closedBtn = new System.Windows.Forms.Button();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.titleBarLayout.SuspendLayout();
            this.mainLayout.SuspendLayout();
            this.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(666, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseMove);
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
            this.titleBarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.titleBarLayout.Size = new System.Drawing.Size(800, 40);
            this.titleBarLayout.TabIndex = 1;
            // 
            // minimizedBtn
            // 
            this.minimizedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(183)))));
            this.minimizedBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minimizedBtn.FlatAppearance.BorderSize = 0;
            this.minimizedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizedBtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.minimizedBtn.ForeColor = System.Drawing.Color.White;
            this.minimizedBtn.Location = new System.Drawing.Point(672, 0);
            this.minimizedBtn.Margin = new System.Windows.Forms.Padding(0);
            this.minimizedBtn.Name = "minimizedBtn";
            this.minimizedBtn.Size = new System.Drawing.Size(64, 40);
            this.minimizedBtn.TabIndex = 1;
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
            this.closedBtn.Location = new System.Drawing.Point(736, 0);
            this.closedBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closedBtn.Name = "closedBtn";
            this.closedBtn.Size = new System.Drawing.Size(64, 40);
            this.closedBtn.TabIndex = 1;
            this.closedBtn.Text = "×";
            this.closedBtn.UseVisualStyleBackColor = false;
            this.closedBtn.Click += new System.EventHandler(this.closedBtn_Click);
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.titleBarLayout, 0, 0);
            this.mainLayout.Controls.Add(this.webBrowser, 0, 1);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(800, 600);
            this.mainLayout.TabIndex = 2;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(3, 43);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(794, 554);
            this.webBrowser.TabIndex = 2;
            // 
            // markdownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.mainLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "markdownForm";
            this.Load += new System.EventHandler(this.markdownForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.markdownForm_KeyPress);
            this.titleBarLayout.ResumeLayout(false);
            this.titleBarLayout.PerformLayout();
            this.mainLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel titleBarLayout;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Button minimizedBtn;
        private System.Windows.Forms.Button closedBtn;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

