namespace NArms.Config.Deserializers.Default
{
    using System;
    using System.Text.RegularExpressions;

    internal class DefaultTimeSpanDeserializer : IDeserializer
    {
        public object Deserialize(string value)
        {
            var match = Regex.Match(value, @"^\s*(\d+)hr\s*$");
            if (match.Success)
            {
                var hours = int.Parse(match.Groups[1].Value);
                return new TimeSpan(hours, 0, 0);
            }

            return TimeSpan.Parse(value);
        }
    }
}