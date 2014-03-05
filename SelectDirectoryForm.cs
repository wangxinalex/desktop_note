using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace DesktopNote
{
    public partial class SelectDirectoryForm : Form
    {
        private String s_dir = @"c:\";

        public String Dir
        {
            get { return s_dir; }
            set {
                if (Directory.Exists(value)) {
                    s_dir = value;
                    this.workDirectoryTextBox.Text = s_dir;
                }
            }
        }

        public SelectDirectoryForm()
        {
            InitializeComponent();
            this.logicalDriveComboBox.Items.AddRange(Environment.GetLogicalDrives());
            this.logicalDriveComboBox.SelectedIndex = 0;
        }

        private void UpdateList(string directory) {
            this.directoryListBox.Items.Clear();
            this.Dir = directory;
            DirectoryInfo currentDirectoryInfo = new DirectoryInfo(directory);
            try
            {
                this.directoryListBox.Items.AddRange(currentDirectoryInfo.GetDirectories());
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }
        }

        private void logicalDriveComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.logicalDriveComboBox.SelectedItem.ToString().Equals(""))
                return;
            UpdateList(this.logicalDriveComboBox.SelectedItem.ToString());
        }

        private void UPbutton_Click(object sender, EventArgs e)
        {
            if (Directory.GetParent(this.Dir) == null)
                return;
            UpdateList(Directory.GetParent(this.Dir).FullName);
        }

        private void directoryListBox_DoubleClick(object sender, EventArgs e)
        {
            DirectoryInfo curfsi = (DirectoryInfo)this.directoryListBox.SelectedItem;
            UpdateList(curfsi.FullName);
        }
    }
}
