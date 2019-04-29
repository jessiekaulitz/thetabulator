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
    public partial class To_DoList : UserControl
    {
        public To_DoList()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pnlMainToDoList = new System.Windows.Forms.Panel();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.chklToDoList = new System.Windows.Forms.CheckedListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtToDoListName = new System.Windows.Forms.TextBox();
            this.pnlMainToDoList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainToDoList
            // 
            this.pnlMainToDoList.Controls.Add(this.txtTaskDescription);
            this.pnlMainToDoList.Controls.Add(this.chklToDoList);
            this.pnlMainToDoList.Controls.Add(this.btnAdd);
            this.pnlMainToDoList.Controls.Add(this.txtToDoListName);
            this.pnlMainToDoList.Location = new System.Drawing.Point(0, 0);
            this.pnlMainToDoList.Name = "pnlMainToDoList";
            this.pnlMainToDoList.Size = new System.Drawing.Size(435, 781);
            this.pnlMainToDoList.TabIndex = 0;
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskDescription.Location = new System.Drawing.Point(4, 71);
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(359, 41);
            this.txtTaskDescription.TabIndex = 2;
            this.txtTaskDescription.Text = "Task Description";
            this.txtTaskDescription.Click += new System.EventHandler(this.TxtTaskDescription_Click);
            this.txtTaskDescription.TextChanged += new System.EventHandler(this.TxtTaskDescription_TextChanged);
            // 
            // chklToDoList
            // 
            this.chklToDoList.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chklToDoList.FormattingEnabled = true;
            this.chklToDoList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chklToDoList.Location = new System.Drawing.Point(4, 123);
            this.chklToDoList.Name = "chklToDoList";
            this.chklToDoList.Size = new System.Drawing.Size(428, 655);
            this.chklToDoList.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnAdd.Location = new System.Drawing.Point(369, 66);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 51);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // txtToDoListName
            // 
            this.txtToDoListName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToDoListName.Location = new System.Drawing.Point(4, 4);
            this.txtToDoListName.Name = "txtToDoListName";
            this.txtToDoListName.Size = new System.Drawing.Size(428, 51);
            this.txtToDoListName.TabIndex = 0;
            this.txtToDoListName.Text = "Untitled";
            this.txtToDoListName.TextChanged += new System.EventHandler(this.TxtToDoListName_TextChanged);
            // 
            // To_DoList
            // 
            this.Controls.Add(this.pnlMainToDoList);
            this.Name = "To_DoList";
            this.Size = new System.Drawing.Size(438, 781);
            this.Load += new System.EventHandler(this.To_DoList_Load);
            this.pnlMainToDoList.ResumeLayout(false);
            this.pnlMainToDoList.PerformLayout();
            this.ResumeLayout(false);

        }

        private void To_DoList_Load(object sender, EventArgs e)
        {

        }

        private Panel pnlMainToDoList;

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private TextBox txtToDoListName;

        private void TxtToDoListName_TextChanged(object sender, EventArgs e)
        {

        }
        private Button btnAdd;

        private void CheckedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.chklToDoList.Items.Add(txtTaskDescription.Text);
            txtTaskDescription.Text = "Task Description";
        }

        private void GrbToDoList_Enter(object sender, EventArgs e)
        {

        }

        private CheckedListBox chklToDoList;
        private TextBox txtTaskDescription;

        private void TxtTaskDescription_Click(object sender, EventArgs e)
        {
            txtTaskDescription.SelectAll();
        }

        private void TxtTaskDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
