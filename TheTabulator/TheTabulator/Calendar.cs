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
    public partial class Calendar : UserControl
    {
        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            //Setting the vertical scroll to start 50% down to show the more relevant times people like
            calendarTable.VerticalScroll.Value = 50;
            CalendarController.DrawWeeksEvents(calendarTable.Controls);
            UpdateLabels();
            //calendarTable.Controls.Clear
            
            Label label = new Label();
            label.BackColor = Color.MediumPurple;
            label.Text = "Event here";
            label.Dock = DockStyle.Fill;

            calendarTable.Controls.Add(label, 2, 2);

        }

        private void UpdateYearLabel()
        {
            yearLabel.Text = CalendarController.YearString;
        }

        private void UpdateMonthLabel()
        {
            monthLabel.Text = CalendarController.MonthString;
        }

        private void NextWeekButton_Click(object sender, EventArgs e)
        {
            CalendarController.NextWeek();
            UpdateLabels();
            CalendarController.DrawWeeksEvents(calendarTable.Controls);
        }

        private void UpdateDateLabels()
        {
            DayOfWeek dayOfWeek = DayOfWeek.Monday;

            foreach (Label label in dateNumbersPanel.Controls)
            {
                label.Text = CalendarController.DayDateString(dayOfWeek).ToString();
                dayOfWeek++;
            }
        }

        private void PreviousWeekButton_Click(object sender, EventArgs e)
        {
            CalendarController.PreviousWeek();
            UpdateLabels();
            CalendarController.DrawWeeksEvents(calendarTable.Controls);
        }

        private void UpdateLabels()
        {
            UpdateDateLabels();
            UpdateMonthLabel();
            UpdateYearLabel();
        }
    }
}
