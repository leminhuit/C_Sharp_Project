
namespace MainMovieHub.MovieTrailer
{
    partial class trailerHotelT4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trailerHotelT4));
            this.axHT4 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axHT4)).BeginInit();
            this.SuspendLayout();
            // 
            // axHT4
            // 
            this.axHT4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axHT4.Enabled = true;
            this.axHT4.Location = new System.Drawing.Point(0, 0);
            this.axHT4.Name = "axHT4";
            this.axHT4.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axHT4.OcxState")));
            this.axHT4.Size = new System.Drawing.Size(812, 586);
            this.axHT4.TabIndex = 0;
            this.axHT4.Enter += new System.EventHandler(this.axHT4_Enter);
            // 
            // trailerHotelT4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 586);
            this.Controls.Add(this.axHT4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "trailerHotelT4";
            this.Text = "Hotel Transylvania 4";
            ((System.ComponentModel.ISupportInitialize)(this.axHT4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axHT4;
    }
}