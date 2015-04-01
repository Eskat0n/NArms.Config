namespace NArms.Config.Tests.StubTypes
{
    using System;

    [Flags]
    public enum StubFlags
    {
        OptionOne = 1,
        OptionTwo = 2,
        OptionThree = 4,
        OptionFour = 8
    }
}