namespace DesktopNote
{
    partial class NoteForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.foreColorButton = new System.Windows.Forms.Button();
            this.setBackgroundButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.preButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.fontButton = new System.Windows.Forms.Button();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTextBox
            // 
            this.mainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTextBox.Location = new System.Drawing.Point(0, 0);
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(526, 261);
            this.mainTextBox.TabIndex = 0;
            this.mainTextBox.TextChanged += new System.EventHandler(this.mainTextBox_TextChanged);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.fontButton);
            this.bottomPanel.Controls.Add(this.foreColorButton);
            this.bottomPanel.Controls.Add(this.setBackgroundButton);
            this.bottomPanel.Controls.Add(this.nextButton);
            this.bottomPanel.Controls.Add(this.preButton);
            this.bottomPanel.Controls.Add(this.delButton);
            this.bottomPanel.Controls.Add(this.newButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 216);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(526, 45);
            this.bottomPanel.TabIndex = 1;
            // 
            // foreColorButton
            // 
            this.foreColorButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.foreColorButton.Location = new System.Drawing.Point(375, 0);
            this.foreColorButton.Name = "foreColorButton";
            this.foreColorButton.Size = new System.Drawing.Size(75, 45);
            this.foreColorButton.TabIndex = 3;
            this.foreColorButton.Text = "ForeColor";
            this.foreColorButton.UseVisualStyleBackColor = true;
            this.foreColorButton.Click += new System.EventHandler(this.setForeColorButton_Click);
            // 
            // setBackgroundButton
            // 
            this.setBackgroundButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.setBackgroundButton.Location = new System.Drawing.Point(300, 0);
            this.setBackgroundButton.Name = "setBackgroundButton";
            this.setBackgroundButton.Size = new System.Drawing.Size(75, 45);
            this.setBackgroundButton.TabIndex = 2;
            this.setBackgroundButton.Text = "Background";
            this.setBackgroundButton.UseVisualStyleBackColor = true;
            this.setBackgroundButton.Click += new System.EventHandler(this.setBackgroundButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.nextButton.Location = new System.Drawing.Point(225, 0);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 45);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // preButton
            // 
            this.preButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.preButton.Location = new System.Drawing.Point(150, 0);
            this.preButton.Name = "preButton";
            this.preButton.Size = new System.Drawing.Size(75, 45);
            this.preButton.TabIndex = 2;
            this.preButton.Text = "Previous";
            this.preButton.UseVisualStyleBackColor = true;
            this.preButton.Click += new System.EventHandler(this.preButton_Click);
            // 
            // delButton
            // 
            this.delButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.delButton.Location = new System.Drawing.Point(75, 0);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(75, 45);
            this.delButton.TabIndex = 1;
            this.delButton.Text = "Delete";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // newButton
            // 
            this.newButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.newButton.Location = new System.Drawing.Point(0, 0);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 45);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "Create";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // fontButton
            // 
            this.fontButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.fontButton.Location = new System.Drawing.Point(450, 0);
            this.fontButton.Name = "fontButton";
            this.fontButton.Size = new System.Drawing.Size(75, 45);
            this.fontButton.TabIndex = 4;
            this.fontButton.Text = "Font";
            this.fontButton.UseVisualStyleBackColor = true;
            this.fontButton.Click += new System.EventHandler(this.fontButton_Click);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 261);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.mainTextBox);
            this.Name = "NoteForm";
            this.Text = "桌面便笺";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NoteForm_FormClosing);
            this.Load += new System.EventHandler(this.NoteForm_Load);
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button setBackgroundButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button preButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button foreColorButton;
        private System.Windows.Forms.Button fontButton;
    }
}

