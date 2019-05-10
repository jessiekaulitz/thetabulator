namespace TheTabulator
{
    partial class Calendar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.calendarTable = new System.Windows.Forms.TableLayoutPanel();
            this.mondayLabel = new System.Windows.Forms.Label();
            this.tuesdayLabel = new System.Windows.Forms.Label();
            this.wednesdayLabel = new System.Windows.Forms.Label();
            this.thursdayLabel = new System.Windows.Forms.Label();
            this.fridayLabel = new System.Windows.Forms.Label();
            this.sundayLabel = new System.Windows.Forms.Label();
            this.saturdayLabel = new System.Windows.Forms.Label();
            this.nextWeekButton = new System.Windows.Forms.Button();
            this.previousWeekButton = new System.Windows.Forms.Button();
            this.am12Label = new System.Windows.Forms.Label();
            this.am1Label = new System.Windows.Forms.Label();
            this.am2Label = new System.Windows.Forms.Label();
            this.am3Label = new System.Windows.Forms.Label();
            this.am4Label = new System.Windows.Forms.Label();
            this.am5Label = new System.Windows.Forms.Label();
            this.pm2Label = new System.Windows.Forms.Label();
            this.pm1Label = new System.Windows.Forms.Label();
            this.pm12Label = new System.Windows.Forms.Label();
            this.am11Label = new System.Windows.Forms.Label();
            this.am10Label = new System.Windows.Forms.Label();
            this.am9Label = new System.Windows.Forms.Label();
            this.am8Label = new System.Windows.Forms.Label();
            this.am7Label = new System.Windows.Forms.Label();
            this.am6Label = new System.Windows.Forms.Label();
            this.pm3Label = new System.Windows.Forms.Label();
            this.pm4Label = new System.Windows.Forms.Label();
            this.pm5Label = new System.Windows.Forms.Label();
            this.pm6Label = new System.Windows.Forms.Label();
            this.pm7Label = new System.Windows.Forms.Label();
            this.pm8Label = new System.Windows.Forms.Label();
            this.pm9Label = new System.Windows.Forms.Label();
            this.pm10Label = new System.Windows.Forms.Label();
            this.pm11Label = new System.Windows.Forms.Label();
            this.am12SecondLabel = new System.Windows.Forms.Label();
            this.dateNumbersPanel = new System.Windows.Forms.Panel();
            this.mondayDateLabel = new System.Windows.Forms.Label();
            this.tuesdayDateLabel = new System.Windows.Forms.Label();
            this.wednesdayDateLabel = new System.Windows.Forms.Label();
            this.thursdayDateLabel = new System.Windows.Forms.Label();
            this.fridayDateLabel = new System.Windows.Forms.Label();
            this.saturdayDateLabel = new System.Windows.Forms.Label();
            this.sundayDateLabel = new System.Windows.Forms.Label();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateNumbersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Tahoma", 26F);
            this.monthLabel.Location = new System.Drawing.Point(235, 28);
            this.monthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(175, 53);
            this.monthLabel.TabIndex = 1;
            this.monthLabel.Text = "January";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Tahoma", 26F);
            this.yearLabel.Location = new System.Drawing.Point(418, 28);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(119, 53);
            this.yearLabel.TabIndex = 10;
            this.yearLabel.Text = "2019";
            // 
            // calendarTable
            // 
            this.calendarTable.AutoScroll = true;
            this.calendarTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.calendarTable.ColumnCount = 7;
            this.calendarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.calendarTable.Font = new System.Drawing.Font("Tahoma", 10F);
            this.calendarTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.calendarTable.Location = new System.Drawing.Point(55, 165);
            this.calendarTable.Margin = new System.Windows.Forms.Padding(4);
            this.calendarTable.Name = "calendarTable";
            this.calendarTable.RowCount = 24;
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.calendarTable.Size = new System.Drawing.Size(1353, 771);
            this.calendarTable.TabIndex = 2;
            // 
            // mondayLabel
            // 
            this.mondayLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.ColumnHeader;
            this.mondayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mondayLabel.AutoSize = true;
            this.mondayLabel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.mondayLabel.Location = new System.Drawing.Point(104, 109);
            this.mondayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mondayLabel.Name = "mondayLabel";
            this.mondayLabel.Size = new System.Drawing.Size(96, 29);
            this.mondayLabel.TabIndex = 34;
            this.mondayLabel.Text = "Monday";
            this.mondayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tuesdayLabel
            // 
            this.tuesdayLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.ColumnHeader;
            this.tuesdayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tuesdayLabel.AutoSize = true;
            this.tuesdayLabel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.tuesdayLabel.Location = new System.Drawing.Point(294, 109);
            this.tuesdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tuesdayLabel.Name = "tuesdayLabel";
            this.tuesdayLabel.Size = new System.Drawing.Size(102, 29);
            this.tuesdayLabel.TabIndex = 34;
            this.tuesdayLabel.Text = "Tuesday";
            this.tuesdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wednesdayLabel
            // 
            this.wednesdayLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.ColumnHeader;
            this.wednesdayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wednesdayLabel.AutoSize = true;
            this.wednesdayLabel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.wednesdayLabel.Location = new System.Drawing.Point(470, 109);
            this.wednesdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wednesdayLabel.Name = "wednesdayLabel";
            this.wednesdayLabel.Size = new System.Drawing.Size(136, 29);
            this.wednesdayLabel.TabIndex = 34;
            this.wednesdayLabel.Text = "Wednesday";
            this.wednesdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thursdayLabel
            // 
            this.thursdayLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.ColumnHeader;
            this.thursdayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thursdayLabel.AutoSize = true;
            this.thursdayLabel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.thursdayLabel.Location = new System.Drawing.Point(675, 109);
            this.thursdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.thursdayLabel.Name = "thursdayLabel";
            this.thursdayLabel.Size = new System.Drawing.Size(111, 29);
            this.thursdayLabel.TabIndex = 34;
            this.thursdayLabel.Text = "Thursday";
            this.thursdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fridayLabel
            // 
            this.fridayLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.ColumnHeader;
            this.fridayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fridayLabel.AutoSize = true;
            this.fridayLabel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.fridayLabel.Location = new System.Drawing.Point(885, 109);
            this.fridayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fridayLabel.Name = "fridayLabel";
            this.fridayLabel.Size = new System.Drawing.Size(78, 29);
            this.fridayLabel.TabIndex = 34;
            this.fridayLabel.Text = "Friday";
            this.fridayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sundayLabel
            // 
            this.sundayLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.ColumnHeader;
            this.sundayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sundayLabel.AutoSize = true;
            this.sundayLabel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.sundayLabel.Location = new System.Drawing.Point(1266, 109);
            this.sundayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sundayLabel.Name = "sundayLabel";
            this.sundayLabel.Size = new System.Drawing.Size(90, 29);
            this.sundayLabel.TabIndex = 34;
            this.sundayLabel.Text = "Sunday";
            this.sundayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saturdayLabel
            // 
            this.saturdayLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.ColumnHeader;
            this.saturdayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saturdayLabel.AutoSize = true;
            this.saturdayLabel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.saturdayLabel.Location = new System.Drawing.Point(1063, 109);
            this.saturdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saturdayLabel.Name = "saturdayLabel";
            this.saturdayLabel.Size = new System.Drawing.Size(107, 29);
            this.saturdayLabel.TabIndex = 34;
            this.saturdayLabel.Text = "Saturday";
            this.saturdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextWeekButton
            // 
            this.nextWeekButton.Font = new System.Drawing.Font("Tahoma", 14F);
            this.nextWeekButton.Location = new System.Drawing.Point(158, 34);
            this.nextWeekButton.Name = "nextWeekButton";
            this.nextWeekButton.Size = new System.Drawing.Size(70, 40);
            this.nextWeekButton.TabIndex = 48;
            this.nextWeekButton.Text = ">";
            this.nextWeekButton.UseVisualStyleBackColor = true;
            this.nextWeekButton.Click += new System.EventHandler(this.NextWeekButton_Click);
            // 
            // previousWeekButton
            // 
            this.previousWeekButton.Font = new System.Drawing.Font("Tahoma", 14F);
            this.previousWeekButton.Location = new System.Drawing.Point(70, 34);
            this.previousWeekButton.Name = "previousWeekButton";
            this.previousWeekButton.Size = new System.Drawing.Size(70, 40);
            this.previousWeekButton.TabIndex = 49;
            this.previousWeekButton.Text = "<";
            this.previousWeekButton.UseVisualStyleBackColor = true;
            this.previousWeekButton.Click += new System.EventHandler(this.PreviousWeekButton_Click);
            // 
            // am12Label
            // 
            this.am12Label.AutoSize = true;
            this.am12Label.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.am12Label.Location = new System.Drawing.Point(3, 157);
            this.am12Label.Name = "am12Label";
            this.am12Label.Size = new System.Drawing.Size(50, 18);
            this.am12Label.TabIndex = 50;
            this.am12Label.Text = "12 AM";
            // 
            // am1Label
            // 
            this.am1Label.AutoSize = true;
            this.am1Label.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.am1Label.Location = new System.Drawing.Point(7, 190);
            this.am1Label.Name = "am1Label";
            this.am1Label.Size = new System.Drawing.Size(42, 18);
            this.am1Label.TabIndex = 51;
            this.am1Label.Text = "1 AM";
            // 
            // am2Label
            // 
            this.am2Label.AutoSize = true;
            this.am2Label.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.am2Label.Location = new System.Drawing.Point(7, 220);
            this.am2Label.Name = "am2Label";
            this.am2Label.Size = new System.Drawing.Size(42, 18);
            this.am2Label.TabIndex = 52;
            this.am2Label.Text = "2 AM";
            // 
            // am3Label
            // 
            this.am3Label.AutoSize = true;
            this.am3Label.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.am3Label.Location = new System.Drawing.Point(7, 250);
            this.am3Label.Name = "am3Label";
            this.am3Label.Size = new System.Drawing.Size(42, 18);
            this.am3Label.TabIndex = 53;
            this.am3Label.Text = "3 AM";
            // 
            // am4Label
            // 
            this.am4Label.AutoSize = true;
            this.am4Label.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.am4Label.Location = new System.Drawing.Point(7, 283);
            this.am4Label.Name = "am4Label";
            this.am4Label.Size = new System.Drawing.Size(42, 18);
            this.am4Label.TabIndex = 54;
            this.am4Label.Text = "4 AM";
            // 
            // am5Label
            // 
            this.am5Label.AutoSize = true;
            this.am5Label.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.am5Label.Location = new System.Drawing.Point(7, 315);
            this.am5Label.Name = "am5Label";
            this.am5Label.Size = new System.Drawing.Size(42, 18);
            this.am5Label.TabIndex = 55;
            this.am5Label.Text = "5 AM";
            // 
            // pm2Label
            // 
            this.pm2Label.AutoSize = true;
            this.pm2Label.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.pm2Label.Location = new System.Drawing.Point(8, 606);
            this.pm2Label.Name = "pm2Label";
            this.pm2Label.Size = new System.Drawing.Size(41, 18);
            this.pm2Label.TabIndex = 56;
            this.pm2Label.Text = "2 PM";
            // 
            // pm1Label
            // 
            this.pm1Label.AutoSize = true;
            this.pm1Label.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.pm1Label.Location = new System.Drawing.Point(8, 573);
            this.pm1Label.Name = "pm1Label";
            this.pm1Label.Size = new System.Drawing.Size(41, 18);
            this.pm1Label.TabIndex = 57;
            this.pm1Label.Text = "1 PM";
            // 
            // pm12Label
            // 
            this.pm12Label.AutoSize = true;
            this.pm12Label.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.pm12Label.Location = new System.Drawing.Point(4, 540);
            this.pm12Label.Name = "pm12Label";
            this.pm12Label.Size = new System.Drawing.Size(49, 18);
            this.pm12Label.TabIndex = 58;
            this.pm12Label.Text = "12 PM";
            // 
            // am11Label
            // 
            this.am11Label.AutoSize = true;
            this.am11Label.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.am11Label.Location = new System.Drawing.Point(3, 508);
            this.am11Label.Name = "am11Label";
            this.am11Label.Size = new System.Drawing.Size(50, 18);
            this.am11Label.TabIndex = 59;
            this.am11Label.Text = "11 AM";
            // 
            // am10Label
            // 
            this.am10Label.AutoSize = true;
            this.am10Label.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.am10Label.Location = new System.Drawing.Point(3, 476);
            this.am10Label.Name = "am10Label";
            this.am10Label.Size = new System.Drawing.Size(50, 18);
            this.am10Label.TabIndex = 60;
            this.am10Label.Text = "10 AM";
            // 
            // am9Label
            // 
            this.am9Label.AutoSize = true;
            this.am9Label.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.am9Label.Location = new System.Drawing.Point(7, 443);
            this.am9Label.Name = "am9Label";
            this.am9Label.Size = new System.Drawing.Size(42, 18);
            this.am9Label.TabIndex = 61;
            this.am9Label.Text = "9 AM";
            // 
            // am8Label
            // 
            this.am8Label.AutoSize = true;
            this.am8Label.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.am8Label.Location = new System.Drawing.Point(7, 411);
            this.am8Label.Name = "am8Label";
            this.am8Label.Size = new System.Drawing.Size(42, 18);
            this.am8Label.TabIndex = 62;
            this.am8Label.Text = "8 AM";
            // 
            // am7Label
            // 
            this.am7Label.AutoSize = true;
            this.am7Label.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.am7Label.Location = new System.Drawing.Point(7, 380);
            this.am7Label.Name = "am7Label";
            this.am7Label.Size = new System.Drawing.Size(42, 18);
            this.am7Label.TabIndex = 63;
            this.am7Label.Text = "7 AM";
            // 
            // am6Label
            // 
            this.am6Label.AutoSize = true;
            this.am6Label.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.am6Label.Location = new System.Drawing.Point(7, 348);
            this.am6Label.Name = "am6Label";
            this.am6Label.Size = new System.Drawing.Size(42, 18);
            this.am6Label.TabIndex = 64;
            this.am6Label.Text = "6 AM";
            // 
            // pm3Label
            // 
            this.pm3Label.AutoSize = true;
            this.pm3Label.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.pm3Label.Location = new System.Drawing.Point(8, 637);
            this.pm3Label.Name = "pm3Label";
            this.pm3Label.Size = new System.Drawing.Size(41, 18);
            this.pm3Label.TabIndex = 70;
            this.pm3Label.Text = "3 PM";
            // 
            // pm4Label
            // 
            this.pm4Label.AutoSize = true;
            this.pm4Label.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.pm4Label.Location = new System.Drawing.Point(8, 668);
            this.pm4Label.Name = "pm4Label";
            this.pm4Label.Size = new System.Drawing.Size(41, 18);
            this.pm4Label.TabIndex = 69;
            this.pm4Label.Text = "4 PM";
            // 
            // pm5Label
            // 
            this.pm5Label.AutoSize = true;
            this.pm5Label.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.pm5Label.Location = new System.Drawing.Point(8, 700);
            this.pm5Label.Name = "pm5Label";
            this.pm5Label.Size = new System.Drawing.Size(41, 18);
            this.pm5Label.TabIndex = 68;
            this.pm5Label.Text = "5 PM";
            // 
            // pm6Label
            // 
            this.pm6Label.AutoSize = true;
            this.pm6Label.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.pm6Label.Location = new System.Drawing.Point(8, 731);
            this.pm6Label.Name = "pm6Label";
            this.pm6Label.Size = new System.Drawing.Size(41, 18);
            this.pm6Label.TabIndex = 67;
            this.pm6Label.Text = "6 PM";
            // 
            // pm7Label
            // 
            this.pm7Label.AutoSize = true;
            this.pm7Label.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.pm7Label.Location = new System.Drawing.Point(8, 763);
            this.pm7Label.Name = "pm7Label";
            this.pm7Label.Size = new System.Drawing.Size(41, 18);
            this.pm7Label.TabIndex = 66;
            this.pm7Label.Text = "7 PM";
            // 
            // pm8Label
            // 
            this.pm8Label.AutoSize = true;
            this.pm8Label.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.pm8Label.Location = new System.Drawing.Point(8, 795);
            this.pm8Label.Name = "pm8Label";
            this.pm8Label.Size = new System.Drawing.Size(41, 18);
            this.pm8Label.TabIndex = 65;
            this.pm8Label.Text = "8 PM";
            // 
            // pm9Label
            // 
            this.pm9Label.AutoSize = true;
            this.pm9Label.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.pm9Label.Location = new System.Drawing.Point(8, 827);
            this.pm9Label.Name = "pm9Label";
            this.pm9Label.Size = new System.Drawing.Size(41, 18);
            this.pm9Label.TabIndex = 74;
            this.pm9Label.Text = "9 PM";
            // 
            // pm10Label
            // 
            this.pm10Label.AutoSize = true;
            this.pm10Label.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.pm10Label.Location = new System.Drawing.Point(4, 860);
            this.pm10Label.Name = "pm10Label";
            this.pm10Label.Size = new System.Drawing.Size(49, 18);
            this.pm10Label.TabIndex = 73;
            this.pm10Label.Text = "10 PM";
            // 
            // pm11Label
            // 
            this.pm11Label.AutoSize = true;
            this.pm11Label.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.pm11Label.Location = new System.Drawing.Point(4, 893);
            this.pm11Label.Name = "pm11Label";
            this.pm11Label.Size = new System.Drawing.Size(49, 18);
            this.pm11Label.TabIndex = 72;
            this.pm11Label.Text = "11 PM";
            // 
            // am12SecondLabel
            // 
            this.am12SecondLabel.AutoSize = true;
            this.am12SecondLabel.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.am12SecondLabel.Location = new System.Drawing.Point(3, 923);
            this.am12SecondLabel.Name = "am12SecondLabel";
            this.am12SecondLabel.Size = new System.Drawing.Size(50, 18);
            this.am12SecondLabel.TabIndex = 71;
            this.am12SecondLabel.Text = "12 AM";
            // 
            // dateNumbersPanel
            // 
            this.dateNumbersPanel.Controls.Add(this.mondayDateLabel);
            this.dateNumbersPanel.Controls.Add(this.tuesdayDateLabel);
            this.dateNumbersPanel.Controls.Add(this.wednesdayDateLabel);
            this.dateNumbersPanel.Controls.Add(this.thursdayDateLabel);
            this.dateNumbersPanel.Controls.Add(this.fridayDateLabel);
            this.dateNumbersPanel.Controls.Add(this.saturdayDateLabel);
            this.dateNumbersPanel.Controls.Add(this.sundayDateLabel);
            this.dateNumbersPanel.Location = new System.Drawing.Point(109, 133);
            this.dateNumbersPanel.Name = "dateNumbersPanel";
            this.dateNumbersPanel.Size = new System.Drawing.Size(1247, 25);
            this.dateNumbersPanel.TabIndex = 75;
            // 
            // mondayDateLabel
            // 
            this.mondayDateLabel.AutoSize = true;
            this.mondayDateLabel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.mondayDateLabel.Location = new System.Drawing.Point(30, 0);
            this.mondayDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mondayDateLabel.Name = "mondayDateLabel";
            this.mondayDateLabel.Size = new System.Drawing.Size(26, 29);
            this.mondayDateLabel.TabIndex = 76;
            this.mondayDateLabel.Text = "1";
            // 
            // tuesdayDateLabel
            // 
            this.tuesdayDateLabel.AutoSize = true;
            this.tuesdayDateLabel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.tuesdayDateLabel.Location = new System.Drawing.Point(223, 0);
            this.tuesdayDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tuesdayDateLabel.Name = "tuesdayDateLabel";
            this.tuesdayDateLabel.Size = new System.Drawing.Size(26, 29);
            this.tuesdayDateLabel.TabIndex = 76;
            this.tuesdayDateLabel.Text = "2";
            // 
            // wednesdayDateLabel
            // 
            this.wednesdayDateLabel.AutoSize = true;
            this.wednesdayDateLabel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.wednesdayDateLabel.Location = new System.Drawing.Point(416, 0);
            this.wednesdayDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wednesdayDateLabel.Name = "wednesdayDateLabel";
            this.wednesdayDateLabel.Size = new System.Drawing.Size(26, 29);
            this.wednesdayDateLabel.TabIndex = 76;
            this.wednesdayDateLabel.Text = "3";
            // 
            // thursdayDateLabel
            // 
            this.thursdayDateLabel.AutoSize = true;
            this.thursdayDateLabel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.thursdayDateLabel.Location = new System.Drawing.Point(608, 0);
            this.thursdayDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.thursdayDateLabel.Name = "thursdayDateLabel";
            this.thursdayDateLabel.Size = new System.Drawing.Size(26, 29);
            this.thursdayDateLabel.TabIndex = 76;
            this.thursdayDateLabel.Text = "4";
            // 
            // fridayDateLabel
            // 
            this.fridayDateLabel.AutoSize = true;
            this.fridayDateLabel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.fridayDateLabel.Location = new System.Drawing.Point(802, 0);
            this.fridayDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fridayDateLabel.Name = "fridayDateLabel";
            this.fridayDateLabel.Size = new System.Drawing.Size(26, 29);
            this.fridayDateLabel.TabIndex = 76;
            this.fridayDateLabel.Text = "5";
            // 
            // saturdayDateLabel
            // 
            this.saturdayDateLabel.AutoSize = true;
            this.saturdayDateLabel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.saturdayDateLabel.Location = new System.Drawing.Point(994, 0);
            this.saturdayDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saturdayDateLabel.Name = "saturdayDateLabel";
            this.saturdayDateLabel.Size = new System.Drawing.Size(26, 29);
            this.saturdayDateLabel.TabIndex = 76;
            this.saturdayDateLabel.Text = "6";
            // 
            // sundayDateLabel
            // 
            this.sundayDateLabel.AutoSize = true;
            this.sundayDateLabel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.sundayDateLabel.Location = new System.Drawing.Point(1189, 0);
            this.sundayDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sundayDateLabel.Name = "sundayDateLabel";
            this.sundayDateLabel.Size = new System.Drawing.Size(26, 29);
            this.sundayDateLabel.TabIndex = 76;
            this.sundayDateLabel.Text = "7";
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(TheTabulator.CalendarEvent);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateNumbersPanel);
            this.Controls.Add(this.pm9Label);
            this.Controls.Add(this.pm10Label);
            this.Controls.Add(this.pm11Label);
            this.Controls.Add(this.am12SecondLabel);
            this.Controls.Add(this.pm3Label);
            this.Controls.Add(this.pm4Label);
            this.Controls.Add(this.pm5Label);
            this.Controls.Add(this.pm6Label);
            this.Controls.Add(this.pm7Label);
            this.Controls.Add(this.pm8Label);
            this.Controls.Add(this.am6Label);
            this.Controls.Add(this.am7Label);
            this.Controls.Add(this.am8Label);
            this.Controls.Add(this.am9Label);
            this.Controls.Add(this.am10Label);
            this.Controls.Add(this.am11Label);
            this.Controls.Add(this.pm12Label);
            this.Controls.Add(this.pm1Label);
            this.Controls.Add(this.pm2Label);
            this.Controls.Add(this.am5Label);
            this.Controls.Add(this.am4Label);
            this.Controls.Add(this.am3Label);
            this.Controls.Add(this.am2Label);
            this.Controls.Add(this.am1Label);
            this.Controls.Add(this.am12Label);
            this.Controls.Add(this.previousWeekButton);
            this.Controls.Add(this.nextWeekButton);
            this.Controls.Add(this.saturdayLabel);
            this.Controls.Add(this.sundayLabel);
            this.Controls.Add(this.fridayLabel);
            this.Controls.Add(this.thursdayLabel);
            this.Controls.Add(this.wednesdayLabel);
            this.Controls.Add(this.tuesdayLabel);
            this.Controls.Add(this.mondayLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.calendarTable);
            this.Controls.Add(this.monthLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Calendar";
            this.Size = new System.Drawing.Size(1425, 956);
            this.Load += new System.EventHandler(this.Calendar_Load);
            this.dateNumbersPanel.ResumeLayout(false);
            this.dateNumbersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TableLayoutPanel calendarTable;
        private System.Windows.Forms.Label mondayLabel;
        private System.Windows.Forms.Label tuesdayLabel;
        private System.Windows.Forms.Label wednesdayLabel;
        private System.Windows.Forms.Label thursdayLabel;
        private System.Windows.Forms.Label fridayLabel;
        private System.Windows.Forms.Label sundayLabel;
        private System.Windows.Forms.Label saturdayLabel;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.Button nextWeekButton;
        private System.Windows.Forms.Button previousWeekButton;
        private System.Windows.Forms.Label am12Label;
        private System.Windows.Forms.Label am1Label;
        private System.Windows.Forms.Label am2Label;
        private System.Windows.Forms.Label am3Label;
        private System.Windows.Forms.Label am4Label;
        private System.Windows.Forms.Label am5Label;
        private System.Windows.Forms.Label pm2Label;
        private System.Windows.Forms.Label pm1Label;
        private System.Windows.Forms.Label pm12Label;
        private System.Windows.Forms.Label am11Label;
        private System.Windows.Forms.Label am10Label;
        private System.Windows.Forms.Label am9Label;
        private System.Windows.Forms.Label am8Label;
        private System.Windows.Forms.Label am7Label;
        private System.Windows.Forms.Label am6Label;
        private System.Windows.Forms.Label pm3Label;
        private System.Windows.Forms.Label pm4Label;
        private System.Windows.Forms.Label pm5Label;
        private System.Windows.Forms.Label pm6Label;
        private System.Windows.Forms.Label pm7Label;
        private System.Windows.Forms.Label pm8Label;
        private System.Windows.Forms.Label pm10Label;
        private System.Windows.Forms.Label pm11Label;
        private System.Windows.Forms.Label am12SecondLabel;
        private System.Windows.Forms.Label pm9Label;
        private System.Windows.Forms.Panel dateNumbersPanel;
        private System.Windows.Forms.Label sundayDateLabel;
        private System.Windows.Forms.Label saturdayDateLabel;
        private System.Windows.Forms.Label fridayDateLabel;
        private System.Windows.Forms.Label thursdayDateLabel;
        private System.Windows.Forms.Label wednesdayDateLabel;
        private System.Windows.Forms.Label tuesdayDateLabel;
        private System.Windows.Forms.Label mondayDateLabel;
    }
}
