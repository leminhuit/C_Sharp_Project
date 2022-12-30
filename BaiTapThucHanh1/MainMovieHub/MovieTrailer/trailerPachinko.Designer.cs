
namespace MainMovieHub.MovieTrailer
{
    partial class trailerPachinko
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trailerPachinko));
            this.axPachinko = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axPachinko)).BeginInit();
            this.SuspendLayout();
            // 
            // axPachinko
            // 
            this.axPachinko.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axPachinko.Enabled = true;
            this.axPachinko.Location = new System.Drawing.Point(0, 0);
            this.axPachinko.Name = "axPachinko";
            this.axPachinko.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPachinko.OcxState")));
            this.axPachinko.Size = new System.Drawing.Size(812, 586);
            this.axPachinko.TabIndex = 0;
            this.axPachinko.Enter += new System.EventHandler(this.axPachinko_Enter);
            // 
            // trailerPachinko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 586);
            this.Controls.Add(this.axPachinko);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "trailerPachinko";
            this.Text = "Pachinko Trailer";
            ((System.ComponentModel.ISupportInitialize)(this.axPachinko)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axPachinko;
    }
}