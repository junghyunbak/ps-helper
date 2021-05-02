namespace popup
{
    partial class popupBox
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
            this.popupItemPanel = new System.Windows.Forms.TableLayoutPanel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.popupBoxLayout = new System.Windows.Forms.TableLayoutPanel();
            this.clearBtnLayout = new System.Windows.Forms.TableLayoutPanel();
            this.hiddenTimer = new System.Windows.Forms.Timer(this.components);
            this.ellipseControl1 = new stopwatch.EllipseControl();
            this.popupBoxLayout.SuspendLayout();
            this.clearBtnLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // popupItemPanel
            // 
            this.popupItemPanel.BackColor = System.Drawing.Color.Transparent;
            this.popupItemPanel.ColumnCount = 1;
            this.popupItemPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.popupItemPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popupItemPanel.ForeColor = System.Drawing.Color.Black;
            this.popupItemPanel.Location = new System.Drawing.Point(0, 0);
            this.popupItemPanel.Margin = new System.Windows.Forms.Padding(0);
            this.popupItemPanel.Name = "popupItemPanel";
            this.popupItemPanel.RowCount = 1;
            this.popupItemPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.popupItemPanel.Size = new System.Drawing.Size(986, 350);
            this.popupItemPanel.TabIndex = 2;
            this.popupItemPanel.MouseEnter += new System.EventHandler(this.popupItemPanel_MouseEnter);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Black;
            this.clearBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(3, 10);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(980, 30);
            this.clearBtn.TabIndex = 0;
            this.clearBtn.Text = "[ close all ]";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // popupBoxLayout
            // 
            this.popupBoxLayout.BackColor = System.Drawing.Color.Transparent;
            this.popupBoxLayout.ColumnCount = 1;
            this.popupBoxLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.popupBoxLayout.Controls.Add(this.popupItemPanel, 0, 0);
            this.popupBoxLayout.Controls.Add(this.clearBtnLayout, 0, 1);
            this.popupBoxLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popupBoxLayout.Location = new System.Drawing.Point(7, 0);
            this.popupBoxLayout.Margin = new System.Windows.Forms.Padding(0);
            this.popupBoxLayout.Name = "popupBoxLayout";
            this.popupBoxLayout.RowCount = 2;
            this.popupBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.popupBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.popupBoxLayout.Size = new System.Drawing.Size(986, 400);
            this.popupBoxLayout.TabIndex = 3;
            // 
            // clearBtnLayout
            // 
            this.clearBtnLayout.ColumnCount = 1;
            this.clearBtnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clearBtnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.clearBtnLayout.Controls.Add(this.clearBtn, 0, 1);
            this.clearBtnLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearBtnLayout.Location = new System.Drawing.Point(0, 350);
            this.clearBtnLayout.Margin = new System.Windows.Forms.Padding(0);
            this.clearBtnLayout.Name = "clearBtnLayout";
            this.clearBtnLayout.RowCount = 3;
            this.clearBtnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.clearBtnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.clearBtnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.clearBtnLayout.Size = new System.Drawing.Size(986, 50);
            this.clearBtnLayout.TabIndex = 3;
            // 
            // hiddenTimer
            // 
            this.hiddenTimer.Tick += new System.EventHandler(this.hiddenTimer_Tick);
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 5;
            this.ellipseControl1.TargetControl = this.clearBtn;
            // 
            // popupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 400);
            this.ControlBox = false;
            this.Controls.Add(this.popupBoxLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "popupBox";
            this.Opacity = 0.88D;
            this.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.popupBoxLayout.ResumeLayout(false);
            this.clearBtnLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel popupItemPanel;
        private System.Windows.Forms.TableLayoutPanel popupBoxLayout;
        private stopwatch.EllipseControl ellipseControl1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Timer hiddenTimer;
        private System.Windows.Forms.TableLayoutPanel clearBtnLayout;
    }
}

