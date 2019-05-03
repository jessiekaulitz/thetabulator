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
            this.calendarFeatureLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.mondayDateLabel = new System.Windows.Forms.Label();
            this.tuesdayDateLabel = new System.Windows.Forms.Label();
            this.wednesdayDateLabel = new System.Windows.Forms.Label();
            this.thursdayDateLabel = new System.Windows.Forms.Label();
            this.fridayDateLabel = new System.Windows.Forms.Label();
            this.saturdayDateLabel = new System.Windows.Forms.Label();
            this.sundayDateLabel = new System.Windows.Forms.Label();
            this.calendarTable = new System.Windows.Forms.TableLayoutPanel();
            this.mondayLabel = new System.Windows.Forms.Label();
            this.tuesdayLabel = new System.Windows.Forms.Label();
            this.wednesdayLabel = new System.Windows.Forms.Label();
            this.thursdayLabel = new System.Windows.Forms.Label();
            this.fridayLabel = new System.Windows.Forms.Label();
            this.sundayLabel = new System.Windows.Forms.Label();
            this.saturdayLabel = new System.Windows.Forms.Label();
            this.am12Label = new System.Windows.Forms.Label();
            this.am1Label = new System.Windows.Forms.Label();
            this.am2Label = new System.Windows.Forms.Label();
            this.am3Label = new System.Windows.Forms.Label();
            this.am4Label = new System.Windows.Forms.Label();
            this.am5Label = new System.Windows.Forms.Label();
            this.am6Label = new System.Windows.Forms.Label();
            this.am7Label = new System.Windows.Forms.Label();
            this.am8Label = new System.Windows.Forms.Label();
            this.am9Label = new System.Windows.Forms.Label();
            this.am10Label = new System.Windows.Forms.Label();
            this.am11Label = new System.Windows.Forms.Label();
            this.pm12Label = new System.Windows.Forms.Label();
            this.pm1Label = new System.Windows.Forms.Label();
            this.pm2Label = new System.Windows.Forms.Label();
            this.pm3Label = new System.Windows.Forms.Label();
            this.pm4Label = new System.Windows.Forms.Label();
            this.pm5Label = new System.Windows.Forms.Label();
            this.pm6Label = new System.Windows.Forms.Label();
            this.pm7Label = new System.Windows.Forms.Label();
            this.pm8Label = new System.Windows.Forms.Label();
            this.pm9Label = new System.Windows.Forms.Label();
            this.pm10Label = new System.Windows.Forms.Label();
            this.pm11Label = new System.Windows.Forms.Label();
            this.nextWeekButton = new System.Windows.Forms.Button();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.previousWeekButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // calendarFeatureLabel
            // 
            this.calendarFeatureLabel.AutoSize = true;
            this.calendarFeatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarFeatureLabel.Location = new System.Drawing.Point(892, 21);
            this.calendarFeatureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.calendarFeatureLabel.Name = "calendarFeatureLabel";
            this.calendarFeatureLabel.Size = new System.Drawing.Size(272, 69);
            this.calendarFeatureLabel.TabIndex = 0;
            this.calendarFeatureLabel.Text = "Calendar";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.Location = new System.Drawing.Point(369, 50);
            this.monthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(111, 31);
            this.monthLabel.TabIndex = 1;
            this.monthLabel.Text = "January";
            this.monthLabel.Click += new System.EventHandler(this.MonthLabel_Click);
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(481, 50);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(74, 31);
            this.yearLabel.TabIndex = 10;
            this.yearLabel.Text = "2019";
            // 
            // mondayDateLabel
            // 
            this.mondayDateLabel.AutoSize = true;
            this.mondayDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mondayDateLabel.Location = new System.Drawing.Point(124, 128);
            this.mondayDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mondayDateLabel.Name = "mondayDateLabel";
            this.mondayDateLabel.Size = new System.Drawing.Size(44, 29);
            this.mondayDateLabel.TabIndex = 11;
            this.mondayDateLabel.Text = "1st";
            // 
            // tuesdayDateLabel
            // 
            this.tuesdayDateLabel.AutoSize = true;
            this.tuesdayDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuesdayDateLabel.Location = new System.Drawing.Point(318, 132);
            this.tuesdayDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tuesdayDateLabel.Name = "tuesdayDateLabel";
            this.tuesdayDateLabel.Size = new System.Drawing.Size(53, 29);
            this.tuesdayDateLabel.TabIndex = 12;
            this.tuesdayDateLabel.Text = "2nd";
            // 
            // wednesdayDateLabel
            // 
            this.wednesdayDateLabel.AutoSize = true;
            this.wednesdayDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wednesdayDateLabel.Location = new System.Drawing.Point(507, 126);
            this.wednesdayDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wednesdayDateLabel.Name = "wednesdayDateLabel";
            this.wednesdayDateLabel.Size = new System.Drawing.Size(48, 29);
            this.wednesdayDateLabel.TabIndex = 13;
            this.wednesdayDateLabel.Text = "3rd";
            // 
            // thursdayDateLabel
            // 
            this.thursdayDateLabel.AutoSize = true;
            this.thursdayDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thursdayDateLabel.Location = new System.Drawing.Point(727, 128);
            this.thursdayDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.thursdayDateLabel.Name = "thursdayDateLabel";
            this.thursdayDateLabel.Size = new System.Drawing.Size(45, 29);
            this.thursdayDateLabel.TabIndex = 14;
            this.thursdayDateLabel.Text = "4th";
            // 
            // fridayDateLabel
            // 
            this.fridayDateLabel.AutoSize = true;
            this.fridayDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fridayDateLabel.Location = new System.Drawing.Point(921, 132);
            this.fridayDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fridayDateLabel.Name = "fridayDateLabel";
            this.fridayDateLabel.Size = new System.Drawing.Size(45, 29);
            this.fridayDateLabel.TabIndex = 15;
            this.fridayDateLabel.Text = "5th";
            // 
            // saturdayDateLabel
            // 
            this.saturdayDateLabel.AutoSize = true;
            this.saturdayDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saturdayDateLabel.Location = new System.Drawing.Point(1106, 126);
            this.saturdayDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saturdayDateLabel.Name = "saturdayDateLabel";
            this.saturdayDateLabel.Size = new System.Drawing.Size(45, 29);
            this.saturdayDateLabel.TabIndex = 16;
            this.saturdayDateLabel.Text = "6th";
            // 
            // sundayDateLabel
            // 
            this.sundayDateLabel.AutoSize = true;
            this.sundayDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sundayDateLabel.Location = new System.Drawing.Point(1300, 128);
            this.sundayDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sundayDateLabel.Name = "sundayDateLabel";
            this.sundayDateLabel.Size = new System.Drawing.Size(45, 29);
            this.sundayDateLabel.TabIndex = 17;
            this.sundayDateLabel.Text = "7th";
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
            this.calendarTable.Size = new System.Drawing.Size(1353, 785);
            this.calendarTable.TabIndex = 2;
            // 
            // mondayLabel
            // 
            this.mondayLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.ColumnHeader;
            this.mondayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mondayLabel.AutoSize = true;
            this.mondayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mondayLabel.Location = new System.Drawing.Point(57, 81);
            this.mondayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mondayLabel.Name = "mondayLabel";
            this.mondayLabel.Size = new System.Drawing.Size(104, 29);
            this.mondayLabel.TabIndex = 34;
            this.mondayLabel.Text = "Monday";
            this.mondayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tuesdayLabel
            // 
            this.tuesdayLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.ColumnHeader;
            this.tuesdayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tuesdayLabel.AutoSize = true;
            this.tuesdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuesdayLabel.Location = new System.Drawing.Point(258, 81);
            this.tuesdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tuesdayLabel.Name = "tuesdayLabel";
            this.tuesdayLabel.Size = new System.Drawing.Size(113, 29);
            this.tuesdayLabel.TabIndex = 34;
            this.tuesdayLabel.Text = "Tuesday";
            this.tuesdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wednesdayLabel
            // 
            this.wednesdayLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.ColumnHeader;
            this.wednesdayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wednesdayLabel.AutoSize = true;
            this.wednesdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wednesdayLabel.Location = new System.Drawing.Point(468, 81);
            this.wednesdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wednesdayLabel.Name = "wednesdayLabel";
            this.wednesdayLabel.Size = new System.Drawing.Size(149, 29);
            this.wednesdayLabel.TabIndex = 34;
            this.wednesdayLabel.Text = "Wednesday";
            this.wednesdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thursdayLabel
            // 
            this.thursdayLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.ColumnHeader;
            this.thursdayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thursdayLabel.AutoSize = true;
            this.thursdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thursdayLabel.Location = new System.Drawing.Point(697, 72);
            this.thursdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.thursdayLabel.Name = "thursdayLabel";
            this.thursdayLabel.Size = new System.Drawing.Size(121, 29);
            this.thursdayLabel.TabIndex = 34;
            this.thursdayLabel.Text = "Thursday";
            this.thursdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fridayLabel
            // 
            this.fridayLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.ColumnHeader;
            this.fridayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fridayLabel.AutoSize = true;
            this.fridayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fridayLabel.Location = new System.Drawing.Point(860, 72);
            this.fridayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fridayLabel.Name = "fridayLabel";
            this.fridayLabel.Size = new System.Drawing.Size(86, 29);
            this.fridayLabel.TabIndex = 34;
            this.fridayLabel.Text = "Friday";
            this.fridayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sundayLabel
            // 
            this.sundayLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.ColumnHeader;
            this.sundayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sundayLabel.AutoSize = true;
            this.sundayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sundayLabel.Location = new System.Drawing.Point(1235, 61);
            this.sundayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sundayLabel.Name = "sundayLabel";
            this.sundayLabel.Size = new System.Drawing.Size(99, 29);
            this.sundayLabel.TabIndex = 34;
            this.sundayLabel.Text = "Sunday";
            this.sundayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saturdayLabel
            // 
            this.saturdayLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.ColumnHeader;
            this.saturdayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saturdayLabel.AutoSize = true;
            this.saturdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saturdayLabel.Location = new System.Drawing.Point(1034, 81);
            this.saturdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saturdayLabel.Name = "saturdayLabel";
            this.saturdayLabel.Size = new System.Drawing.Size(115, 29);
            this.saturdayLabel.TabIndex = 34;
            this.saturdayLabel.Text = "Saturday";
            this.saturdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // am12Label
            // 
            this.am12Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.am12Label.AutoSize = true;
            this.am12Label.Location = new System.Drawing.Point(-212, 165);
            this.am12Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.am12Label.Name = "am12Label";
            this.am12Label.Size = new System.Drawing.Size(43, 17);
            this.am12Label.TabIndex = 34;
            this.am12Label.Text = "12am";
            this.am12Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // am1Label
            // 
            this.am1Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.am1Label.AutoSize = true;
            this.am1Label.Location = new System.Drawing.Point(-204, 197);
            this.am1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.am1Label.Name = "am1Label";
            this.am1Label.Size = new System.Drawing.Size(35, 17);
            this.am1Label.TabIndex = 34;
            this.am1Label.Text = "1am";
            this.am1Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // am2Label
            // 
            this.am2Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.am2Label.AutoSize = true;
            this.am2Label.Location = new System.Drawing.Point(-204, 229);
            this.am2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.am2Label.Name = "am2Label";
            this.am2Label.Size = new System.Drawing.Size(35, 17);
            this.am2Label.TabIndex = 34;
            this.am2Label.Text = "2am";
            this.am2Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // am3Label
            // 
            this.am3Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.am3Label.AutoSize = true;
            this.am3Label.Location = new System.Drawing.Point(-204, 261);
            this.am3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.am3Label.Name = "am3Label";
            this.am3Label.Size = new System.Drawing.Size(35, 17);
            this.am3Label.TabIndex = 34;
            this.am3Label.Text = "3am";
            this.am3Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // am4Label
            // 
            this.am4Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.am4Label.AutoSize = true;
            this.am4Label.Location = new System.Drawing.Point(-204, 293);
            this.am4Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.am4Label.Name = "am4Label";
            this.am4Label.Size = new System.Drawing.Size(35, 17);
            this.am4Label.TabIndex = 35;
            this.am4Label.Text = "4am";
            this.am4Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // am5Label
            // 
            this.am5Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.am5Label.AutoSize = true;
            this.am5Label.Location = new System.Drawing.Point(-204, 325);
            this.am5Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.am5Label.Name = "am5Label";
            this.am5Label.Size = new System.Drawing.Size(35, 17);
            this.am5Label.TabIndex = 36;
            this.am5Label.Text = "5am";
            this.am5Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // am6Label
            // 
            this.am6Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.am6Label.AutoSize = true;
            this.am6Label.Location = new System.Drawing.Point(-204, 357);
            this.am6Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.am6Label.Name = "am6Label";
            this.am6Label.Size = new System.Drawing.Size(35, 17);
            this.am6Label.TabIndex = 37;
            this.am6Label.Text = "6am";
            this.am6Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // am7Label
            // 
            this.am7Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.am7Label.AutoSize = true;
            this.am7Label.Location = new System.Drawing.Point(-204, 389);
            this.am7Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.am7Label.Name = "am7Label";
            this.am7Label.Size = new System.Drawing.Size(35, 17);
            this.am7Label.TabIndex = 38;
            this.am7Label.Text = "7am";
            this.am7Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // am8Label
            // 
            this.am8Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.am8Label.AutoSize = true;
            this.am8Label.Location = new System.Drawing.Point(-204, 421);
            this.am8Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.am8Label.Name = "am8Label";
            this.am8Label.Size = new System.Drawing.Size(35, 17);
            this.am8Label.TabIndex = 39;
            this.am8Label.Text = "8am";
            this.am8Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // am9Label
            // 
            this.am9Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.am9Label.AutoSize = true;
            this.am9Label.Location = new System.Drawing.Point(-204, 453);
            this.am9Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.am9Label.Name = "am9Label";
            this.am9Label.Size = new System.Drawing.Size(35, 17);
            this.am9Label.TabIndex = 40;
            this.am9Label.Text = "9am";
            this.am9Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // am10Label
            // 
            this.am10Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.am10Label.AutoSize = true;
            this.am10Label.Location = new System.Drawing.Point(-212, 485);
            this.am10Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.am10Label.Name = "am10Label";
            this.am10Label.Size = new System.Drawing.Size(43, 17);
            this.am10Label.TabIndex = 41;
            this.am10Label.Text = "10am";
            this.am10Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // am11Label
            // 
            this.am11Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.am11Label.AutoSize = true;
            this.am11Label.Location = new System.Drawing.Point(-212, 517);
            this.am11Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.am11Label.Name = "am11Label";
            this.am11Label.Size = new System.Drawing.Size(43, 17);
            this.am11Label.TabIndex = 42;
            this.am11Label.Text = "11am";
            this.am11Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pm12Label
            // 
            this.pm12Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pm12Label.AutoSize = true;
            this.pm12Label.Location = new System.Drawing.Point(-212, 549);
            this.pm12Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pm12Label.Name = "pm12Label";
            this.pm12Label.Size = new System.Drawing.Size(43, 17);
            this.pm12Label.TabIndex = 43;
            this.pm12Label.Text = "12pm";
            this.pm12Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pm1Label
            // 
            this.pm1Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pm1Label.AutoSize = true;
            this.pm1Label.Location = new System.Drawing.Point(-204, 581);
            this.pm1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pm1Label.Name = "pm1Label";
            this.pm1Label.Size = new System.Drawing.Size(35, 17);
            this.pm1Label.TabIndex = 44;
            this.pm1Label.Text = "1pm";
            this.pm1Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pm2Label
            // 
            this.pm2Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pm2Label.AutoSize = true;
            this.pm2Label.Location = new System.Drawing.Point(-204, 613);
            this.pm2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pm2Label.Name = "pm2Label";
            this.pm2Label.Size = new System.Drawing.Size(35, 17);
            this.pm2Label.TabIndex = 45;
            this.pm2Label.Text = "2pm";
            this.pm2Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pm3Label
            // 
            this.pm3Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pm3Label.AutoSize = true;
            this.pm3Label.Location = new System.Drawing.Point(-204, 645);
            this.pm3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pm3Label.Name = "pm3Label";
            this.pm3Label.Size = new System.Drawing.Size(35, 17);
            this.pm3Label.TabIndex = 46;
            this.pm3Label.Text = "3pm";
            this.pm3Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pm4Label
            // 
            this.pm4Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pm4Label.AutoSize = true;
            this.pm4Label.Location = new System.Drawing.Point(-204, 677);
            this.pm4Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pm4Label.Name = "pm4Label";
            this.pm4Label.Size = new System.Drawing.Size(35, 17);
            this.pm4Label.TabIndex = 47;
            this.pm4Label.Text = "4pm";
            this.pm4Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pm5Label
            // 
            this.pm5Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pm5Label.AutoSize = true;
            this.pm5Label.Location = new System.Drawing.Point(-204, 709);
            this.pm5Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pm5Label.Name = "pm5Label";
            this.pm5Label.Size = new System.Drawing.Size(35, 17);
            this.pm5Label.TabIndex = 34;
            this.pm5Label.Text = "5pm";
            this.pm5Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pm6Label
            // 
            this.pm6Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pm6Label.AutoSize = true;
            this.pm6Label.Location = new System.Drawing.Point(-204, 741);
            this.pm6Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pm6Label.Name = "pm6Label";
            this.pm6Label.Size = new System.Drawing.Size(35, 17);
            this.pm6Label.TabIndex = 35;
            this.pm6Label.Text = "6pm";
            this.pm6Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pm7Label
            // 
            this.pm7Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pm7Label.AutoSize = true;
            this.pm7Label.Location = new System.Drawing.Point(-204, 773);
            this.pm7Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pm7Label.Name = "pm7Label";
            this.pm7Label.Size = new System.Drawing.Size(35, 17);
            this.pm7Label.TabIndex = 36;
            this.pm7Label.Text = "7pm";
            this.pm7Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pm8Label
            // 
            this.pm8Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pm8Label.AutoSize = true;
            this.pm8Label.Location = new System.Drawing.Point(-204, 805);
            this.pm8Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pm8Label.Name = "pm8Label";
            this.pm8Label.Size = new System.Drawing.Size(35, 17);
            this.pm8Label.TabIndex = 37;
            this.pm8Label.Text = "8pm";
            this.pm8Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pm9Label
            // 
            this.pm9Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pm9Label.AutoSize = true;
            this.pm9Label.Location = new System.Drawing.Point(-204, 837);
            this.pm9Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pm9Label.Name = "pm9Label";
            this.pm9Label.Size = new System.Drawing.Size(35, 17);
            this.pm9Label.TabIndex = 34;
            this.pm9Label.Text = "9pm";
            this.pm9Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pm10Label
            // 
            this.pm10Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pm10Label.AutoSize = true;
            this.pm10Label.Location = new System.Drawing.Point(-212, 869);
            this.pm10Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pm10Label.Name = "pm10Label";
            this.pm10Label.Size = new System.Drawing.Size(43, 17);
            this.pm10Label.TabIndex = 35;
            this.pm10Label.Text = "10pm";
            this.pm10Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pm11Label
            // 
            this.pm11Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pm11Label.AutoSize = true;
            this.pm11Label.Location = new System.Drawing.Point(-212, 901);
            this.pm11Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pm11Label.Name = "pm11Label";
            this.pm11Label.Size = new System.Drawing.Size(43, 17);
            this.pm11Label.TabIndex = 36;
            this.pm11Label.Text = "11pm";
            this.pm11Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nextWeekButton
            // 
            this.nextWeekButton.Location = new System.Drawing.Point(225, 38);
            this.nextWeekButton.Name = "nextWeekButton";
            this.nextWeekButton.Size = new System.Drawing.Size(75, 23);
            this.nextWeekButton.TabIndex = 48;
            this.nextWeekButton.Text = ">";
            this.nextWeekButton.UseVisualStyleBackColor = true;
            this.nextWeekButton.Click += new System.EventHandler(this.NextWeekButton_Click);
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(TheTabulator.CalendarEvent);
            // 
            // previousWeekButton
            // 
            this.previousWeekButton.Location = new System.Drawing.Point(115, 38);
            this.previousWeekButton.Name = "previousWeekButton";
            this.previousWeekButton.Size = new System.Drawing.Size(75, 23);
            this.previousWeekButton.TabIndex = 49;
            this.previousWeekButton.Text = "<";
            this.previousWeekButton.UseVisualStyleBackColor = true;
            this.previousWeekButton.Click += new System.EventHandler(this.PreviousWeekButton_Click);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.previousWeekButton);
            this.Controls.Add(this.nextWeekButton);
            this.Controls.Add(this.pm11Label);
            this.Controls.Add(this.pm8Label);
            this.Controls.Add(this.pm10Label);
            this.Controls.Add(this.pm4Label);
            this.Controls.Add(this.pm9Label);
            this.Controls.Add(this.pm7Label);
            this.Controls.Add(this.am2Label);
            this.Controls.Add(this.pm6Label);
            this.Controls.Add(this.pm3Label);
            this.Controls.Add(this.pm5Label);
            this.Controls.Add(this.am1Label);
            this.Controls.Add(this.pm2Label);
            this.Controls.Add(this.am12Label);
            this.Controls.Add(this.pm1Label);
            this.Controls.Add(this.saturdayLabel);
            this.Controls.Add(this.pm12Label);
            this.Controls.Add(this.sundayLabel);
            this.Controls.Add(this.am11Label);
            this.Controls.Add(this.fridayLabel);
            this.Controls.Add(this.am10Label);
            this.Controls.Add(this.thursdayLabel);
            this.Controls.Add(this.am9Label);
            this.Controls.Add(this.wednesdayLabel);
            this.Controls.Add(this.am8Label);
            this.Controls.Add(this.tuesdayLabel);
            this.Controls.Add(this.am7Label);
            this.Controls.Add(this.mondayLabel);
            this.Controls.Add(this.am6Label);
            this.Controls.Add(this.sundayDateLabel);
            this.Controls.Add(this.am5Label);
            this.Controls.Add(this.saturdayDateLabel);
            this.Controls.Add(this.am4Label);
            this.Controls.Add(this.fridayDateLabel);
            this.Controls.Add(this.am3Label);
            this.Controls.Add(this.thursdayDateLabel);
            this.Controls.Add(this.wednesdayDateLabel);
            this.Controls.Add(this.tuesdayDateLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.calendarTable);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.calendarFeatureLabel);
            this.Controls.Add(this.mondayDateLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Calendar";
            this.Size = new System.Drawing.Size(1425, 918);
            this.Load += new System.EventHandler(this.Calendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label calendarFeatureLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label mondayDateLabel;
        private System.Windows.Forms.Label tuesdayDateLabel;
        private System.Windows.Forms.Label wednesdayDateLabel;
        private System.Windows.Forms.Label thursdayDateLabel;
        private System.Windows.Forms.Label fridayDateLabel;
        private System.Windows.Forms.Label saturdayDateLabel;
        private System.Windows.Forms.Label sundayDateLabel;
        private System.Windows.Forms.TableLayoutPanel calendarTable;
        private System.Windows.Forms.Label mondayLabel;
        private System.Windows.Forms.Label tuesdayLabel;
        private System.Windows.Forms.Label wednesdayLabel;
        private System.Windows.Forms.Label thursdayLabel;
        private System.Windows.Forms.Label fridayLabel;
        private System.Windows.Forms.Label sundayLabel;
        private System.Windows.Forms.Label saturdayLabel;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.Label am12Label;
        private System.Windows.Forms.Label am1Label;
        private System.Windows.Forms.Label am2Label;
        private System.Windows.Forms.Label am3Label;
        private System.Windows.Forms.Label am4Label;
        private System.Windows.Forms.Label am5Label;
        private System.Windows.Forms.Label am6Label;
        private System.Windows.Forms.Label am7Label;
        private System.Windows.Forms.Label am8Label;
        private System.Windows.Forms.Label am9Label;
        private System.Windows.Forms.Label am10Label;
        private System.Windows.Forms.Label am11Label;
        private System.Windows.Forms.Label pm12Label;
        private System.Windows.Forms.Label pm1Label;
        private System.Windows.Forms.Label pm2Label;
        private System.Windows.Forms.Label pm3Label;
        private System.Windows.Forms.Label pm4Label;
        private System.Windows.Forms.Label pm5Label;
        private System.Windows.Forms.Label pm6Label;
        private System.Windows.Forms.Label pm8Label;
        private System.Windows.Forms.Label pm9Label;
        private System.Windows.Forms.Label pm10Label;
        private System.Windows.Forms.Label pm11Label;
        private System.Windows.Forms.Label pm7Label;
        private System.Windows.Forms.Button nextWeekButton;
        private System.Windows.Forms.Button previousWeekButton;
    }
}
