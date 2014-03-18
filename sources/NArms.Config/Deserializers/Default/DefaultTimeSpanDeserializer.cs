namespace NArms.Config.Deserializers.Default
{
    using System;
    using System.Text.RegularExpressions;

    internal class DefaultTimeSpanDeserializer : IDeserializer
    {
        public object Deserialize(string value)
        {
            var hoursMatch = Match(value, "hr");
            if (hoursMatch.Success)
            {
                var hours = int.Parse(hoursMatch.Groups[1].Value);
                return new TimeSpan(hours, 0, 0);
            }

            var minutesMatch = Match(value, "min");
            if (minutesMatch.Success)
            {
                var minutes = int.Parse(minutesMatch.Groups[1].Value);
                return new TimeSpan(0, minutes, 0);
            }

            return TimeSpan.Parse(value);
        }

        private static Match Match(string input, string unit)
        {
            return Regex.Match(input, string.Format(@"^\s*(\d+){0}\s*$", unit));
        }
    }
}