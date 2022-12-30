
namespace MainMovieHub.MovieTrailer
{
    partial class trailerSpidermanNWH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trailerSpidermanNWH));
            this.axSpooder = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axSpooder)).BeginInit();
            this.SuspendLayout();
            // 
            // axSpooder
            // 
            this.axSpooder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axSpooder.Enabled = true;
            this.axSpooder.Location = new System.Drawing.Point(0, 0);
            this.axSpooder.Name = "axSpooder";
            this.axSpooder.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axSpooder.OcxState")));
            this.axSpooder.Size = new System.Drawing.Size(812, 586);
            this.axSpooder.TabIndex = 0;
            this.axSpooder.Enter += new System.EventHandler(this.axSpooder_Enter);
            // 
            // trailerSpidermanNWH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 586);
            this.Controls.Add(this.axSpooder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "trailerSpidermanNWH";
            this.Text = "Spider-man No Way Home Trailer";
            ((System.ComponentModel.ISupportInitialize)(this.axSpooder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axSpooder;
    }
}