using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheTabulator
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Decrements the date back until it is at the defined start day.
        /// </summary>
        /// <param name="dateTime">
        /// DayOfWeek type to select what day is considered the start of the week.
        /// </param>
        /// <param name="weekStartDay"></param>
        /// <returns></returns>
        public static DateTime WeekStartDate(this DateTime dateTime, DayOfWeek weekStartDay)
        {
            //Removing any time part of the date (will now be at 12am of the date)
            dateTime = dateTime.Date;

            while (dateTime.DayOfWeek != weekStartDay)
            {
                //This object's date becomes the day before
                dateTime = dateTime.Subtract(TimeSpan.FromDays(1));
            }

            return dateTime;
        }


        /// <summary>
        /// Returns a string representing the full month name of this date.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns>
        /// Month name as a full string. For example, January.
        /// </returns>
        public static string FullMonthString(this DateTime dateTime)
        {
            return dateTime.ToString("MMMM");
        }


        /// <summary>
        /// Calculates the column (X) index of a cell clicked.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="mouseXPosition">
        /// X position of the mouse when click event occurred (must be position relative to TableLayoutPanel component, not entire screen).
        /// </param>
        /// <returns>
        /// Integer representing the index of the cell column clicked. Starts at 0.
        /// </returns>
        public static int CellClickedColumnIndex(this TableLayoutPanel table, int mouseXPosition)
        { 
            int colIndex = 0;
            //Width of the first column
            //Add 1 to account for rightside border thickness
            float widthSum = table.ColumnWidthAsPixels(colIndex) + 1;

            while ((colIndex < table.ColumnCount) && (mouseXPosition > widthSum))
            {
                widthSum += table.ColumnWidthAsPixels(colIndex) + 1;
                colIndex++;
            }
            return colIndex;
        }


        /// <summary>
        /// Calculates the row (Y) index of a cell clicked.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="mouseYPosition">
        /// Y position of the mouse when click event occurred (must be position relative to TableLayoutPanel component, not entire screen).
        /// </param>
        /// <returns>
        /// Integer representing the index of the cell row clicked. Starts at 0.
        /// </returns>
        public static int CellClickedRowIndex(this TableLayoutPanel table, int mouseYPosition)
        {
            int rowIndex = 0;
            //Height of the first row
            //Add 1 to account for bottom border thickness
            float heightSum = table.RowHeightAsPixels(rowIndex) + 1;

            while ((rowIndex < table.RowCount) && (mouseYPosition > heightSum))
            {
                heightSum += table.RowHeightAsPixels(rowIndex) + 1;
                rowIndex++;
            }

            return rowIndex;
        }


        /// <summary>
        /// Gets the width of an individual column of the TableLayoutPanel.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="index">
        /// The index of the column to get the width for.
        /// </param>
        /// <returns>
        /// Integer representing the column width in pixels.
        /// </returns>
        public static int ColumnWidthAsPixels(this TableLayoutPanel table, int index)
        {
            //Out of bounds check
            if ((index < 0) || (index >= table.ColumnCount))
                throw new ArgumentOutOfRangeException("index");
            //Otherwise, if SizeType is a % then convert to decimal and * tableWidth (which is in pixels)
            else if (table.ColumnStyles[index].SizeType == SizeType.Percent)
                return Convert.ToInt32((table.ColumnStyles[index].Width / 100) * table.Width);
            //Or, if size is not a %, then return the width of this column as is
            else
                return Convert.ToInt32(table.ColumnStyles[index].Width);
        }
        

        /// <summary>
        /// Gets the height of an individual row of the TableLayoutPanel.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="index">
        /// The index of the row to get the height for.
        /// </param>
        /// <returns>
        /// Integer representing the row height in pixels.
        /// </returns>
        public static int RowHeightAsPixels(this TableLayoutPanel table, int index)
        {
            //Out of bounds check
            if ((index < 0) || (index >= table.RowCount))
                throw new ArgumentOutOfRangeException("index");
            //Otherwise, if SizeType is a % then convert to decimal and * tableHeight (which is in pixels)
            else if (table.RowStyles[index].SizeType == SizeType.Percent)
                return Convert.ToInt32((table.RowStyles[index].Height / 100) * table.Height);
            //Or, if size is not a %, then return the height of this row as is
            else
                return Convert.ToInt32(table.RowStyles[index].Height);
        }

        /// <summary>
        /// Returns the hour component of this DateTime object, with 12am as the '24th' hour.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns>
        /// Integer representing hour if not at 12am
        /// Otherwise, returns 24 for 12am (aka 0 hour)
        /// </returns>
        public static int Hour24(this DateTime dateTime)
        {
            return (dateTime.Hour == 0) ? 24 : dateTime.Hour;
        }
    }
}
