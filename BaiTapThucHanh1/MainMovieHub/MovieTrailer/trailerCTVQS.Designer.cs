
namespace MainMovieHub.MovieTrailer
{
    partial class trailerCTVQS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trailerCTVQS));
            this.axDober = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axDober)).BeginInit();
            this.SuspendLayout();
            // 
            // axDober
            // 
            this.axDober.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axDober.Enabled = true;
            this.axDober.Location = new System.Drawing.Point(0, 0);
            this.axDober.Name = "axDober";
            this.axDober.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axDober.OcxState")));
            this.axDober.Size = new System.Drawing.Size(812, 586);
            this.axDober.TabIndex = 0;
            this.axDober.Enter += new System.EventHandler(this.axDober_Enter);
            // 
            // trailerCTVQS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 586);
            this.Controls.Add(this.axDober);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "trailerCTVQS";
            this.Text = "Cong To Vien Quan Su Doberman Trailer";
            ((System.ComponentModel.ISupportInitialize)(this.axDober)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axDober;
    }
}