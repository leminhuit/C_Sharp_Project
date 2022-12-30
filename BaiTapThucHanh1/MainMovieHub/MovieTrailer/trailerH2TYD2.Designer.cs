
namespace MainMovieHub.MovieTrailer
{
    partial class trailerH2TYD2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trailerH2TYD2));
            this.axWMPTrainDrag2 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWMPTrainDrag2)).BeginInit();
            this.SuspendLayout();
            // 
            // axWMPTrainDrag2
            // 
            this.axWMPTrainDrag2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWMPTrainDrag2.Enabled = true;
            this.axWMPTrainDrag2.Location = new System.Drawing.Point(0, 0);
            this.axWMPTrainDrag2.Name = "axWMPTrainDrag2";
            this.axWMPTrainDrag2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMPTrainDrag2.OcxState")));
            this.axWMPTrainDrag2.Size = new System.Drawing.Size(812, 586);
            this.axWMPTrainDrag2.TabIndex = 0;
            this.axWMPTrainDrag2.Enter += new System.EventHandler(this.axWMPTrainDrag2_Enter);
            // 
            // trailerH2TYD2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 586);
            this.Controls.Add(this.axWMPTrainDrag2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "trailerH2TYD2";
            this.Text = "How To Train Your Dragon 2";
            ((System.ComponentModel.ISupportInitialize)(this.axWMPTrainDrag2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWMPTrainDrag2;
    }
}