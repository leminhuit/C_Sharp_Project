
namespace MainForm
{
    partial class DailyHealthTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyHealthTracker));
            this.progressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.ckBoxDrinkWater = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ckBoxExercise = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ckBoxMeditating = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ckBoxGoOutside = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ckBoxEnoughSleep = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ckBoxWriteGrateful = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ckBoxTalkToFriends = new Guna.UI2.WinForms.Guna2CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.progressBar.FillThickness = 30;
            this.progressBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.progressBar.ForeColor = System.Drawing.Color.White;
            this.progressBar.Location = new System.Drawing.Point(779, 138);
            this.progressBar.Maximum = 140;
            this.progressBar.Minimum = 0;
            this.progressBar.Name = "progressBar";
            this.progressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressBar.Size = new System.Drawing.Size(341, 341);
            this.progressBar.TabIndex = 1;
            this.progressBar.Text = "guna2CircleProgressBar1";
            this.progressBar.ValueChanged += new System.EventHandler(this.progressBar_ValueChanged);
            // 
            // ckBoxDrinkWater
            // 
            this.ckBoxDrinkWater.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckBoxDrinkWater.AutoSize = true;
            this.ckBoxDrinkWater.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckBoxDrinkWater.CheckedState.BorderRadius = 0;
            this.ckBoxDrinkWater.CheckedState.BorderThickness = 0;
            this.ckBoxDrinkWater.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckBoxDrinkWater.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBoxDrinkWater.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ckBoxDrinkWater.Location = new System.Drawing.Point(103, 98);
            this.ckBoxDrinkWater.Name = "ckBoxDrinkWater";
            this.ckBoxDrinkWater.Size = new System.Drawing.Size(384, 36);
            this.ckBoxDrinkWater.TabIndex = 2;
            this.ckBoxDrinkWater.Text = "Drink At Least 2 Liters Of Water";
            this.ckBoxDrinkWater.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckBoxDrinkWater.UncheckedState.BorderRadius = 0;
            this.ckBoxDrinkWater.UncheckedState.BorderThickness = 0;
            this.ckBoxDrinkWater.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckBoxDrinkWater.CheckedChanged += new System.EventHandler(this.ckBoxDrinkWater_CheckedChanged);
            // 
            // ckBoxExercise
            // 
            this.ckBoxExercise.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckBoxExercise.AutoSize = true;
            this.ckBoxExercise.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckBoxExercise.CheckedState.BorderRadius = 0;
            this.ckBoxExercise.CheckedState.BorderThickness = 0;
            this.ckBoxExercise.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckBoxExercise.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBoxExercise.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ckBoxExercise.Location = new System.Drawing.Point(103, 162);
            this.ckBoxExercise.Name = "ckBoxExercise";
            this.ckBoxExercise.Size = new System.Drawing.Size(391, 36);
            this.ckBoxExercise.TabIndex = 3;
            this.ckBoxExercise.Text = "Exercise At Least 10 - 15 Minutes";
            this.ckBoxExercise.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckBoxExercise.UncheckedState.BorderRadius = 0;
            this.ckBoxExercise.UncheckedState.BorderThickness = 0;
            this.ckBoxExercise.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckBoxExercise.CheckedChanged += new System.EventHandler(this.ckBoxExercise_CheckedChanged);
            // 
            // ckBoxMeditating
            // 
            this.ckBoxMeditating.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckBoxMeditating.AutoSize = true;
            this.ckBoxMeditating.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckBoxMeditating.CheckedState.BorderRadius = 0;
            this.ckBoxMeditating.CheckedState.BorderThickness = 0;
            this.ckBoxMeditating.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckBoxMeditating.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBoxMeditating.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ckBoxMeditating.Location = new System.Drawing.Point(103, 226);
            this.ckBoxMeditating.Name = "ckBoxMeditating";
            this.ckBoxMeditating.Size = new System.Drawing.Size(567, 36);
            this.ckBoxMeditating.TabIndex = 4;
            this.ckBoxMeditating.Text = "Spend Some Time Meditating/Sitting by Yourself";
            this.ckBoxMeditating.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckBoxMeditating.UncheckedState.BorderRadius = 0;
            this.ckBoxMeditating.UncheckedState.BorderThickness = 0;
            this.ckBoxMeditating.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckBoxMeditating.CheckedChanged += new System.EventHandler(this.ckBoxMeditating_CheckedChanged);
            // 
            // ckBoxGoOutside
            // 
            this.ckBoxGoOutside.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckBoxGoOutside.AutoSize = true;
            this.ckBoxGoOutside.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckBoxGoOutside.CheckedState.BorderRadius = 0;
            this.ckBoxGoOutside.CheckedState.BorderThickness = 0;
            this.ckBoxGoOutside.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckBoxGoOutside.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBoxGoOutside.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ckBoxGoOutside.Location = new System.Drawing.Point(103, 290);
            this.ckBoxGoOutside.Name = "ckBoxGoOutside";
            this.ckBoxGoOutside.Size = new System.Drawing.Size(424, 36);
            this.ckBoxGoOutside.TabIndex = 5;
            this.ckBoxGoOutside.Text = "Go Outside and Get Some Fresh Air";
            this.ckBoxGoOutside.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckBoxGoOutside.UncheckedState.BorderRadius = 0;
            this.ckBoxGoOutside.UncheckedState.BorderThickness = 0;
            this.ckBoxGoOutside.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckBoxGoOutside.CheckedChanged += new System.EventHandler(this.ckBoxGoOutside_CheckedChanged);
            // 
            // ckBoxEnoughSleep
            // 
            this.ckBoxEnoughSleep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckBoxEnoughSleep.AutoSize = true;
            this.ckBoxEnoughSleep.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckBoxEnoughSleep.CheckedState.BorderRadius = 0;
            this.ckBoxEnoughSleep.CheckedState.BorderThickness = 0;
            this.ckBoxEnoughSleep.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckBoxEnoughSleep.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBoxEnoughSleep.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ckBoxEnoughSleep.Location = new System.Drawing.Point(103, 354);
            this.ckBoxEnoughSleep.Name = "ckBoxEnoughSleep";
            this.ckBoxEnoughSleep.Size = new System.Drawing.Size(559, 36);
            this.ckBoxEnoughSleep.TabIndex = 6;
            this.ckBoxEnoughSleep.Text = "Get Enough Sleep for the Day (At least 7 Hours)";
            this.ckBoxEnoughSleep.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckBoxEnoughSleep.UncheckedState.BorderRadius = 0;
            this.ckBoxEnoughSleep.UncheckedState.BorderThickness = 0;
            this.ckBoxEnoughSleep.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckBoxEnoughSleep.CheckedChanged += new System.EventHandler(this.ckBoxEnoughSleep_CheckedChanged);
            // 
            // ckBoxWriteGrateful
            // 
            this.ckBoxWriteGrateful.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckBoxWriteGrateful.AutoSize = true;
            this.ckBoxWriteGrateful.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckBoxWriteGrateful.CheckedState.BorderRadius = 0;
            this.ckBoxWriteGrateful.CheckedState.BorderThickness = 0;
            this.ckBoxWriteGrateful.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckBoxWriteGrateful.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBoxWriteGrateful.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ckBoxWriteGrateful.Location = new System.Drawing.Point(103, 418);
            this.ckBoxWriteGrateful.Name = "ckBoxWriteGrateful";
            this.ckBoxWriteGrateful.Size = new System.Drawing.Size(463, 36);
            this.ckBoxWriteGrateful.TabIndex = 7;
            this.ckBoxWriteGrateful.Text = "Write Down What You Are Grateful For";
            this.ckBoxWriteGrateful.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckBoxWriteGrateful.UncheckedState.BorderRadius = 0;
            this.ckBoxWriteGrateful.UncheckedState.BorderThickness = 0;
            this.ckBoxWriteGrateful.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckBoxWriteGrateful.CheckedChanged += new System.EventHandler(this.ckBoxWriteGrateful_CheckedChanged);
            // 
            // ckBoxTalkToFriends
            // 
            this.ckBoxTalkToFriends.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckBoxTalkToFriends.AutoSize = true;
            this.ckBoxTalkToFriends.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckBoxTalkToFriends.CheckedState.BorderRadius = 0;
            this.ckBoxTalkToFriends.CheckedState.BorderThickness = 0;
            this.ckBoxTalkToFriends.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckBoxTalkToFriends.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBoxTalkToFriends.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ckBoxTalkToFriends.Location = new System.Drawing.Point(103, 482);
            this.ckBoxTalkToFriends.Name = "ckBoxTalkToFriends";
            this.ckBoxTalkToFriends.Size = new System.Drawing.Size(441, 36);
            this.ckBoxTalkToFriends.TabIndex = 8;
            this.ckBoxTalkToFriends.Text = "Talk To Your Friends/Family Members";
            this.ckBoxTalkToFriends.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckBoxTalkToFriends.UncheckedState.BorderRadius = 0;
            this.ckBoxTalkToFriends.UncheckedState.BorderThickness = 0;
            this.ckBoxTalkToFriends.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckBoxTalkToFriends.CheckedChanged += new System.EventHandler(this.ckBoxTalkToFriends_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1182, 92);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // DailyHealthTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ckBoxTalkToFriends);
            this.Controls.Add(this.ckBoxWriteGrateful);
            this.Controls.Add(this.ckBoxEnoughSleep);
            this.Controls.Add(this.ckBoxGoOutside);
            this.Controls.Add(this.ckBoxMeditating);
            this.Controls.Add(this.ckBoxExercise);
            this.Controls.Add(this.ckBoxDrinkWater);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DailyHealthTracker";
            this.Text = "Daily Health Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DailyHealthTracker_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar progressBar;
        private Guna.UI2.WinForms.Guna2CheckBox ckBoxDrinkWater;
        private Guna.UI2.WinForms.Guna2CheckBox ckBoxExercise;
        private Guna.UI2.WinForms.Guna2CheckBox ckBoxMeditating;
        private Guna.UI2.WinForms.Guna2CheckBox ckBoxGoOutside;
        private Guna.UI2.WinForms.Guna2CheckBox ckBoxEnoughSleep;
        private Guna.UI2.WinForms.Guna2CheckBox ckBoxWriteGrateful;
        private Guna.UI2.WinForms.Guna2CheckBox ckBoxTalkToFriends;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}