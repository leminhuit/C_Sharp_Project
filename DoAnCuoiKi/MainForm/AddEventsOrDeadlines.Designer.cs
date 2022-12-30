
namespace MainForm
{
    partial class AddEventsOrDeadlines
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveEvents = new Guna.UI2.WinForms.Guna2Button();
            this.txtBoxDayStart = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxEventName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxEventDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnReturn = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboBoxEventCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(70, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(70, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Event/Deadline";
            // 
            // btnSaveEvents
            // 
            this.btnSaveEvents.AutoRoundedCorners = true;
            this.btnSaveEvents.BorderRadius = 21;
            this.btnSaveEvents.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveEvents.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveEvents.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveEvents.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveEvents.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEvents.ForeColor = System.Drawing.Color.White;
            this.btnSaveEvents.Location = new System.Drawing.Point(608, 393);
            this.btnSaveEvents.Name = "btnSaveEvents";
            this.btnSaveEvents.Size = new System.Drawing.Size(156, 45);
            this.btnSaveEvents.TabIndex = 3;
            this.btnSaveEvents.Text = "Save";
            this.btnSaveEvents.Click += new System.EventHandler(this.btnSaveEvents_Click);
            // 
            // txtBoxDayStart
            // 
            this.txtBoxDayStart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxDayStart.DefaultText = "";
            this.txtBoxDayStart.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxDayStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxDayStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxDayStart.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxDayStart.Enabled = false;
            this.txtBoxDayStart.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxDayStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxDayStart.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxDayStart.Location = new System.Drawing.Point(273, 17);
            this.txtBoxDayStart.Name = "txtBoxDayStart";
            this.txtBoxDayStart.PasswordChar = '\0';
            this.txtBoxDayStart.PlaceholderText = "";
            this.txtBoxDayStart.ReadOnly = true;
            this.txtBoxDayStart.SelectedText = "";
            this.txtBoxDayStart.Size = new System.Drawing.Size(289, 36);
            this.txtBoxDayStart.TabIndex = 4;
            // 
            // txtBoxEventName
            // 
            this.txtBoxEventName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxEventName.DefaultText = "";
            this.txtBoxEventName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxEventName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxEventName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEventName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEventName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEventName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxEventName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEventName.Location = new System.Drawing.Point(273, 107);
            this.txtBoxEventName.Name = "txtBoxEventName";
            this.txtBoxEventName.PasswordChar = '\0';
            this.txtBoxEventName.PlaceholderText = "";
            this.txtBoxEventName.SelectedText = "";
            this.txtBoxEventName.Size = new System.Drawing.Size(289, 36);
            this.txtBoxEventName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(70, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description";
            // 
            // txtBoxEventDescription
            // 
            this.txtBoxEventDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxEventDescription.DefaultText = "";
            this.txtBoxEventDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxEventDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxEventDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEventDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEventDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEventDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxEventDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEventDescription.Location = new System.Drawing.Point(273, 291);
            this.txtBoxEventDescription.Multiline = true;
            this.txtBoxEventDescription.Name = "txtBoxEventDescription";
            this.txtBoxEventDescription.PasswordChar = '\0';
            this.txtBoxEventDescription.PlaceholderText = "";
            this.txtBoxEventDescription.SelectedText = "";
            this.txtBoxEventDescription.Size = new System.Drawing.Size(289, 145);
            this.txtBoxEventDescription.TabIndex = 8;
            // 
            // btnReturn
            // 
            this.btnReturn.AutoRoundedCorners = true;
            this.btnReturn.BorderRadius = 21;
            this.btnReturn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(12, 393);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(156, 45);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(70, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Category";
            // 
            // cboBoxEventCategory
            // 
            this.cboBoxEventCategory.BackColor = System.Drawing.Color.Transparent;
            this.cboBoxEventCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBoxEventCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxEventCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboBoxEventCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboBoxEventCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboBoxEventCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboBoxEventCategory.ItemHeight = 30;
            this.cboBoxEventCategory.Items.AddRange(new object[] {
            "Deadline",
            "Short-term Goal",
            "Long-term Goal",
            "Others"});
            this.cboBoxEventCategory.Location = new System.Drawing.Point(273, 197);
            this.cboBoxEventCategory.Name = "cboBoxEventCategory";
            this.cboBoxEventCategory.Size = new System.Drawing.Size(289, 36);
            this.cboBoxEventCategory.TabIndex = 11;
            // 
            // AddEventsOrDeadlines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboBoxEventCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtBoxEventDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxEventName);
            this.Controls.Add(this.txtBoxDayStart);
            this.Controls.Add(this.btnSaveEvents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEventsOrDeadlines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEventsOrDeadlines";
            this.Load += new System.EventHandler(this.AddEventsOrDeadlines_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnSaveEvents;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxDayStart;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxEventName;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxEventDescription;
        private Guna.UI2.WinForms.Guna2Button btnReturn;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cboBoxEventCategory;
    }
}