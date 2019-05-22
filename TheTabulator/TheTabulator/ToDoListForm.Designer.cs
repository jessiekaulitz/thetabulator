namespace TheTabulator
{
    partial class ToDoListForm
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
            this.SuspendLayout();
            // 
            // multipleTo_DoLists1
            // 
            this.multipleTo_DoLists1.Location = new System.Drawing.Point(-4, 0);
            this.multipleTo_DoLists1.Margin = new System.Windows.Forms.Padding(2);
            this.multipleTo_DoLists1.Name = "multipleTo_DoLists1";
            this.multipleTo_DoLists1.Size = new System.Drawing.Size(359, 526);
            this.multipleTo_DoLists1.TabIndex = 0;
            // 
            // ToDoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 527);
            this.Controls.Add(this.multipleTo_DoLists1);
            this.Name = "ToDoListForm";
            this.Text = "ToDoListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MultipleTo_DoLists multipleTo_DoLists1;
    }
}