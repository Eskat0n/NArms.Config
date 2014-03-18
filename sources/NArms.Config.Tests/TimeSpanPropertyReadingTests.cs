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
            public TimeSpan HrMinSecTimeSpan { get; set; }

            public TimeSpan DsHrMinSecTimeSpan { get; set; }
        }

        [SetUp]
        public void SetUp()
        {
            _config = new Config();
        }

        [Test]
        public void ShouldBeAbleToReadHrMinSecTimeSpanValues()
        {
            var timeSpan = new TimeSpan(10, 20, 30);

            Assert.AreEqual(timeSpan, _config.HrMinSecTimeSpan);
        }
        
        [Test]
        public void ShouldBeAbleToReadDsHrMinSecTimeSpanValues()
        {
            var timeSpan = new TimeSpan(5, 10, 20, 30);

            Assert.AreEqual(timeSpan, _config.DsHrMinSecTimeSpan);
        }
    }
}