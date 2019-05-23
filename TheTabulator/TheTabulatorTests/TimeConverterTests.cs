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
    public class TimeConverterTests
    {
        [TestMethod()]
        public void ConvertTimeTest()  //Testing input to time converter
        {
            string time = "12:03";
            TimeSpan expected = new TimeSpan(12, 03, 00);

            TimeSpan actual = TimeConverter.ConvertTime(time);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NullTest()  //Testing a null input
        {
            string time = "";

            TimeSpan actual = TimeConverter.ConvertTime(time);

            Assert.IsNull(actual);
        }

        [TestMethod()]
        public void TestFormat()  //Testing input to time converter
        {
            string time = "303";
            TimeSpan expected = new TimeSpan(03, 03, 00);

            TimeSpan actual = TimeConverter.ConvertTime(time);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestFormat2()  //Testing 24 hour times converting to 12 hour times
        {
            string time = "13:44";
            TimeSpan expected = new TimeSpan(01, 44, 00);

            TimeSpan actual = TimeConverter.ConvertTime(time);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestFormat3()  //Testing input of words instead of times
        {
            string time = "word";
            TimeSpan expected = new TimeSpan(00, 00, 00);

            TimeSpan actual = TimeConverter.ConvertTime(time);

            Assert.AreEqual(expected, actual);
        }
    }
}