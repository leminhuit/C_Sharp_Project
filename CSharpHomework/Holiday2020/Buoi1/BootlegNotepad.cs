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
    public partial class BootlegNotepad : Form
    {
        public BootlegNotepad()
        {
            InitializeComponent();
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void selectColorTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                TextInputRichTextbox.SelectionColor = colorDialog1.Color;
            }
        }

        private void selectBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                TextInputRichTextbox.SelectionBackColor = colorDialog1.Color;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse your files";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
  
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dlr = MessageBox.Show("Bạn muốn lưu lại nội dung này không?","Lưu ý", 
                MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                saveFileDialog1.ShowDialog();
                TextInputRichTextbox.Clear();
                TextInputRichTextbox.Focus();
                TextInputRichTextbox.Font = DefaultFont;
            }
                
            else if (dlr == DialogResult.No)
            {
                TextInputRichTextbox.Clear();
                TextInputRichTextbox.Focus();
                TextInputRichTextbox.Font = DefaultFont;
            }
            else if (dlr == DialogResult.Cancel)
            { }

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                TextInputRichTextbox.Font = fontDialog1.Font;
                TextInputRichTextbox.SelectionFont = fontDialog1.Font;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            { }
        }
    }
}
