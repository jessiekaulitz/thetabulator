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
            this.components = new System.ComponentModel.Container();
            this.pnlMainToDoList = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lstTasks = new System.Windows.Forms.ListView();
            this.clmhToDoListName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtToDoListName = new System.Windows.Forms.TextBox();
            this.pnlMainToDoList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainToDoList
            // 
            this.pnlMainToDoList.Controls.Add(this.button1);
            this.pnlMainToDoList.Controls.Add(this.lstTasks);
            this.pnlMainToDoList.Controls.Add(this.txtTaskDescription);
            this.pnlMainToDoList.Controls.Add(this.btnAdd);
            this.pnlMainToDoList.Controls.Add(this.txtToDoListName);
            this.pnlMainToDoList.Location = new System.Drawing.Point(0, 0);
            this.pnlMainToDoList.Name = "pnlMainToDoList";
            this.pnlMainToDoList.Size = new System.Drawing.Size(354, 649);
            this.pnlMainToDoList.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button1.Location = new System.Drawing.Point(289, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Step";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lstTasks
            // 
            this.lstTasks.AllowColumnReorder = true;
            this.lstTasks.CheckBoxes = true;
            this.lstTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmhToDoListName});
            this.lstTasks.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lstTasks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstTasks.LabelEdit = true;
            this.lstTasks.LabelWrap = false;
            this.lstTasks.Location = new System.Drawing.Point(3, 82);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(280, 558);
            this.lstTasks.SmallImageList = this.imageListSmall;
            this.lstTasks.TabIndex = 3;
            this.lstTasks.UseCompatibleStateImageBehavior = false;
            this.lstTasks.View = System.Windows.Forms.View.Details;
            this.lstTasks.SelectedIndexChanged += new System.EventHandler(this.LstTasks_SelectedIndexChanged);
            // 
            // clmhToDoListName
            // 
            this.clmhToDoListName.Text = "";
            this.clmhToDoListName.Width = 428;
            // 
            // imageListSmall
            // 
            this.imageListSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListSmall.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskDescription.Location = new System.Drawing.Point(3, 46);
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(231, 30);
            this.txtTaskDescription.TabIndex = 2;
            this.txtTaskDescription.Text = "Task Description";
            this.txtTaskDescription.Click += new System.EventHandler(this.TxtTaskDescription_Click);
            this.txtTaskDescription.TextChanged += new System.EventHandler(this.TxtTaskDescription_TextChanged);
            this.txtTaskDescription.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtTaskDescription_KeyUp);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnAdd.Location = new System.Drawing.Point(240, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(44, 30);
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
            this.txtToDoListName.Size = new System.Drawing.Size(280, 36);
            this.txtToDoListName.TabIndex = 0;
            this.txtToDoListName.Text = "Untitled";
            this.txtToDoListName.TextChanged += new System.EventHandler(this.TxtToDoListName_TextChanged);
            // 
            // To_DoList
            // 
            this.Controls.Add(this.pnlMainToDoList);
            this.Name = "To_DoList";
            this.Size = new System.Drawing.Size(354, 644);
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
            this.lstTasks.Items.Add(txtTaskDescription.Text);
            txtTaskDescription.Text = "Task Description";
        }

        private void GrbToDoList_Enter(object sender, EventArgs e)
        {

        }
        private TextBox txtTaskDescription;

        private void TxtTaskDescription_Click(object sender, EventArgs e)
        {
            txtTaskDescription.SelectAll();
        }

        private void TxtTaskDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTaskDescription_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }

        private ListView lstTasks;
        private ColumnHeader clmhToDoListName;

        private void LstTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private Button button1;

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem task in lstTasks.Items)
            {
                if (task.Selected)
                {
                    lstTasks.Items.Insert(task.Index + 1, "New Step");
                    lstTasks.Items[task.Index + 1].IndentCount = task.IndentCount + 1;
                }
            }
        }

        private ImageList imageListSmall;
        private IContainer components;

        public string Title()
        {
            return txtToDoListName.Text;
        }
    }
}
