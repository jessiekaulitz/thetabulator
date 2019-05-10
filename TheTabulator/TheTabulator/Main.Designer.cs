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
            this.multipleTo_DoLists1 = new TheTabulator.MultipleTo_DoLists();
            this.calendar1 = new TheTabulator.Calendar();
            this.SuspendLayout();
            // 
            // multipleTo_DoLists1
            // 
            this.multipleTo_DoLists1.Location = new System.Drawing.Point(12, 169);
            this.multipleTo_DoLists1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.multipleTo_DoLists1.Name = "multipleTo_DoLists1";
            this.multipleTo_DoLists1.Size = new System.Drawing.Size(488, 828);
            this.multipleTo_DoLists1.TabIndex = 0;
            // 
            // calendar1
            // 
            this.calendar1.Location = new System.Drawing.Point(508, 41);
            this.calendar1.Margin = new System.Windows.Forms.Padding(4);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(1425, 956);
            this.calendar1.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 994);
            this.Controls.Add(this.calendar1);
            this.Controls.Add(this.multipleTo_DoLists1);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private MultipleTo_DoLists multipleTo_DoLists1;
        private Calendar calendar1;
    }
}