namespace NArms.Config.Tests
{
    using NUnit.Framework;
    using StubTypes;

    [TestFixture]
    public class EnumPropertyReadingTests
    {
        private Config _config;

        private class Config : ConfigBase
        {
            public StubEnum EnumValue { get; set; }
            public StubEnum DefaultEnumValue { get; set; }
            public StubEnum SixthEnumValue { get; set; }
        }

        [SetUp]
        public void SetUp()
        {
            _config = new Config();
        }

        [Test]
        public void ShouldBeAbleToReadEnumValue()
        {
            Assert.AreEqual(StubEnum.ValueTwo, _config.EnumValue);
        }

        [Test]
        public void ShouldBeAbleToReadDefaultEnumValue()
        {
            Assert.AreEqual(StubEnum.ValueOne, _config.DefaultEnumValue);
        }

        [Test]
        public void ShouldBeAbleToReadNumericEnumValue()
        {
            Assert.AreEqual(StubEnum.ValueSix, _config.SixthEnumValue);
        }
    }
}