using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class YourMusic : Form
    {
        public YourMusic()
        {
            InitializeComponent();
        }

        OpenFileDialog openFileDialog;
        string[] FilePaths;
        string[] FileNames;

        private void btnImport_Click(object sender, EventArgs e)
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
                    this.listMedia.Items.Add(item);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listMedia_DoubleClick(object sender, EventArgs e)
        {
            if (listMedia.SelectedIndex != -1)
            {
                int choose = listMedia.SelectedIndex;
                mediaPlayer.URL = FilePaths[choose];
                this.txtBoxNowPlaying.Text = FileNames[choose];
            }
        }
    }
}
