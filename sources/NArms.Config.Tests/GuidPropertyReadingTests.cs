namespace NArms.Config.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class GuidPropertyReadingTests
    {
        private Config _config;
        private Guid _guid;

        private class Config : ConfigBase
        {
            public Guid DigitsGuid { get; set; }
            public Guid HyphensGuid { get; set; }
            public Guid BracesGuid { get; set; }
            public Guid ParenthesesGuid { get; set; }
            public Guid EmptyGuid { get; set; }
            public Guid? NullGuid { get; set; }
        }

        [SetUp]
        public void SetUp()
        {
            _config = new Config();
            _guid = new Guid("{89e4745c-11f1-47fd-b7e0-efe3dac5a8d6}");
        }

        [Test]
        public void ShouldBeAbleToReadDigitsFormattedGuid()
        {
            Assert.AreEqual(_guid, _config.DigitsGuid);
        }
        
        [Test]
        public void ShouldBeAbleToReadHyphensFormattedGuid()
        {
            Assert.AreEqual(_guid, _config.HyphensGuid);
        }
        
        [Test]
        public void ShouldBeAbleToReadBracesFormattedGuid()
        {
            Assert.AreEqual(_guid, _config.BracesGuid);
        }
        
        [Test]
        public void ShouldBeAbleToReadParenthesesFormattedGuid()
        {
            Assert.AreEqual(_guid, _config.ParenthesesGuid);
        }

        [Test]
        public void ShouldBeAbleToReadEmptyGuid()
        {
            Assert.AreEqual(Guid.Empty, _config.EmptyGuid);
        }

        [Test]
        public void ShouldBeAbleToReadNullableEmptyGuid()
        {
            Assert.IsNull(_config.NullGuid);
        }
    }
}