
namespace MainMovieHub.MovieTrailer
{
    partial class trailer5cms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trailer5cms));
            this.ax5cms = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.ax5cms)).BeginInit();
            this.SuspendLayout();
            // 
            // ax5cms
            // 
            this.ax5cms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ax5cms.Enabled = true;
            this.ax5cms.Location = new System.Drawing.Point(0, 0);
            this.ax5cms.Name = "ax5cms";
            this.ax5cms.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ax5cms.OcxState")));
            this.ax5cms.Size = new System.Drawing.Size(812, 586);
            this.ax5cms.TabIndex = 0;
            this.ax5cms.Enter += new System.EventHandler(this.ax5cms_Enter);
            // 
            // trailer5cms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 586);
            this.Controls.Add(this.ax5cms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "trailer5cms";
            this.Text = "5 cm/s Trailer";
            ((System.ComponentModel.ISupportInitialize)(this.ax5cms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer ax5cms;
    }
}