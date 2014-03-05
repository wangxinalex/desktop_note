﻿using System;
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

namespace DesktopNote
{
    public partial class NoteForm : Form
    {
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
            newButton_Click(null, null);
            this.NoteForm_SizeChanged(null, null);
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
            newNote.CreateDataTime = DateTime.Now;
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

        private void NoteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to exit?",
                "Desktop Note", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) {
                e.Cancel = true;
            }
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
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "text file|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK) {
                TextWriter tw = null;
                try
                {
                    saveCurrentNote();
                    tw = new StreamWriter(sfd.FileName, false, Encoding.Default);
                    tw.Write(((Note)this.Tag).Content);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
                finally {
                    if (tw != null) {
                        tw.Close();
                    }
                }
                
            }
        }

    }
}
