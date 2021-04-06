namespace popup
{
    partial class popupItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.closeBtn = new System.Windows.Forms.Button();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.messageLayout = new System.Windows.Forms.TableLayoutPanel();
            this.buttonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.whitespaceLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ellipseControl1 = new stopwatch.EllipseControl();
            this.messagePanel.SuspendLayout();
            this.messageLayout.SuspendLayout();
            this.buttonLayout.SuspendLayout();
            this.whitespaceLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.Color.Black;
            this.closeBtn.Location = new System.Drawing.Point(0, 0);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(160, 118);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "×";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // messagePanel
            // 
            this.messagePanel.BackColor = System.Drawing.Color.Transparent;
            this.messagePanel.Controls.Add(this.messageLayout);
            this.messagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagePanel.Location = new System.Drawing.Point(0, 0);
            this.messagePanel.Margin = new System.Windows.Forms.Padding(0);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(800, 396);
            this.messagePanel.TabIndex = 2;
            // 
            // messageLayout
            // 
            this.messageLayout.BackColor = System.Drawing.Color.Black;
            this.messageLayout.ColumnCount = 2;
            this.messageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.messageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.messageLayout.Controls.Add(this.buttonLayout, 1, 0);
            this.messageLayout.Controls.Add(this.lblMessage, 0, 0);
            this.messageLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageLayout.Location = new System.Drawing.Point(0, 0);
            this.messageLayout.Margin = new System.Windows.Forms.Padding(0);
            this.messageLayout.Name = "messageLayout";
            this.messageLayout.RowCount = 1;
            this.messageLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.messageLayout.Size = new System.Drawing.Size(800, 396);
            this.messageLayout.TabIndex = 1;
            // 
            // buttonLayout
            // 
            this.buttonLayout.BackColor = System.Drawing.Color.Transparent;
            this.buttonLayout.ColumnCount = 1;
            this.buttonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonLayout.Controls.Add(this.closeBtn, 0, 0);
            this.buttonLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLayout.Location = new System.Drawing.Point(640, 0);
            this.buttonLayout.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLayout.Name = "buttonLayout";
            this.buttonLayout.RowCount = 2;
            this.buttonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.buttonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.buttonLayout.Size = new System.Drawing.Size(160, 396);
            this.buttonLayout.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMessage.Location = new System.Drawing.Point(0, 0);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.lblMessage.Size = new System.Drawing.Size(640, 396);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "label1";
            // 
            // whitespaceLayout
            // 
            this.whitespaceLayout.BackColor = System.Drawing.Color.Transparent;
            this.whitespaceLayout.ColumnCount = 1;
            this.whitespaceLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.whitespaceLayout.Controls.Add(this.messagePanel, 0, 0);
            this.whitespaceLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whitespaceLayout.Location = new System.Drawing.Point(0, 0);
            this.whitespaceLayout.Margin = new System.Windows.Forms.Padding(0);
            this.whitespaceLayout.Name = "whitespaceLayout";
            this.whitespaceLayout.RowCount = 2;
            this.whitespaceLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 99F));
            this.whitespaceLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.whitespaceLayout.Size = new System.Drawing.Size(800, 400);
            this.whitespaceLayout.TabIndex = 1;
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 15;
            this.ellipseControl1.TargetControl = this.messagePanel;
            // 
            // popupItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.whitespaceLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "popupItem";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.popupItem_Load);
            this.messagePanel.ResumeLayout(false);
            this.messageLayout.ResumeLayout(false);
            this.messageLayout.PerformLayout();
            this.buttonLayout.ResumeLayout(false);
            this.buttonLayout.PerformLayout();
            this.whitespaceLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private stopwatch.EllipseControl ellipseControl1;
        private System.Windows.Forms.TableLayoutPanel whitespaceLayout;
        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.TableLayoutPanel messageLayout;
        private System.Windows.Forms.TableLayoutPanel buttonLayout;
        private System.Windows.Forms.Label lblMessage;
    }
}