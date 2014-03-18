namespace NArms.Config.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class TimeSpanPropertyReadingTests
    {
        private Config _config;

        private class Config : ConfigBase
        {
            public TimeSpan FullTimeSpan { get; set; }
        }

        [SetUp]
        public void SetUp()
        {
            _config = new Config();
        }

        [Test]
        public void ShouldBeAbleToReadFullTimeSpanValues()
        {
            var timeSpan = new TimeSpan(10, 20, 30);

            Assert.AreEqual(timeSpan, _config.FullTimeSpan);
        }
    }
}