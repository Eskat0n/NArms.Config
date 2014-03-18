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
            public TimeSpan HrTimeSpan { get; set; }
            public TimeSpan MinTimeSpan { get; set; }
            public TimeSpan SecTimeSpan { get; set; }
            public TimeSpan MsecTimeSpan { get; set; }
            public TimeSpan BigHrTimeSpan { get; set; }
            public TimeSpan BigMinTimeSpan { get; set; }
            public TimeSpan BigSecTimeSpan { get; set; }
            public TimeSpan BigMsecTimeSpan { get; set; }
            public TimeSpan DaysTimeSpan { get; set; }
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
        
        [Test]
        public void ShouldBeAbleToReadHrTimeSpanValues()
        {
            var timeSpan = new TimeSpan(10, 0, 0);

            Assert.AreEqual(timeSpan, _config.HrTimeSpan);
        }
        
        [Test]
        public void ShouldBeAbleToReadMinTimeSpanValues()
        {
            var timeSpan = new TimeSpan(0, 20, 0);

            Assert.AreEqual(timeSpan, _config.MinTimeSpan);
        }
        
        [Test]
        public void ShouldBeAbleToReadSecTimeSpanValues()
        {
            var timeSpan = new TimeSpan(0, 0, 30);

            Assert.AreEqual(timeSpan, _config.SecTimeSpan);
        }

        [Test]
        public void ShouldBeAbleToReadMsecTimeSpanValues()
        {
            var timeSpan = new TimeSpan(0, 0, 0, 0, 580);

            Assert.AreEqual(timeSpan, _config.MsecTimeSpan);
        }
        
        [Test]
        public void ShouldBeAbleToReadBigHrTimeSpanValues()
        {
            var timeSpan = new TimeSpan(1, 1, 0, 0);

            Assert.AreEqual(timeSpan, _config.BigHrTimeSpan);
        }
        
        [Test]
        public void ShouldBeAbleToReadBigMinTimeSpanValues()
        {
            var timeSpan = new TimeSpan(2, 20, 0);

            Assert.AreEqual(timeSpan, _config.BigMinTimeSpan);
        }
        
        [Test]
        public void ShouldBeAbleToReadBigSecTimeSpanValues()
        {
            var timeSpan = new TimeSpan(0, 10, 25);

            Assert.AreEqual(timeSpan, _config.BigSecTimeSpan);
        }

        [Test]
        public void ShouldBeAbleToReadBigMsecTimeSpanValues()
        {
            var timeSpan = new TimeSpan(0, 0, 0, 3, 180);

            Assert.AreEqual(timeSpan, _config.BigMsecTimeSpan);
        }

        [Test]
        public void ShouldBeAbleToReadDaysTimeSpanValues()
        {
            var timeSpan = new TimeSpan(3, 0, 0, 0);

            Assert.AreEqual(timeSpan, _config.DaysTimeSpan);            
        }
    }
}