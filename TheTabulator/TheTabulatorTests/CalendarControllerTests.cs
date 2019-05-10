using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheTabulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTabulator.Tests
{
    [TestClass()]
    public class CalendarControllerTests
    {


        [TestMethod()]
        public void NextWeekTest()
        {
            //Setup
            //TimeSpan object that represents 7 days duration
            TimeSpan sevenDays = TimeSpan.FromDays(7);

            //DateTime object that represents the current date + the 7 day TimeSpan (ie, a 
            //week from now).
            //                                              Also, rolling back to the start of the week
            //                                              (CalendarController uses Monday as well).
            DateTime expected = DateTime.Now.Add(sevenDays).WeekStartDate(DayOfWeek.Monday);

            //String of the total date. (Note: Cannot use DateTime.ToString() methods because do not have full
            //                           access to the DateTime object in the CalendarController).
            string expectedString = expected.Year.ToString() + " " + expected.FullMonthString()
                + " " + expected.Day.ToString();


            //Action
            CalendarController.ResetWeek();
            CalendarController.NextWeek();

            string actualString = CalendarController.YearString + " " + CalendarController.MonthString
                + " " + CalendarController.DayDateString(DayOfWeek.Monday);


            //Test
            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod()]
        public void PreviousWeekTest()
        {
            //Setup
            //TimeSpan object that represents 7 days duration
            TimeSpan sevenDays = TimeSpan.FromDays(7);

            //DateTime object that represents the current date - the 7 day TimeSpan (ie, the 
            //week before now).
            //                                              Also, rolling back to the start of the week
            //                                              (CalendarController uses Monday as well).
            DateTime expected = DateTime.Now.Subtract(sevenDays).WeekStartDate(DayOfWeek.Monday);

            //String of the total date. (Note: Cannot use DateTime.ToString() methods because do not have full
            //                           access to the DateTime object in the CalendarController).
            string expectedString = expected.Year.ToString() + " " + expected.FullMonthString()
                + " " + expected.Day.ToString();


            //Action
            CalendarController.ResetWeek();
            CalendarController.PreviousWeek();

            string actualString = CalendarController.YearString + " " + CalendarController.MonthString
                + " " + CalendarController.DayDateString(DayOfWeek.Monday);


            //Test
            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod()]
        public void ResetWeekTest()
        {
            //Setup
            //DateTime object of the start of the current week (same day CalendarController should start on).
            DateTime expected = DateTime.Now.WeekStartDate(DayOfWeek.Monday);

            //String of the total date. (Note: Cannot use DateTime.ToString() methods because do not have full
            //                           access to the DateTime object in the CalendarController).
            string expectedString = expected.Year.ToString() + " " + expected.FullMonthString()
                + " " + expected.Day.ToString();


            //Action for previous weeks
            CalendarController.PreviousWeek();
            CalendarController.PreviousWeek();
            CalendarController.PreviousWeek();
            CalendarController.PreviousWeek();
            CalendarController.ResetWeek();

            string actualString = CalendarController.YearString + " " + CalendarController.MonthString
                + " " + CalendarController.DayDateString(DayOfWeek.Monday);


            //Test resetting from previous weeks
            Assert.AreEqual(expectedString, actualString);

            //Action for next weeks
            CalendarController.NextWeek();
            CalendarController.NextWeek();
            CalendarController.NextWeek();
            CalendarController.NextWeek();
            CalendarController.ResetWeek();

            actualString = CalendarController.YearString + " " + CalendarController.MonthString
                + " " + CalendarController.DayDateString(DayOfWeek.Monday);

            //Test resetting from next weeks
            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod()]
        public void DayDateStringTest()
        {
            DateTime now = DateTime.Now;
            //The expected day of the current month as a string
            //Eg, if it is the 6th of June, then expected should be "6"
            string expected = now.Day.ToString();

            string actual = CalendarController.DayDateString(now.DayOfWeek);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DayIndexForMondayStartTestWithSaturday()
        {
            //Creating a new date for Saturday, May 4th, 2019
            DateTime testDate = new DateTime(2019, 5, 4);

            //Saturday should be represented by a 5
            int expected = 5;

            Assert.AreEqual(expected, CalendarController.DayIndexForMondayWeekStart(testDate.DayOfWeek));
        }

        [TestMethod()]
        public void DayIndexForMondayStartTestWithSunday()
        {
            //Creating a new date for Sunday, May 5th, 2019
            DateTime testDate = new DateTime(2019, 5, 5);

            //Sunday should be represented by a 6
            int expected = 6;

            Assert.AreEqual(expected, CalendarController.DayIndexForMondayWeekStart(testDate.DayOfWeek));
        }

        [TestMethod()]
        public void DayIndexForMondayStartTestWithMonday()
        {
            //Creating a new date for Monday, April 29th, 2019
            DateTime testDate = new DateTime(2019, 4, 29);

            //Monday should be represented by a 0
            int expected = 0;

            Assert.AreEqual(expected, CalendarController.DayIndexForMondayWeekStart(testDate.DayOfWeek));
        }
    }
}