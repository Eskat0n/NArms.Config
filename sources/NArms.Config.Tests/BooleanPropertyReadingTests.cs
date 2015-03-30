namespace NArms.Config.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class BooleanPropertyReadingTests
    {
        private Config _config;

        private class Config : ConfigBase
        {
            public bool PositiveOne { get; set; }
            public bool PositiveTwo { get; set; }
            public bool PositiveThree { get; set; }
            public bool NegativeOne { get; set; }
            public bool NegativeTwo { get; set; }
            public bool NegativeThree { get; set; }
        }

        [SetUp]
        public void SetUp()
        {
            _config = new Config();
        }

        [Test]
        public void ShouldBeAbleToReadYesNoTrueValue()
        {
            Assert.IsTrue(_config.PositiveOne);
        }

        [Test]
        public void ShouldBeAbleToReadTrueValue()
        {
            Assert.IsTrue(_config.PositiveTwo);
        }

        [Test]
        public void ShouldBeAbleToReadShortTrueValue()
        {
            Assert.IsTrue(_config.PositiveThree);
        }

        [Test]
        public void ShouldBeAbleToReadYesNoFalseValue()
        {
            Assert.IsFalse(_config.NegativeOne);
        }

        [Test]
        public void ShouldBeAbleToReadFalseValue()
        {
            Assert.IsFalse(_config.NegativeTwo);
        }

        [Test]
        public void ShouldBeAbleToReadShortFalseValue()
        {
            Assert.IsFalse(_config.NegativeThree);
        }
    }
}