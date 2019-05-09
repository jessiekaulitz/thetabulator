using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheTabulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MultipleToDo1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.multipleTo_DoLists1 = new TheTabulator.MultipleTo_DoLists();
            this.SuspendLayout();
            // 
            // multipleTo_DoLists1
            // 
            this.multipleTo_DoLists1.Location = new System.Drawing.Point(0, 0);
            this.multipleTo_DoLists1.Margin = new System.Windows.Forms.Padding(2);
            this.multipleTo_DoLists1.Name = "multipleTo_DoLists1";
            this.multipleTo_DoLists1.Size = new System.Drawing.Size(366, 563);
            this.multipleTo_DoLists1.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(365, 497);
            this.Controls.Add(this.multipleTo_DoLists1);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
    }
}
