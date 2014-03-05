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
            this.noteFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foreColorBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backColorHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteFormStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.noteFormMenuStrip.SuspendLayout();
            this.noteFormStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTextBox
            // 
            this.mainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTextBox.Location = new System.Drawing.Point(0, 25);
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainTextBox.Size = new System.Drawing.Size(526, 236);
            this.mainTextBox.TabIndex = 0;
            this.mainTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainTextBox_KeyDown);
            this.mainTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainTextBox_KeyPress);
            // 
            // noteFormMenuStrip
            // 
            this.noteFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFToolStripMenuItem,
            this.editEToolStripMenuItem,
            this.toolsTToolStripMenuItem});
            this.noteFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.noteFormMenuStrip.Name = "noteFormMenuStrip";
            this.noteFormMenuStrip.Size = new System.Drawing.Size(526, 25);
            this.noteFormMenuStrip.TabIndex = 2;
            this.noteFormMenuStrip.Text = "menuStrip1";
            // 
            // fileFToolStripMenuItem
            // 
            this.fileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNToolStripMenuItem,
            this.deleteDToolStripMenuItem,
            this.previousPToolStripMenuItem,
            this.nextLToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitXToolStripMenuItem});
            this.fileFToolStripMenuItem.Name = "fileFToolStripMenuItem";
            this.fileFToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.fileFToolStripMenuItem.Text = "File(&F)";
            // 
            // createNToolStripMenuItem
            // 
            this.createNToolStripMenuItem.Name = "createNToolStripMenuItem";
            this.createNToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createNToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.createNToolStripMenuItem.Text = "Create(&N)";
            this.createNToolStripMenuItem.Click += new System.EventHandler(this.newButton_Click);
            // 
            // deleteDToolStripMenuItem
            // 
            this.deleteDToolStripMenuItem.Name = "deleteDToolStripMenuItem";
            this.deleteDToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deleteDToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.deleteDToolStripMenuItem.Text = "Delete(&D)";
            this.deleteDToolStripMenuItem.Click += new System.EventHandler(this.delButton_Click);
            // 
            // previousPToolStripMenuItem
            // 
            this.previousPToolStripMenuItem.Name = "previousPToolStripMenuItem";
            this.previousPToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.previousPToolStripMenuItem.Text = "Previous(&P)";
            this.previousPToolStripMenuItem.Click += new System.EventHandler(this.preButton_Click);
            // 
            // nextLToolStripMenuItem
            // 
            this.nextLToolStripMenuItem.Name = "nextLToolStripMenuItem";
            this.nextLToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.nextLToolStripMenuItem.Text = "Next(&L)";
            this.nextLToolStripMenuItem.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.loadToolStripMenuItem.Text = "Load from File";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.saveToolStripMenuItem.Text = "Save to File";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(176, 6);
            // 
            // exitXToolStripMenuItem
            // 
            this.exitXToolStripMenuItem.Name = "exitXToolStripMenuItem";
            this.exitXToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.exitXToolStripMenuItem.Text = "Exit(&X)";
            this.exitXToolStripMenuItem.Click += new System.EventHandler(this.exitXToolStripMenuItem_Click);
            // 
            // editEToolStripMenuItem
            // 
            this.editEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foreColorBToolStripMenuItem,
            this.backColorHToolStripMenuItem,
            this.fontFToolStripMenuItem});
            this.editEToolStripMenuItem.Name = "editEToolStripMenuItem";
            this.editEToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.editEToolStripMenuItem.Text = "Edit(&E)";
            // 
            // foreColorBToolStripMenuItem
            // 
            this.foreColorBToolStripMenuItem.Name = "foreColorBToolStripMenuItem";
            this.foreColorBToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.foreColorBToolStripMenuItem.Text = "ForeColor(&B)";
            this.foreColorBToolStripMenuItem.Click += new System.EventHandler(this.setForeColorButton_Click);
            // 
            // backColorHToolStripMenuItem
            // 
            this.backColorHToolStripMenuItem.Name = "backColorHToolStripMenuItem";
            this.backColorHToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.backColorHToolStripMenuItem.Text = "BackColor(&H)";
            this.backColorHToolStripMenuItem.Click += new System.EventHandler(this.setBackgroundButton_Click);
            // 
            // fontFToolStripMenuItem
            // 
            this.fontFToolStripMenuItem.Name = "fontFToolStripMenuItem";
            this.fontFToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.fontFToolStripMenuItem.Text = "Font(&F)";
            this.fontFToolStripMenuItem.Click += new System.EventHandler(this.setFontButton_Click);
            // 
            // toolsTToolStripMenuItem
            // 
            this.toolsTToolStripMenuItem.Name = "toolsTToolStripMenuItem";
            this.toolsTToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.toolsTToolStripMenuItem.Text = "Tools(&T)";
            // 
            // noteFormStatusStrip
            // 
            this.noteFormStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.noteFormStatusStrip.Location = new System.Drawing.Point(0, 239);
            this.noteFormStatusStrip.Name = "noteFormStatusStrip";
            this.noteFormStatusStrip.Size = new System.Drawing.Size(526, 22);
            this.noteFormStatusStrip.TabIndex = 3;
            this.noteFormStatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(113, 17);
            this.toolStripStatusLabel1.Text = "DesktopNote(1/1)";
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 261);
            this.Controls.Add(this.noteFormStatusStrip);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.noteFormMenuStrip);
            this.MainMenuStrip = this.noteFormMenuStrip;
            this.Name = "NoteForm";
            this.Text = "桌面便笺";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NoteForm_FormClosing);
            this.Load += new System.EventHandler(this.NoteForm_Load);
            this.SizeChanged += new System.EventHandler(this.NoteForm_SizeChanged);
            this.noteFormMenuStrip.ResumeLayout(false);
            this.noteFormMenuStrip.PerformLayout();
            this.noteFormStatusStrip.ResumeLayout(false);
            this.noteFormStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.MenuStrip noteFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextLToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foreColorBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backColorHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsTToolStripMenuItem;
        private System.Windows.Forms.StatusStrip noteFormStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

