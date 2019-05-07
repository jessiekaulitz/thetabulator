﻿using System;
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
            //calendarTable.Controls.Clear
            
            Label label = new Label();
            label.BackColor = Color.MediumPurple;
            label.Text = "Event here";
            label.Dock = DockStyle.Fill;

            calendarTable.Controls.Add(label, 2, 2);

        }

        private void MonthLabel_Click(object sender, EventArgs e)
        {

        }

        //Needs to update the calendar labels for date numbers, month (if necessary), and year (if necessary)
        private void UpdateYearLabel()
        {
            yearLabel.Text = CalendarController.Year;
        }

        private void UpdateMonthLabel()
        {
            monthLabel.Text = CalendarController.Month;
        }

        private void NextWeekButton_Click(object sender, EventArgs e)
        {
            CalendarController.NextWeek();
            UpdateLabels();
            CalendarController.DrawWeeksEvents(calendarTable.Controls);
        }

        private void UpdateDateLabels()
        {
            mondayDateLabel.Text = CalendarController.DayDate(DayOfWeek.Monday).ToString();
            tuesdayDateLabel.Text = CalendarController.DayDate(DayOfWeek.Tuesday).ToString();
            wednesdayDateLabel.Text = CalendarController.DayDate(DayOfWeek.Wednesday).ToString();
            thursdayDateLabel.Text = CalendarController.DayDate(DayOfWeek.Thursday).ToString();
            fridayDateLabel.Text = CalendarController.DayDate(DayOfWeek.Friday).ToString();
            saturdayDateLabel.Text = CalendarController.DayDate(DayOfWeek.Saturday).ToString();
            sundayDateLabel.Text = CalendarController.DayDate(DayOfWeek.Sunday).ToString();
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

        private void MondayDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label24_Click(object sender, EventArgs e)
        {

        }
    }
}
