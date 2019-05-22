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
    public class CalendarEventTests
    {
        [TestMethod()]
        public void CalculateStartPositionTest()
        {
            //Creating a new date for Saturday, May 4th, 2019 at 10am
            DateTime startTime = new DateTime(2019, 5, 4, 10, 0, 0);

            //Event endtime for Saturday May 5th, 2019 at 2:30pm
            DateTime endTime = new DateTime(2019, 5, 4, 14, 30, 0);
            
            CalendarEvent testEvent = new CalendarEvent("testEvent", "test location",  startTime, endTime);

            //Event should be in the 5th column index for a Saturday
            int expectedColumnIndex = 5;

            //Event should start in the 10th row index for 10am
            int expectedRowStartIndex = 10;


            //Action
            testEvent.CalculateStartPosition(out int actualColumnIndex, out int actualRowStartIndex);


            //Test
            Assert.AreEqual(expectedColumnIndex, actualColumnIndex);
            Assert.AreEqual(expectedRowStartIndex, actualRowStartIndex);
        }

        [TestMethod()]
        public void CalculateRowSpanTest()
        {
            //Creating a new date for Saturday, May 4th, 2019 at 10am
            DateTime startTime = new DateTime(2019, 5, 4, 10, 0, 0);

            //Event endtime for Saturday May 5th, 2019 at 2:30pm
            DateTime endTime = new DateTime(2019, 5, 4, 14, 30, 0);

            CalendarEvent testEvent = new CalendarEvent("testEvent", "test location", startTime, endTime);

            //Event should end on the 14th row index for 2pm (1400)
            int expected = 14;

            int actual = testEvent.CalculateRowSpan();

            Assert.AreEqual(expected, actual);
        }
    }
}