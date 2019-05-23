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

            Refresh();
        }

        private void NextWeekButton_Click(object sender, EventArgs e)
        {
            CalendarController.NextWeek();
            Refresh();
        }

        private void PreviousWeekButton_Click(object sender, EventArgs e)
        {
            CalendarController.PreviousWeek();
            Refresh();
        }

        /// <summary>
        /// When table is clicked new event can be added.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalendarTable_MouseClick(object sender, MouseEventArgs e)
        {
            if ((calendarTable.ColumnCount < 1) || (calendarTable.RowCount < 1))
                throw new Exception("Error: Should not be able to click if no cells in table.");

            int colIndex = calendarTable.CellClickedColumnIndex(e.X);
            int rowIndex = calendarTable.CellClickedRowIndex(e.Y);

            //If there is not already an event in the current cell
            if (calendarTable.GetControlFromPosition(colIndex, rowIndex) == null)
            {
                CalendarController.NewEventRequest(colIndex, rowIndex);
                Refresh();
            }
            else
                //Event editing is done only when the label itself is clicked, not the empty
                //space around the label.
                MessageBox.Show("Spot taken");
        }

        /// <summary>
        /// Highlights the label for the current day of the week, if in the current week
        /// </summary>
        private void HighlightCurrentDay()
        {
            if (CalendarController.IsAtThisWeek())
            {
                int labelIndex = CalendarController.CurrentDayIndex();
                dateNumbersPanel.Controls[labelIndex].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(169)))), ((int)(((byte)(248)))));
            }
        }

        /// <summary>
        /// Clears the highlight by changing the label color back to the default
        /// </summary>
        private void ClearHighlight()
        {
            int labelIndex = CalendarController.CurrentDayIndex();
            dateNumbersPanel.Controls[labelIndex].BackColor = Color.White;
        }

        /// <summary>
        /// Updates the month and year label of the calendar
        /// </summary>
        private void UpdateMonthYearLabel()
        {
            monthYearLabel.Text = CalendarController.MonthString
                              + " " 
                              + CalendarController.YearString;
        }



        /// <summary>
        /// Updates all date labels of the calendar for the current calendar week
        /// </summary>
        private void UpdateDateLabels()
        {
            DayOfWeek dayOfWeek = DayOfWeek.Monday;

            foreach (Label label in dateNumbersPanel.Controls)
            {
                label.Text = CalendarController.DayDateString(dayOfWeek).ToString();
                dayOfWeek++;
            }
        }



        /// <summary>
        /// Refreshes the calendar TableLayoutPanel with new date, month, and year labels
        /// and events are drawn for the current calendar week.
        /// </summary>
        public override void Refresh()
        {
            ClearHighlight();
            UpdateDateLabels();
            UpdateMonthYearLabel();
            HighlightCurrentDay();
            calendarTable.Visible = false;
            CalendarController.DrawWeeksEvents(calendarTable);
            calendarTable.Visible = true;
        }
    }
}
