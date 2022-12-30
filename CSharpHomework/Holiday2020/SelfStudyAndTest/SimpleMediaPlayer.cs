using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holiday2020
{
    public partial class SimpleMediaPlayer : Form
    {
        public SimpleMediaPlayer()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        OpenFileDialog openFileDialog;
        string[] FilePaths;
        string[] FileNames; 

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files, MP4 files (*.mp3, *.mp4) | *.mp*";
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Open";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePaths = openFileDialog.FileNames; // Lay cai duong dan 
                FileNames = openFileDialog.SafeFileNames; // Lay ten file
                foreach (var item in FileNames)
                {
                    this.listBox1.Items.Add(item);
                }
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int choose = listBox1.SelectedIndex;
                axWindowsMediaPlayer1.URL = FilePaths[choose];
                this.textBox1.Text = FileNames[choose];
            }
        }
    }
}
