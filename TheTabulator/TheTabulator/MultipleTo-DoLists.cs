using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheTabulator
{
    public partial class MultipleTo_DoLists : UserControl
    {
        List<To_DoList> ListOfToDo = new List<To_DoList>();
        
        public MultipleTo_DoLists()
        {
            InitializeComponent();
        }

        private void To_DoList1_Load(object sender, EventArgs e)
        {
            ListOfToDo.Add(to_DoList1);
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Checking if the selected tab is the last one which is the + option
            if (tabControl1.TabCount - 1 == tabControl1.SelectedIndex)
            {
                // Creating a new tab
                tabControl1.TabPages.Insert(tabControl1.TabCount - 1, "To-Do List " + (tabControl1.SelectedIndex + 1));
                tabControl1.SelectedIndex = tabControl1.TabCount - 2;

                // Setting font, location ect of new tab
                tabControl1.SelectedTab.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                tabControl1.SelectedTab.Location = new System.Drawing.Point(4, 29);
                tabControl1.SelectedTab.Padding = new System.Windows.Forms.Padding(3);
                tabControl1.SelectedTab.Size = new System.Drawing.Size(540, 696);
                tabControl1.SelectedTab.UseVisualStyleBackColor = true;

                // Creating a new To_DoList component
                To_DoList to_DoList = new To_DoList();

                // Setting location of new To_DoList
                to_DoList.Location = new System.Drawing.Point(0, 0);
                to_DoList.TabIndex = tabControl1.SelectedIndex;

                // Adding To_DoList component to the new tab
                tabControl1.SelectedTab.Controls.Add(to_DoList);
                ListOfToDo.Add(to_DoList);
            }
        }
    }
}
