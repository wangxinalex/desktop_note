using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace DesktopNote
{
    public partial class NoteForm : Form
    {
        string[] fs_str = {"Bold", "Italic","Underline","Strikeout"};
        FontStyle[] fs_fs = {FontStyle.Bold, FontStyle.Italic, FontStyle.Underline, FontStyle.Strikeout };

        private ArrayList noteList = new ArrayList();
        private ArrayList definedCombinationList = new ArrayList();

        public NoteForm()
        {
            InitializeComponent();
            initDefinedCombinationList();
        }

         public void initDefinedCombinationList() {
            for (int i = 0; i < 9; i++) {
                DefinedCombination dc = new DefinedCombination();
                dc.Prefix = '/';
                dc.Replaced = (char)((int)'1'+i);
                dc.Replacement = (char)((int)'\x2460' + i);
                this.definedCombinationList.Add(dc);
            }
        }
        
        private void refreshMainTextBox() {
            if (this.Tag != null && this.Tag is Note) {
                Note currentNote = (Note)this.Tag;
                this.mainTextBox.Text = currentNote.Content;
                this.mainTextBox.BackColor = currentNote.BackColor;
                this.mainTextBox.ForeColor = currentNote.ForeColor;
                this.mainTextBox.Font = currentNote.Font;
            }
            this.Text = "Desktop Note("+(this.noteList.IndexOf(this.Tag)+1)+"/"+this.noteList.Count+")";
            this.noteFormStatusStrip.Items[0].Text = "Desktop Note("+(this.noteList.IndexOf(this.Tag)+1)+"/"+this.noteList.Count+")";
        }

        private void NoteForm_Load(object sender, EventArgs e)
        {
            //newButton_Click(null, null);
            //this.deSerializeNote();
            loadNoteFromXML();
            this.NoteForm_SizeChanged(null, null);
        }

        private void NoteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to exit?",
                "Desktop Note", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            else {
                //this.serializeNote();
                this.saveNoteToXML();
            }
        }

        private void saveCurrentNote() {
            if (this.Tag != null && this.Tag is Note) {
                Note currentNote = (Note)this.Tag;
                currentNote.Content = this.mainTextBox.Text;
                currentNote.BackColor= this.mainTextBox.BackColor;
                currentNote.ForeColor = this.mainTextBox.ForeColor;
                currentNote.Font = this.mainTextBox.Font;
                currentNote.ModifyDateTime = DateTime.Now;
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            saveCurrentNote();
            Note newNote = new Note();
            newNote.CreateDateTime = DateTime.Now;
            this.Tag = newNote;
            noteList.Add(newNote);
            refreshMainTextBox();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            int index = noteList.IndexOf(this.Tag);
            if (this.Tag != null && this.Tag is Note) {
                noteList.Remove(this.Tag);
            }
            if (noteList.Count > 0)
            {
                this.Tag = noteList[index % noteList.Count];
                refreshMainTextBox();
            }
            else {
                newButton_Click(this, new EventArgs());
            }
        }

        private void preButton_Click(object sender, EventArgs e)
        {
            saveCurrentNote();
            int index = noteList.IndexOf(this.Tag);
            if (index >= 1) { 
                this.Tag = noteList[index-1];
            }
            refreshMainTextBox();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            saveCurrentNote();
            int index = noteList.IndexOf(this.Tag);
            if (index + 1 < noteList.Count) { 
                this.Tag = noteList[index + 1];
            }
            refreshMainTextBox();
        }


        private void setBackgroundButton_Click(object sender, EventArgs e)
        {
            ColorDialog cDialog = new ColorDialog();
            if (cDialog.ShowDialog() == DialogResult.OK) {
                this.mainTextBox.BackColor = cDialog.Color;
            }
        }

        private void setFontButton_Click(object sender, EventArgs e)
        {
            FontForm fontForm = new FontForm();
            fontForm.NoteFont = this.mainTextBox.Font;
            fontForm.Apply += new EventHandler(fontForm_Apply);
            if (fontForm.ShowDialog() == DialogResult.OK) {
                this.mainTextBox.Font = fontForm.NoteFont;
            }
        }

        void fontForm_Apply(object sender, EventArgs e) {
            this.mainTextBox.Font = ((FontForm)sender).NoteFont;
        }

        private void setForeColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog cDialog = new ColorDialog();
            if (cDialog.ShowDialog() == DialogResult.OK) {
                this.mainTextBox.ForeColor = cDialog.Color;
            }

        }

        private void mainTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers != Keys.Control) {
                return;
            }
            if (e.KeyCode == Keys.Up) {
                this.Top -= 10;
            }
            if (e.KeyCode == Keys.Down) {
                this.Top += 10;
            }
            if (e.KeyCode == Keys.Left) {
                this.Left -= 10;
            }
            if (e.KeyCode == Keys.Right) {
                this.Left += 10;
            }
        }

        private void mainTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = null;
            if (sender is TextBox)
            {
                textBox = (TextBox)sender;
            }
            else {
                return;
            }
            int ss = textBox.SelectionStart;
            if (ss == 0) {
                return;
            }
            foreach (DefinedCombination dc in this.definedCombinationList) {
                if (dc.Prefix == textBox.Text[ss - 1] && dc.Replaced == e.KeyChar) {
                    textBox.Text = textBox.Text.Remove(ss - 1, 1);
                    textBox.Text = textBox.Text.Insert(ss - 1, Convert.ToString(dc.Replacement));
                    textBox.SelectionStart = ss;
                    textBox.SelectionLength = 0;
                    e.Handled = true;

                }
            }

        }

        private void exitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NoteForm_SizeChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem toDelItem = null;
            foreach (ToolStripMenuItem item in this.editEToolStripMenuItem.DropDownItems) {
                if (item.Name.Equals("windowsStateMenuItem")) {
                    toDelItem = item;
                }
            }
            this.editEToolStripMenuItem.DropDownItems.Remove(toDelItem);
            ToolStripMenuItem windowsStateMenuItem;
            if (this.WindowState == FormWindowState.Normal)
            {
                windowsStateMenuItem = new ToolStripMenuItem("Maximize");
            }
            else {
                windowsStateMenuItem = new ToolStripMenuItem("Minimize");
            }
            windowsStateMenuItem.Name = "windowsStateMenuItem";
            windowsStateMenuItem.Click += new EventHandler(windowsStateMenuItem_Click);
            this.editEToolStripMenuItem.DropDownItems.Add(windowsStateMenuItem);
        }

        void windowsStateMenuItem_Click(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter= "text file|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK) {
                TextReader tr = null;
                if (this.Tag == null) {
                    this.newButton_Click(this,null);
                }
                Note currentNote = (Note)this.Tag;
                try
                {
                    tr = new StreamReader(ofd.FileName, Encoding.Default);
                    currentNote.Content = tr.ReadToEnd();
                    this.refreshMainTextBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
                finally {
                    if (tr != null) {
                        tr.Close();
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.Filter = "text file|*.txt";
            //if (sfd.ShowDialog() == DialogResult.OK) {
            //    TextWriter tw = null;
            //    try
            //    {
            //        saveCurrentNote();
            //        tw = new StreamWriter(sfd.FileName, false, Encoding.Default);
            //        tw.Write(((Note)this.Tag).Content);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Exception: " + ex.Message);
            //    }
            //    finally {
            //        if (tw != null) {
            //            tw.Close();
            //        }
            //    }
                
            //}
            saveNoteToXML();
        }

        private void loadNote() {
            string workDirectory = Properties.Settings.Default.WorkDirectory;
            noteList.Clear();
            if (Directory.Exists(workDirectory) == false) {
                Directory.CreateDirectory(workDirectory);
            }
            String[] txtFiles = Directory.GetFiles(workDirectory,"*.txt");
            foreach (String txtFile in txtFiles) {
                Note note = new Note();
                StreamReader tr = null;
                try
                {
                    tr = new StreamReader(txtFile, Encoding.Default);
                    note.Content = tr.ReadToEnd();
                    noteList.Add(note);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
                finally
                {
                    if (tr != null)
                    {
                        tr.Close();
                    }
                }
                if (noteList.Count != 0)
                {
                    this.Tag = noteList[0];
                }
                else {
                    newButton_Click(null, null);
                }
                refreshMainTextBox();
            }
        }

        private void saveNote() {
            string workDirectory = Properties.Settings.Default.WorkDirectory;
            if (Directory.Exists(workDirectory) == false) {
                Directory.CreateDirectory(workDirectory);
            }
            for(int i = 0; i < this.noteList.Count; i++) {
                TextWriter tw = null;
                try
                {
                    saveCurrentNote();
                    tw = new StreamWriter(workDirectory + "\\" + i + ".txt", false, Encoding.Default);
                    tw.Write(((Note)noteList[i]).Content);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Save Exception " + ex.Message);
                }
                finally {
                    if (tw != null) {
                        tw.Close();
                    }
                }
            }
        }
        private void setWorkDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectDirectoryForm sdf = new SelectDirectoryForm();
            if (sdf.ShowDialog() == DialogResult.OK) {
                Properties.Settings.Default.WorkDirectory = sdf.Dir;
                Properties.Settings.Default.Save();
            }
            loadNote();
        }

        private void saveNoteToXML() {
            saveCurrentNote();
            
            string saveFile = Application.StartupPath+"\\Notes.xml";
            XDocument xDoc = new XDocument();
            XElement root = new XElement("Notes");
            xDoc.Add(root);
            xDoc.Save(saveFile);
            
            XElement xe = XDocument.Load(saveFile).Element("Notes");
            foreach(Note note in this.noteList){
                XElement record = new XElement("Note",
                        new XElement("Content", note.Content),
                        new XElement("BackColor", note.BackColor.ToArgb().ToString()),
                        new XElement("CreateDateTime", note.CreateDateTime.ToString()),
                        new XElement("Font",
                            new XAttribute("Name", note.Font.Name.ToString()),
                            new XAttribute("Size", note.Font.Size.ToString()),
                            new XAttribute("Style", note.Font.Style.ToString())),
                        new XElement("ForeColor", note.ForeColor.ToArgb().ToString()),
                        new XElement("ModifyDateTime", note.ModifyDateTime.ToString()));

                xe.Add(record);
            }
            xe.Save(saveFile);
        }

        private void loadNoteFromXML() {
            noteList.Clear();
            string saveFile = Application.StartupPath+"\\Notes.xml";
            XElement xe = XDocument.Load(saveFile).Element("Notes");
            IEnumerable<XElement> elements = from ele in xe.Elements("Note")
                                             select ele;
            loadListbyElements(elements);
        }
        private void loadListbyElements(IEnumerable<XElement> elements){
            foreach(var ele in elements){
                Note note = new Note();
                note.Content = ele.Element("Content").Value;
                note.BackColor = Color.FromArgb(Convert.ToInt32(ele.Element("BackColor").Value));
                note.ForeColor = Color.FromArgb(Convert.ToInt32(ele.Element("ForeColor").Value));
                note.CreateDateTime = DateTime.Parse(ele.Element("CreateDateTime").Value);
                note.ModifyDateTime = DateTime.Parse(ele.Element("ModifyDateTime").Value);
                FontStyle fs = new FontStyle();
                string s_fs = ele.Element("Font").Attribute("Style").Value;
                for (int i = 0; i < fs_str.Length; i++) {
                    if (s_fs.Contains(fs_str[i])) {
                        fs |= fs_fs[i];
                    }
                }
                note.Font = new Font(ele.Element("Font").Attribute("Name").Value,
                        Convert.ToInt32(ele.Element("Font").Attribute("Size").Value),
                        fs);
                noteList.Add(note);
            }
            if (noteList.Count != 0) {
                this.Tag = noteList[0];
            } else {
                newButton_Click(null, null);
            }
            this.refreshMainTextBox();

        }

        private void serializeNote() {
            Stream stream = null;
            try
            {
                this.saveCurrentNote();
                BinaryFormatter Transfer = new BinaryFormatter();
                stream = new FileStream(Application.StartupPath + "\\myNotes.bin",
                FileMode.Create, FileAccess.Write, FileShare.None);
                Transfer.Serialize(stream, this.noteList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                if (stream != null) {
                    stream.Close();
                }
            }
        }

        private void deSerializeNote()
        {
            Stream stream = null;
            try
            {
                this.saveCurrentNote();
                BinaryFormatter Transfer = new BinaryFormatter();
                stream = new FileStream(Application.StartupPath + "\\myNotes.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                this.noteList = (ArrayList)Transfer.Deserialize(stream);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }

            if (noteList.Count != 0){
                this.Tag = noteList[0];
            }
            else {
                newButton_Click(null,null);
            }
            this.refreshMainTextBox();
        }

        private void mainTextBox_DragEnter(object sender, DragEventArgs e) {
            IDataObject ido = e.Data;
            if (ido.GetDataPresent(DataFormats.Text, true)) {
                if ((e.KeyState & 0x08) != 0) {
                    e.Effect = DragDropEffects.Copy;
                } else {
                    e.Effect = DragDropEffects.Move;
                }
            } else {
                e.Effect = DragDropEffects.None;
            }
        }

        private void mainTextBox_DragDrop(object sender, DragEventArgs e) {
            IDataObject ido = e.Data;
            if (ido.GetDataPresent(DataFormats.StringFormat, true)) {
                String str = (String)ido.GetData(DataFormats.StringFormat, true);
                this.mainTextBox.Text += str;
            }
        }

        private void mainTextBox_MouseDown(object sender, MouseEventArgs e) {
            if (!this.mainTextBox.SelectedText.Equals("")) {
                int start = mainTextBox.SelectionStart;
                int length = mainTextBox.SelectionLength;
                DragDropEffects dde = mainTextBox.DoDragDrop(mainTextBox.SelectedText, DragDropEffects.Copy|DragDropEffects.Move);
                if (dde == DragDropEffects.Move) {
                    mainTextBox.Text = mainTextBox.Text.Remove(start, length);
                }
            }
        }

        private void mainTextBox_QueryContinueDrag(object sender, QueryContinueDragEventArgs e) {
            if (e.EscapePressed) {
                e.Action = DragAction.Cancel;
            }
        }
    }
}
