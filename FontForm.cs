using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopNote
{
    public partial class FontForm : Form
    {
        Font font = Form.DefaultFont;
        public event EventHandler Apply;

        public Font NoteFont {
            set {
                this.font = value;
                foreach (Object o in fontComboBox.Items) {
                    if (font.Name.Equals(o)) {
                        this.fontComboBox.SelectedItem = o;
                    }
                }
                foreach (Object o in this.sizeGroupBox.Controls) {
                    if (o is RadioButton) {
                        if (((RadioButton)o).Text.Equals(((int)font.Size).ToString())) {
                            ((RadioButton)o).Checked = true;
                        }
                    }
                }
                this.boldCheckBox.Checked = font.Bold;
                this.italicCheckBox.Checked = font.Italic;
                this.underlineCheckBox.Checked = font.Underline;
                this.strikeoutCheckBox.Checked = font.Strikeout;
            }
            get {
                FontStyle fs = 0;
                if (this.boldCheckBox.Checked) { 
                    fs |= FontStyle.Bold;
                }
                if (this.italicCheckBox.Checked) { 
                    fs |= FontStyle.Italic;
                }
                if (this.underlineCheckBox.Checked) { 
                    fs |= FontStyle.Underline;
                }
                if (this.strikeoutCheckBox.Checked) { 
                    fs |= FontStyle.Strikeout;
                }
                this.font = new Font(font,fs);
                return font;
            }
        }
        
        public bool ShowApply {
            get { return apply_Button.Enabled; }
            set { apply_Button.Enabled = value;}
        }

        public FontForm()
        {
            InitializeComponent();
            okButton.DialogResult = DialogResult.OK;
            cancelButton.DialogResult = DialogResult.Cancel;
            this.AcceptButton = this.okButton;
            this.CancelButton = this.cancelButton;
            apply_Button.Click += new EventHandler(applyButton_Click);
        }

       

        void applyButton_Click(Object sender, EventArgs e) {
            if (Apply != null) {
                Apply(this, new EventArgs());
            }    
        }        

        private void fontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            font = new Font(this.fontComboBox.SelectedItem.ToString(), font.Size, font.Style);
        }

        private void sizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(((RadioButton)sender).Text);
            font = new Font(this.font.OriginalFontName, size, font.Style);
        }

        private void styleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle fs = 0;
            if (this.boldCheckBox.Checked)
                fs |= FontStyle.Bold;
            if (this.italicCheckBox.Checked)
                fs |= FontStyle.Italic;
            if (this.underlineCheckBox.Checked)
                fs |= FontStyle.Underline;
            if (this.strikeoutCheckBox.Checked)
                fs |= FontStyle.Strikeout;
            this.font = new Font(font, fs);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Font = font;
        }
    }
}
