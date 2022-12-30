
namespace Main
{
    partial class VehicleQuizzes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleQuizzes));
            this.labelCorrectValue = new System.Windows.Forms.Label();
            this.labelIncorrectValue = new System.Windows.Forms.Label();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.picBoxImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCorrectValue
            // 
            this.labelCorrectValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCorrectValue.AutoSize = true;
            this.labelCorrectValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(100)))), ((int)(((byte)(240)))));
            this.labelCorrectValue.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorrectValue.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelCorrectValue.Location = new System.Drawing.Point(716, 202);
            this.labelCorrectValue.Name = "labelCorrectValue";
            this.labelCorrectValue.Size = new System.Drawing.Size(138, 31);
            this.labelCorrectValue.TabIndex = 14;
            this.labelCorrectValue.Text = "Correct : 0";
            // 
            // labelIncorrectValue
            // 
            this.labelIncorrectValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIncorrectValue.AutoSize = true;
            this.labelIncorrectValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.labelIncorrectValue.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncorrectValue.ForeColor = System.Drawing.Color.Gold;
            this.labelIncorrectValue.Location = new System.Drawing.Point(716, 343);
            this.labelIncorrectValue.Name = "labelIncorrectValue";
            this.labelIncorrectValue.Size = new System.Drawing.Size(158, 31);
            this.labelIncorrectValue.TabIndex = 13;
            this.labelIncorrectValue.Text = "Incorrect : 0";
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxInput.Location = new System.Drawing.Point(315, 494);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(361, 31);
            this.txtBoxInput.TabIndex = 12;
            this.txtBoxInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxInput_KeyUp);
            // 
            // picBoxImage
            // 
            this.picBoxImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(51)))), ((int)(((byte)(245)))));
            this.picBoxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxImage.Location = new System.Drawing.Point(315, 105);
            this.picBoxImage.Name = "picBoxImage";
            this.picBoxImage.Size = new System.Drawing.Size(361, 366);
            this.picBoxImage.TabIndex = 11;
            this.picBoxImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(69)))), ((int)(((byte)(233)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(274, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "VEHICLE VOCABULARIES";
            // 
            // VehicleQuizzes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.labelCorrectValue);
            this.Controls.Add(this.labelIncorrectValue);
            this.Controls.Add(this.txtBoxInput);
            this.Controls.Add(this.picBoxImage);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VehicleQuizzes";
            this.Text = "Vehicle Quizzes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VehicleQuizzes_FormClosed);
            this.Load += new System.EventHandler(this.VehicleQuizzes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCorrectValue;
        private System.Windows.Forms.Label labelIncorrectValue;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.PictureBox picBoxImage;
        private System.Windows.Forms.Label label1;
    }
}