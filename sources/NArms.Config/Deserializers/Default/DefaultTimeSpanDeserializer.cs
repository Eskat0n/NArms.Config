namespace NArms.Config.Deserializers.Default
{
    using System;

    internal class DefaultTimeSpanDeserializer : IDeserializer
    {
        public object Deserialize(string value)
        {
            return TimeSpan.Parse(value);
        }
    }
}