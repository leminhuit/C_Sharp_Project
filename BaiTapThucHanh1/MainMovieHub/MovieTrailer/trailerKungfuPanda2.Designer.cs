
namespace MainMovieHub.MovieTrailer
{
    partial class trailerKungfuPanda2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trailerKungfuPanda2));
            this.axWMPKFP2 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWMPKFP2)).BeginInit();
            this.SuspendLayout();
            // 
            // axWMPKFP2
            // 
            this.axWMPKFP2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWMPKFP2.Enabled = true;
            this.axWMPKFP2.Location = new System.Drawing.Point(0, 0);
            this.axWMPKFP2.Name = "axWMPKFP2";
            this.axWMPKFP2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMPKFP2.OcxState")));
            this.axWMPKFP2.Size = new System.Drawing.Size(812, 586);
            this.axWMPKFP2.TabIndex = 0;
            this.axWMPKFP2.Enter += new System.EventHandler(this.axWMPKFP2_Enter);
            // 
            // trailerKungfuPanda2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 586);
            this.Controls.Add(this.axWMPKFP2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "trailerKungfuPanda2";
            this.Text = "Kungfu Panda 2 Trailer";
            ((System.ComponentModel.ISupportInitialize)(this.axWMPKFP2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWMPKFP2;
    }
}