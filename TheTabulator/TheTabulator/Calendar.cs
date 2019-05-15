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
            UpdateCalendar();
            //calendarTable.Controls.Clear
            
            Label label = new Label();
            label.BackColor = Color.MediumPurple;
            label.Text = "Event here";
            label.Dock = DockStyle.Fill;
            //calendarTable.SetRowSpan(label, 22);
            calendarTable.Controls.Add(label, 2, 2);

            MessageBox.Show(calendarTable.GetCellPosition(label).ToString());
        }

        private void NextWeekButton_Click(object sender, EventArgs e)
        {
            CalendarController.NextWeek();
            UpdateCalendar();
        }

        private void PreviousWeekButton_Click(object sender, EventArgs e)
        {
            CalendarController.PreviousWeek();
            UpdateCalendar();
        }

        private void CalendarTable_MouseClick(object sender, MouseEventArgs e)
        {
            if ((calendarTable.ColumnCount < 1) || (calendarTable.RowCount < 1))
                throw new Exception("Error: Should not be able to click if no cells in table.");
            
            MessageBox.Show("Cell coords are: (" + calendarTable.CellClickedColumnIndex(e.X).ToString() + ", " + calendarTable.CellClickedRowIndex(e.Y).ToString() + ")");


        }

        private void HighlightCurrentDay()
        {
            if (CalendarController.AtThisWeek())
            {
                int labelIndex = CalendarController.CurrentDayIndex();
                dateNumbersPanel.Controls[labelIndex].BackColor = Color.Yellow;
            }
        }

        private void ClearHighlight()
        {
            int labelIndex = CalendarController.CurrentDayIndex();
            dateNumbersPanel.Controls[labelIndex].BackColor = SystemColors.Control;
        }

        private void UpdateMonthYearLabel()
        {
            monthYearLabel.Text = CalendarController.MonthString
                              + " " 
                              + CalendarController.YearString;
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



        private void UpdateCalendar()
        {
            ClearHighlight();
            UpdateDateLabels();
            UpdateMonthYearLabel();
            HighlightCurrentDay();
            CalendarController.DrawWeeksEvents(calendarTable.Controls);
        }
    }
}
