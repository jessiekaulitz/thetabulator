namespace TheTabulator
{
    partial class To_DoList
    {
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlMainToDoList = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMoveTaskDown = new System.Windows.Forms.Button();
            this.btnMoveTaskUp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lstTasks = new System.Windows.Forms.ListView();
            this.clmhToDoListName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtToDoListName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMainToDoList.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainToDoList
            // 
            this.pnlMainToDoList.BackColor = System.Drawing.Color.White;
            this.pnlMainToDoList.Controls.Add(this.panel1);
            this.pnlMainToDoList.Controls.Add(this.btnDelete);
            this.pnlMainToDoList.Controls.Add(this.btnMoveTaskDown);
            this.pnlMainToDoList.Controls.Add(this.btnMoveTaskUp);
            this.pnlMainToDoList.Controls.Add(this.button1);
            this.pnlMainToDoList.Controls.Add(this.lstTasks);
            this.pnlMainToDoList.Controls.Add(this.txtTaskDescription);
            this.pnlMainToDoList.Controls.Add(this.btnAdd);
            this.pnlMainToDoList.Location = new System.Drawing.Point(0, 0);
            this.pnlMainToDoList.Name = "pnlMainToDoList";
            this.pnlMainToDoList.Size = new System.Drawing.Size(354, 504);
            this.pnlMainToDoList.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(289, 205);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(61, 47);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMoveTaskDown
            // 
            this.btnMoveTaskDown.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveTaskDown.Location = new System.Drawing.Point(289, 383);
            this.btnMoveTaskDown.Margin = new System.Windows.Forms.Padding(0);
            this.btnMoveTaskDown.Name = "btnMoveTaskDown";
            this.btnMoveTaskDown.Size = new System.Drawing.Size(61, 47);
            this.btnMoveTaskDown.TabIndex = 6;
            this.btnMoveTaskDown.Text = "↓";
            this.btnMoveTaskDown.UseVisualStyleBackColor = true;
            this.btnMoveTaskDown.Click += new System.EventHandler(this.BtnMoveTaskDown_Click);
            // 
            // btnMoveTaskUp
            // 
            this.btnMoveTaskUp.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveTaskUp.Location = new System.Drawing.Point(289, 319);
            this.btnMoveTaskUp.Margin = new System.Windows.Forms.Padding(0);
            this.btnMoveTaskUp.Name = "btnMoveTaskUp";
            this.btnMoveTaskUp.Size = new System.Drawing.Size(61, 47);
            this.btnMoveTaskUp.TabIndex = 5;
            this.btnMoveTaskUp.Text = "↑";
            this.btnMoveTaskUp.UseVisualStyleBackColor = true;
            this.btnMoveTaskUp.Click += new System.EventHandler(this.BtnMoveTaskUp_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(289, 141);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
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
            this.lstTasks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTasks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstTasks.LabelEdit = true;
            this.lstTasks.LabelWrap = false;
            this.lstTasks.Location = new System.Drawing.Point(3, 93);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(280, 406);
            this.lstTasks.SmallImageList = this.imageListSmall;
            this.lstTasks.TabIndex = 3;
            this.lstTasks.UseCompatibleStateImageBehavior = false;
            this.lstTasks.View = System.Windows.Forms.View.Details;
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
            this.txtTaskDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaskDescription.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskDescription.Location = new System.Drawing.Point(3, 58);
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(280, 24);
            this.txtTaskDescription.TabIndex = 2;
            this.txtTaskDescription.Text = "Task Description";
            this.txtTaskDescription.Click += new System.EventHandler(this.TxtTaskDescription_Click);
            this.txtTaskDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTaskDescription_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(289, 46);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(61, 47);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // txtToDoListName
            // 
            this.txtToDoListName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtToDoListName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToDoListName.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToDoListName.Location = new System.Drawing.Point(10, 15);
            this.txtToDoListName.Name = "txtToDoListName";
            this.txtToDoListName.Size = new System.Drawing.Size(280, 36);
            this.txtToDoListName.TabIndex = 0;
            this.txtToDoListName.Text = "Untitled";
            this.txtToDoListName.Click += new System.EventHandler(this.TxtToDoListName_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtToDoListName);
            this.panel1.Location = new System.Drawing.Point(-8, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 52);
            this.panel1.TabIndex = 0;
            // 
            // To_DoList
            // 
            this.Controls.Add(this.pnlMainToDoList);
            this.Name = "To_DoList";
            this.Size = new System.Drawing.Size(354, 503);
            this.pnlMainToDoList.ResumeLayout(false);
            this.pnlMainToDoList.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlMainToDoList;
        private System.Windows.Forms.TextBox txtToDoListName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lstTasks;
        private System.Windows.Forms.ColumnHeader clmhToDoListName;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Button btnMoveTaskDown;
        private System.Windows.Forms.Button btnMoveTaskUp;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.Panel panel1;
    }

}