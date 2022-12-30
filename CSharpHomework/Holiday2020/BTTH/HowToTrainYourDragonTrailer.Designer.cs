
namespace Holiday2020.BTTH
{
    partial class HowToTrainYourDragonTrailer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToTrainYourDragonTrailer));
            this.WMP_H2TYD = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.WMP_H2TYD)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP_H2TYD
            // 
            this.WMP_H2TYD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WMP_H2TYD.Enabled = true;
            this.WMP_H2TYD.Location = new System.Drawing.Point(0, 0);
            this.WMP_H2TYD.Name = "WMP_H2TYD";
            this.WMP_H2TYD.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP_H2TYD.OcxState")));
            this.WMP_H2TYD.Size = new System.Drawing.Size(942, 646);
            this.WMP_H2TYD.TabIndex = 0;
            this.WMP_H2TYD.Enter += new System.EventHandler(this.WMP_H2TYD_Enter);
            // 
            // HowToTrainYourDragonTrailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 646);
            this.Controls.Add(this.WMP_H2TYD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HowToTrainYourDragonTrailer";
            this.Text = "How To Train Your Dragon 2";
            ((System.ComponentModel.ISupportInitialize)(this.WMP_H2TYD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP_H2TYD;
    }
}