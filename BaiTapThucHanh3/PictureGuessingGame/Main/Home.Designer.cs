
namespace Main
{
    partial class Home
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
            this.label3 = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.dgvCurrentPlayerScore = new System.Windows.Forms.DataGridView();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestTopic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentPlayerScore)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Here\'s your current achievement";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelWelcome.Location = new System.Drawing.Point(12, 9);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(417, 25);
            this.labelWelcome.TabIndex = 2;
            this.labelWelcome.Text = "Hello Player, ready to test your knowledge? ";
            // 
            // dgvCurrentPlayerScore
            // 
            this.dgvCurrentPlayerScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentPlayerScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerName,
            this.TestTopic,
            this.Score});
            this.dgvCurrentPlayerScore.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCurrentPlayerScore.Location = new System.Drawing.Point(0, 82);
            this.dgvCurrentPlayerScore.Name = "dgvCurrentPlayerScore";
            this.dgvCurrentPlayerScore.RowHeadersWidth = 51;
            this.dgvCurrentPlayerScore.RowTemplate.Height = 24;
            this.dgvCurrentPlayerScore.Size = new System.Drawing.Size(982, 471);
            this.dgvCurrentPlayerScore.TabIndex = 4;
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PlayerName.HeaderText = "Player Name";
            this.PlayerName.MinimumWidth = 6;
            this.PlayerName.Name = "PlayerName";
            // 
            // TestTopic
            // 
            this.TestTopic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TestTopic.HeaderText = "Test Topic";
            this.TestTopic.MinimumWidth = 6;
            this.TestTopic.Name = "TestTopic";
            // 
            // Score
            // 
            this.Score.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Score.HeaderText = "Score/10";
            this.Score.MinimumWidth = 6;
            this.Score.Name = "Score";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.dgvCurrentPlayerScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelWelcome);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentPlayerScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.DataGridView dgvCurrentPlayerScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestTopic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
    }
}