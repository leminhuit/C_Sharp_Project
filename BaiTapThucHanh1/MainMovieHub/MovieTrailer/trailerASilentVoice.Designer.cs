
namespace MainMovieHub.MovieTrailer
{
    partial class trailerASilentVoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trailerASilentVoice));
            this.axASV = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axASV)).BeginInit();
            this.SuspendLayout();
            // 
            // axASV
            // 
            this.axASV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axASV.Enabled = true;
            this.axASV.Location = new System.Drawing.Point(0, 0);
            this.axASV.Name = "axASV";
            this.axASV.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axASV.OcxState")));
            this.axASV.Size = new System.Drawing.Size(812, 586);
            this.axASV.TabIndex = 0;
            this.axASV.Enter += new System.EventHandler(this.axASV_Enter);
            // 
            // trailerASilentVoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 586);
            this.Controls.Add(this.axASV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "trailerASilentVoice";
            this.Text = "A Silent Voice Trailer";
            ((System.ComponentModel.ISupportInitialize)(this.axASV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axASV;
    }
}