namespace DesktopNote
{
    partial class SelectDirectoryForm
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
            this.logicalDriveComboBox = new System.Windows.Forms.ComboBox();
            this.directoryListBox = new System.Windows.Forms.ListBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.UPbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.workDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.OKbutton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logicalDriveComboBox
            // 
            this.logicalDriveComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.logicalDriveComboBox.FormattingEnabled = true;
            this.logicalDriveComboBox.Location = new System.Drawing.Point(0, 0);
            this.logicalDriveComboBox.Name = "logicalDriveComboBox";
            this.logicalDriveComboBox.Size = new System.Drawing.Size(410, 20);
            this.logicalDriveComboBox.TabIndex = 0;
            this.logicalDriveComboBox.SelectedValueChanged += new System.EventHandler(this.logicalDriveComboBox_SelectedValueChanged);
            // 
            // directoryListBox
            // 
            this.directoryListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directoryListBox.FormattingEnabled = true;
            this.directoryListBox.ItemHeight = 12;
            this.directoryListBox.Location = new System.Drawing.Point(0, 20);
            this.directoryListBox.Name = "directoryListBox";
            this.directoryListBox.Size = new System.Drawing.Size(410, 241);
            this.directoryListBox.TabIndex = 1;
            this.directoryListBox.DoubleClick += new System.EventHandler(this.directoryListBox_DoubleClick);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.CancelButton);
            this.bottomPanel.Controls.Add(this.OKbutton);
            this.bottomPanel.Controls.Add(this.workDirectoryTextBox);
            this.bottomPanel.Controls.Add(this.label1);
            this.bottomPanel.Controls.Add(this.UPbutton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 237);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(410, 24);
            this.bottomPanel.TabIndex = 2;
            // 
            // UPbutton
            // 
            this.UPbutton.Location = new System.Drawing.Point(0, 0);
            this.UPbutton.Name = "UPbutton";
            this.UPbutton.Size = new System.Drawing.Size(75, 23);
            this.UPbutton.TabIndex = 0;
            this.UPbutton.Text = "Up";
            this.UPbutton.UseVisualStyleBackColor = true;
            this.UPbutton.Click += new System.EventHandler(this.UPbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Directory";
            // 
            // workDirectoryTextBox
            // 
            this.workDirectoryTextBox.Location = new System.Drawing.Point(147, 0);
            this.workDirectoryTextBox.Name = "workDirectoryTextBox";
            this.workDirectoryTextBox.Size = new System.Drawing.Size(107, 21);
            this.workDirectoryTextBox.TabIndex = 2;
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(254, 0);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 3;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(332, 0);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // SelectDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 261);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.directoryListBox);
            this.Controls.Add(this.logicalDriveComboBox);
            this.Name = "SelectDirectoryForm";
            this.Text = "SelectDirectory";
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox logicalDriveComboBox;
        private System.Windows.Forms.ListBox directoryListBox;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.TextBox workDirectoryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UPbutton;
    }
}