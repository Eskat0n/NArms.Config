namespace NArms.Config.Tests
{
    using NUnit.Framework;
    using StubTypes;

    [TestFixture]
    public class FlagEnumPropertyReadingTests
    {
        private Config _config;

        private class Config : ConfigBase
        {
            public StubFlags SingleFlagValue { get; set; }
            public StubFlags CombinedFlagValue { get; set; }
            public StubFlags CombinedFlagValueViaComma { get; set; }
            public StubFlags CombinedFlagValueViaSemicolon { get; set; }
            public StubFlags CombinedFlagValueViaSpace { get; set; }
        }

        [SetUp]
        public void SetUp()
        {
            _config = new Config();
        }

        [Test]
        public void ShouldBeAbleToReadSingleFlagValue()
        {
            Assert.AreEqual(StubFlags.OptionThree, _config.SingleFlagValue);
        }

        [Test]
        public void ShouldBeAbleToReadCombinedFlagValue()
        {
            Assert.AreEqual(StubFlags.OptionOne | StubFlags.OptionTwo | StubFlags.OptionFour,
                            _config.CombinedFlagValue);
        }

        [Test]
        public void ShouldBeAbleToReadCombinedFlagValueViaComma()
        {
            Assert.AreEqual(StubFlags.OptionOne | StubFlags.OptionTwo | StubFlags.OptionFour,
                            _config.CombinedFlagValueViaComma);
        }

        [Test]
        public void ShouldBeAbleToReadCombinedFlagValueViaSemicolon()
        {
            Assert.AreEqual(StubFlags.OptionOne | StubFlags.OptionTwo | StubFlags.OptionFour,
                            _config.CombinedFlagValueViaSemicolon);
        }

        [Test]
        public void ShouldBeAbleToReadCombinedFlagValueViaSpace()
        {
            Assert.AreEqual(StubFlags.OptionOne | StubFlags.OptionTwo | StubFlags.OptionFour,
                            _config.CombinedFlagValueViaSpace);
        }
    }
}