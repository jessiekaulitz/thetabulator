namespace TheTabulator
{
    partial class EventScreen
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
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.eventDateLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.startTimeInput = new System.Windows.Forms.TextBox();
            this.endTimeInput = new System.Windows.Forms.TextBox();
            this.eventButton = new System.Windows.Forms.Button();
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationInput = new System.Windows.Forms.TextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.eventNameLabel.Location = new System.Drawing.Point(65, 45);
            this.eventNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(79, 16);
            this.eventNameLabel.TabIndex = 4;
            this.eventNameLabel.Text = "Event Name:";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.startTimeLabel.Location = new System.Drawing.Point(81, 73);
            this.startTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(63, 16);
            this.startTimeLabel.TabIndex = 5;
            this.startTimeLabel.Text = "Start Time:";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.endTimeLabel.Location = new System.Drawing.Point(85, 102);
            this.endTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(59, 16);
            this.endTimeLabel.TabIndex = 6;
            this.endTimeLabel.Text = "End Time:";
            // 
            // eventDateLabel
            // 
            this.eventDateLabel.AutoSize = true;
            this.eventDateLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.eventDateLabel.Location = new System.Drawing.Point(85, 16);
            this.eventDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eventDateLabel.Name = "eventDateLabel";
            this.eventDateLabel.Size = new System.Drawing.Size(71, 16);
            this.eventDateLabel.TabIndex = 7;
            this.eventDateLabel.Text = "Event for:    ";
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.nameInput.Location = new System.Drawing.Point(152, 42);
            this.nameInput.Margin = new System.Windows.Forms.Padding(2);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(76, 21);
            this.nameInput.TabIndex = 0;
            // 
            // startTimeInput
            // 
            this.startTimeInput.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.startTimeInput.Location = new System.Drawing.Point(152, 71);
            this.startTimeInput.Margin = new System.Windows.Forms.Padding(2);
            this.startTimeInput.Name = "startTimeInput";
            this.startTimeInput.Size = new System.Drawing.Size(76, 21);
            this.startTimeInput.TabIndex = 1;
            // 
            // endTimeInput
            // 
            this.endTimeInput.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.endTimeInput.Location = new System.Drawing.Point(152, 99);
            this.endTimeInput.Margin = new System.Windows.Forms.Padding(2);
            this.endTimeInput.Name = "endTimeInput";
            this.endTimeInput.Size = new System.Drawing.Size(76, 21);
            this.endTimeInput.TabIndex = 2;
            // 
            // eventButton
            // 
            this.newEventButton.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.newEventButton.Location = new System.Drawing.Point(152, 190);
            this.newEventButton.Margin = new System.Windows.Forms.Padding(2);
            this.newEventButton.Name = "newEventButton";
            this.newEventButton.Size = new System.Drawing.Size(75, 23);
            this.newEventButton.TabIndex = 5;
            this.newEventButton.Text = "Add Event";
            this.newEventButton.UseVisualStyleBackColor = true;
            this.newEventButton.Click += new System.EventHandler(this.NewEventButton_Click);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.locationLabel.Location = new System.Drawing.Point(86, 130);
            this.locationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(58, 16);
            this.locationLabel.TabIndex = 8;
            this.locationLabel.Text = "Location:";
            // 
            // locationInput
            // 
            this.locationInput.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.locationInput.Location = new System.Drawing.Point(152, 128);
            this.locationInput.Margin = new System.Windows.Forms.Padding(2);
            this.locationInput.Name = "locationInput";
            this.locationInput.Size = new System.Drawing.Size(76, 21);
            this.locationInput.TabIndex = 3;
            // 
            // colorDialog
            // 
            this.colorDialog.AllowFullOpen = false;
            this.colorDialog.Color = System.Drawing.Color.Red;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.colorLabel.Location = new System.Drawing.Point(105, 158);
            this.colorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(39, 16);
            this.colorLabel.TabIndex = 9;
            this.colorLabel.Text = "Color:";
            // 
            // colorInput
            // 
            this.colorInput.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.colorInput.Location = new System.Drawing.Point(152, 156);
            this.colorInput.Margin = new System.Windows.Forms.Padding(2);
            this.colorInput.Name = "colorInput";
            this.colorInput.ReadOnly = true;
            this.colorInput.Size = new System.Drawing.Size(76, 21);
            this.colorInput.TabIndex = 4;
            this.colorInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colorInput.Click += new System.EventHandler(this.ColorInput_Click);
            // 
            // EventScreen
            // 
            this.AcceptButton = this.newEventButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(305, 233);
            this.Controls.Add(this.colorInput);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.locationInput);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.eventButton);
            this.Controls.Add(this.endTimeInput);
            this.Controls.Add(this.startTimeInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.eventDateLabel);
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.startTimeLabel);
            this.Controls.Add(this.eventNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EventScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EventScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eventNameLabel;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.Label eventDateLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox startTimeInput;
        private System.Windows.Forms.TextBox endTimeInput;
        private System.Windows.Forms.Button eventButton;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TextBox locationInput;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.TextBox colorInput;
    }
}