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
    public class ExtensionMethodsTests
    {
        [TestMethod()]
        public void WeekStartDateTest()
        {
            //Creating a new date for Saturday, May 4th, 2019
            DateTime testDate = new DateTime(2019, 5, 4);
            //Monday on the April was the starting date of this ^ week
            DateTime expectedDate = new DateTime(2019, 4, 29);

            Assert.AreEqual(expectedDate, testDate.WeekStartDate(DayOfWeek.Monday));
        }

        [TestMethod()]
        public void FullMonthStringTest()
        {
            //DateTime of Tuesday 6th August, 2019
            DateTime testDate = new DateTime(2019, 8, 6);

            string expected = "August";
            
            Assert.AreEqual(expected, testDate.FullMonthString());
        }
    }
}