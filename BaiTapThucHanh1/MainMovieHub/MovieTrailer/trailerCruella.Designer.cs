
namespace MainMovieHub.MovieTrailer
{
    partial class trailerCruella
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trailerCruella));
            this.axCruella = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axCruella)).BeginInit();
            this.SuspendLayout();
            // 
            // axCruella
            // 
            this.axCruella.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axCruella.Enabled = true;
            this.axCruella.Location = new System.Drawing.Point(0, 0);
            this.axCruella.Name = "axCruella";
            this.axCruella.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCruella.OcxState")));
            this.axCruella.Size = new System.Drawing.Size(812, 586);
            this.axCruella.TabIndex = 0;
            this.axCruella.Enter += new System.EventHandler(this.axCruella_Enter);
            // 
            // trailerCruella
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 586);
            this.Controls.Add(this.axCruella);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "trailerCruella";
            this.Text = "Cruella Trailer";
            ((System.ComponentModel.ISupportInitialize)(this.axCruella)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axCruella;
    }
}