﻿namespace TheTabulator
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
            this.eventNameLabel.Location = new System.Drawing.Point(96, 55);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(89, 17);
            this.eventNameLabel.TabIndex = 4;
            this.eventNameLabel.Text = "Event Name:";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(108, 90);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(77, 17);
            this.startTimeLabel.TabIndex = 5;
            this.startTimeLabel.Text = "Start Time:";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(113, 125);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(72, 17);
            this.endTimeLabel.TabIndex = 6;
            this.endTimeLabel.Text = "End Time:";
            // 
            // eventDateLabel
            // 
            this.eventDateLabel.AutoSize = true;
            this.eventDateLabel.Location = new System.Drawing.Point(64, 20);
            this.eventDateLabel.Name = "eventDateLabel";
            this.eventDateLabel.Size = new System.Drawing.Size(73, 17);
            this.eventDateLabel.TabIndex = 7;
            this.eventDateLabel.Text = "Event for: ";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(203, 52);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 22);
            this.nameInput.TabIndex = 0;
            // 
            // startTimeInput
            // 
            this.startTimeInput.Location = new System.Drawing.Point(203, 87);
            this.startTimeInput.Name = "startTimeInput";
            this.startTimeInput.Size = new System.Drawing.Size(100, 22);
            this.startTimeInput.TabIndex = 1;
            // 
            // endTimeInput
            // 
            this.endTimeInput.Location = new System.Drawing.Point(203, 122);
            this.endTimeInput.Name = "endTimeInput";
            this.endTimeInput.Size = new System.Drawing.Size(100, 22);
            this.endTimeInput.TabIndex = 2;
            // 
            // eventButton
            // 
            this.eventButton.Location = new System.Drawing.Point(203, 234);
            this.eventButton.Name = "eventButton";
            this.eventButton.Size = new System.Drawing.Size(100, 23);
            this.eventButton.TabIndex = 5;
            this.eventButton.Text = "Button";
            this.eventButton.UseVisualStyleBackColor = true;
            this.eventButton.Click += new System.EventHandler(this.NewEventButton_Click);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(119, 160);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(66, 17);
            this.locationLabel.TabIndex = 8;
            this.locationLabel.Text = "Location:";
            // 
            // locationInput
            // 
            this.locationInput.Location = new System.Drawing.Point(203, 157);
            this.locationInput.Name = "locationInput";
            this.locationInput.Size = new System.Drawing.Size(100, 22);
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
            this.colorLabel.Location = new System.Drawing.Point(140, 195);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(45, 17);
            this.colorLabel.TabIndex = 9;
            this.colorLabel.Text = "Color:";
            // 
            // colorInput
            // 
            this.colorInput.Location = new System.Drawing.Point(203, 192);
            this.colorInput.Name = "colorInput";
            this.colorInput.ReadOnly = true;
            this.colorInput.Size = new System.Drawing.Size(100, 22);
            this.colorInput.TabIndex = 4;
            this.colorInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colorInput.Click += new System.EventHandler(this.ColorInput_Click);
            // 
            // EventScreen
            // 
            this.AcceptButton = this.eventButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 287);
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