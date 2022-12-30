
namespace MainMovieHub.MovieTrailer
{
    partial class trailerUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trailerUp));
            this.axWMPUp = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWMPUp)).BeginInit();
            this.SuspendLayout();
            // 
            // axWMPUp
            // 
            this.axWMPUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWMPUp.Enabled = true;
            this.axWMPUp.Location = new System.Drawing.Point(0, 0);
            this.axWMPUp.Name = "axWMPUp";
            this.axWMPUp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMPUp.OcxState")));
            this.axWMPUp.Size = new System.Drawing.Size(812, 586);
            this.axWMPUp.TabIndex = 0;
            this.axWMPUp.Enter += new System.EventHandler(this.axWMPUp_Enter);
            // 
            // trailerUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 586);
            this.Controls.Add(this.axWMPUp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "trailerUp";
            this.Text = "Up Trailer";
            ((System.ComponentModel.ISupportInitialize)(this.axWMPUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWMPUp;
    }
}