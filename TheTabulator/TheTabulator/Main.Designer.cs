namespace TheTabulator
{
    partial class Main
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
            this.calendar1 = new TheTabulator.Calendar();
            this.multipleTo_DoLists1 = new TheTabulator.MultipleTo_DoLists();
            this.SuspendLayout();
            // 
            // calendar1
            // 
            this.calendar1.BackColor = System.Drawing.Color.White;
            this.calendar1.Location = new System.Drawing.Point(337, -1);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(943, 650);
            this.calendar1.TabIndex = 3;
            // 
            // multipleTo_DoLists1
            // 
            this.multipleTo_DoLists1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.multipleTo_DoLists1.Location = new System.Drawing.Point(-1, 1);
            this.multipleTo_DoLists1.Margin = new System.Windows.Forms.Padding(2);
            this.multipleTo_DoLists1.Name = "multipleTo_DoLists1";
            this.multipleTo_DoLists1.Size = new System.Drawing.Size(337, 650);
            this.multipleTo_DoLists1.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 648);
            this.Controls.Add(this.multipleTo_DoLists1);
            this.Controls.Add(this.calendar1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion
        private Calendar calendar1;
        private MultipleTo_DoLists multipleTo_DoLists1;
    }
}