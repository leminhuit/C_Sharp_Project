
namespace MainMovieHub.MovieTrailer
{
    partial class trailerRushHour2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trailerRushHour2));
            this.axWMPRH2 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWMPRH2)).BeginInit();
            this.SuspendLayout();
            // 
            // axWMPRH2
            // 
            this.axWMPRH2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWMPRH2.Enabled = true;
            this.axWMPRH2.Location = new System.Drawing.Point(0, 0);
            this.axWMPRH2.Name = "axWMPRH2";
            this.axWMPRH2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMPRH2.OcxState")));
            this.axWMPRH2.Size = new System.Drawing.Size(800, 450);
            this.axWMPRH2.TabIndex = 0;
            this.axWMPRH2.Enter += new System.EventHandler(this.axWMPRH2_Enter);
            // 
            // trailerRushHour2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.axWMPRH2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "trailerRushHour2";
            this.Text = "Rush Hour 2 Trailer";
            ((System.ComponentModel.ISupportInitialize)(this.axWMPRH2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWMPRH2;
    }
}