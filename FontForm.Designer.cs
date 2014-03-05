namespace DesktopNote
{
    partial class FontForm
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
            this.fontComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeGroupBox = new System.Windows.Forms.GroupBox();
            this.sizeRadioButton3 = new System.Windows.Forms.RadioButton();
            this.sizeRadioButton4 = new System.Windows.Forms.RadioButton();
            this.sizeRadioButton2 = new System.Windows.Forms.RadioButton();
            this.sizeRadioButton1 = new System.Windows.Forms.RadioButton();
            this.boldCheckBox = new System.Windows.Forms.CheckBox();
            this.italicCheckBox = new System.Windows.Forms.CheckBox();
            this.strikeoutCheckBox = new System.Windows.Forms.CheckBox();
            this.underlineCheckBox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.sizeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fontComboBox
            // 
            this.fontComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontComboBox.FormattingEnabled = true;
            this.fontComboBox.Items.AddRange(new object[] {
            "Courier New",
            "Heiti",
            "Candara",
            "Segoe UI"});
            this.fontComboBox.Location = new System.Drawing.Point(57, 4);
            this.fontComboBox.Name = "fontComboBox";
            this.fontComboBox.Size = new System.Drawing.Size(121, 20);
            this.fontComboBox.TabIndex = 0;
            this.fontComboBox.SelectedIndexChanged += new System.EventHandler(this.fontComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Font";
            // 
            // sizeGroupBox
            // 
            this.sizeGroupBox.Controls.Add(this.sizeRadioButton3);
            this.sizeGroupBox.Controls.Add(this.sizeRadioButton4);
            this.sizeGroupBox.Controls.Add(this.sizeRadioButton2);
            this.sizeGroupBox.Controls.Add(this.sizeRadioButton1);
            this.sizeGroupBox.Location = new System.Drawing.Point(24, 58);
            this.sizeGroupBox.Name = "sizeGroupBox";
            this.sizeGroupBox.Size = new System.Drawing.Size(154, 163);
            this.sizeGroupBox.TabIndex = 2;
            this.sizeGroupBox.TabStop = false;
            this.sizeGroupBox.Text = "Size";
            // 
            // sizeRadioButton3
            // 
            this.sizeRadioButton3.AutoSize = true;
            this.sizeRadioButton3.Location = new System.Drawing.Point(21, 98);
            this.sizeRadioButton3.Name = "sizeRadioButton3";
            this.sizeRadioButton3.Size = new System.Drawing.Size(35, 16);
            this.sizeRadioButton3.TabIndex = 3;
            this.sizeRadioButton3.Text = "11";
            this.sizeRadioButton3.UseVisualStyleBackColor = true;
            this.sizeRadioButton3.CheckedChanged += new System.EventHandler(this.sizeRadioButton_CheckedChanged);
            // 
            // sizeRadioButton4
            // 
            this.sizeRadioButton4.AutoSize = true;
            this.sizeRadioButton4.Location = new System.Drawing.Point(21, 130);
            this.sizeRadioButton4.Name = "sizeRadioButton4";
            this.sizeRadioButton4.Size = new System.Drawing.Size(35, 16);
            this.sizeRadioButton4.TabIndex = 2;
            this.sizeRadioButton4.Text = "12";
            this.sizeRadioButton4.UseVisualStyleBackColor = true;
            this.sizeRadioButton4.CheckedChanged += new System.EventHandler(this.sizeRadioButton_CheckedChanged);
            // 
            // sizeRadioButton2
            // 
            this.sizeRadioButton2.AutoSize = true;
            this.sizeRadioButton2.Location = new System.Drawing.Point(21, 64);
            this.sizeRadioButton2.Name = "sizeRadioButton2";
            this.sizeRadioButton2.Size = new System.Drawing.Size(35, 16);
            this.sizeRadioButton2.TabIndex = 1;
            this.sizeRadioButton2.Text = "10";
            this.sizeRadioButton2.UseVisualStyleBackColor = true;
            this.sizeRadioButton2.CheckedChanged += new System.EventHandler(this.sizeRadioButton_CheckedChanged);
            // 
            // sizeRadioButton1
            // 
            this.sizeRadioButton1.AutoSize = true;
            this.sizeRadioButton1.Checked = true;
            this.sizeRadioButton1.Location = new System.Drawing.Point(21, 31);
            this.sizeRadioButton1.Name = "sizeRadioButton1";
            this.sizeRadioButton1.Size = new System.Drawing.Size(29, 16);
            this.sizeRadioButton1.TabIndex = 0;
            this.sizeRadioButton1.TabStop = true;
            this.sizeRadioButton1.Text = "9";
            this.sizeRadioButton1.UseVisualStyleBackColor = true;
            this.sizeRadioButton1.CheckedChanged += new System.EventHandler(this.sizeRadioButton_CheckedChanged);
            // 
            // boldCheckBox
            // 
            this.boldCheckBox.AutoSize = true;
            this.boldCheckBox.Location = new System.Drawing.Point(203, 67);
            this.boldCheckBox.Name = "boldCheckBox";
            this.boldCheckBox.Size = new System.Drawing.Size(48, 16);
            this.boldCheckBox.TabIndex = 3;
            this.boldCheckBox.Text = "Bold";
            this.boldCheckBox.UseVisualStyleBackColor = true;
            // 
            // italicCheckBox
            // 
            this.italicCheckBox.AutoSize = true;
            this.italicCheckBox.Location = new System.Drawing.Point(203, 90);
            this.italicCheckBox.Name = "italicCheckBox";
            this.italicCheckBox.Size = new System.Drawing.Size(60, 16);
            this.italicCheckBox.TabIndex = 4;
            this.italicCheckBox.Text = "Italic";
            this.italicCheckBox.UseVisualStyleBackColor = true;
            // 
            // strikeoutCheckBox
            // 
            this.strikeoutCheckBox.AutoSize = true;
            this.strikeoutCheckBox.Location = new System.Drawing.Point(203, 134);
            this.strikeoutCheckBox.Name = "strikeoutCheckBox";
            this.strikeoutCheckBox.Size = new System.Drawing.Size(78, 16);
            this.strikeoutCheckBox.TabIndex = 5;
            this.strikeoutCheckBox.Text = "Strikeout";
            this.strikeoutCheckBox.UseVisualStyleBackColor = true;
            // 
            // underlineCheckBox
            // 
            this.underlineCheckBox.AutoSize = true;
            this.underlineCheckBox.Location = new System.Drawing.Point(203, 112);
            this.underlineCheckBox.Name = "underlineCheckBox";
            this.underlineCheckBox.Size = new System.Drawing.Size(78, 16);
            this.underlineCheckBox.TabIndex = 6;
            this.underlineCheckBox.Text = "Underline";
            this.underlineCheckBox.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(203, 168);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(203, 198);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // FontForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.underlineCheckBox);
            this.Controls.Add(this.strikeoutCheckBox);
            this.Controls.Add(this.italicCheckBox);
            this.Controls.Add(this.boldCheckBox);
            this.Controls.Add(this.sizeGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fontComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FontForm";
            this.ShowInTaskbar = false;
            this.Text = "Font";
            this.sizeGroupBox.ResumeLayout(false);
            this.sizeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fontComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox sizeGroupBox;
        private System.Windows.Forms.RadioButton sizeRadioButton3;
        private System.Windows.Forms.RadioButton sizeRadioButton4;
        private System.Windows.Forms.RadioButton sizeRadioButton2;
        private System.Windows.Forms.RadioButton sizeRadioButton1;
        private System.Windows.Forms.CheckBox boldCheckBox;
        private System.Windows.Forms.CheckBox italicCheckBox;
        private System.Windows.Forms.CheckBox strikeoutCheckBox;
        private System.Windows.Forms.CheckBox underlineCheckBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}