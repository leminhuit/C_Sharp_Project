
namespace MainMovieHub.MovieTrailer
{
    partial class trailerTheTuxedo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trailerTheTuxedo));
            this.axTux = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axTux)).BeginInit();
            this.SuspendLayout();
            // 
            // axTux
            // 
            this.axTux.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTux.Enabled = true;
            this.axTux.Location = new System.Drawing.Point(0, 0);
            this.axTux.Name = "axTux";
            this.axTux.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTux.OcxState")));
            this.axTux.Size = new System.Drawing.Size(812, 586);
            this.axTux.TabIndex = 0;
            this.axTux.Enter += new System.EventHandler(this.axTux_Enter);
            // 
            // trailerTheTuxedo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 586);
            this.Controls.Add(this.axTux);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "trailerTheTuxedo";
            this.Text = "The Tuxedo Trailer";
            ((System.ComponentModel.ISupportInitialize)(this.axTux)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axTux;
    }
}