using System;
using NUnit.Framework;

namespace DotnetCOREClasses.Tests
{
    public class TimeConverterTests
    {
        [Test()]
        public static void Test1Name()
        {
            TimeConverter.ConvertTime("10:30");
            Assert.Pass();
        }
    }
}
