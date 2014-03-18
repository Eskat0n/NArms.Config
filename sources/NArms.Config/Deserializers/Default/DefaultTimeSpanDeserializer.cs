namespace NArms.Config.Deserializers.Default
{
    using System;
    using System.Text.RegularExpressions;

    internal class DefaultTimeSpanDeserializer : IDeserializer
    {
        public object Deserialize(string value)
        {
            var daysMatch = Match(value, "days");
            if (daysMatch.Success)
            {
                var days = int.Parse(daysMatch.Groups[1].Value);
                return TimeSpan.FromDays(days);
            }

            var hoursMatch = Match(value, "hr");
            if (hoursMatch.Success)
            {
                var hours = int.Parse(hoursMatch.Groups[1].Value);
                return TimeSpan.FromHours(hours);
            }

            var minutesMatch = Match(value, "min");
            if (minutesMatch.Success)
            {
                var minutes = int.Parse(minutesMatch.Groups[1].Value);
                return TimeSpan.FromMinutes(minutes);
            }

            var secondsMatch = Match(value, "sec");
            if (secondsMatch.Success)
            {
                var seconds = int.Parse(secondsMatch.Groups[1].Value);
                return TimeSpan.FromSeconds(seconds);
            }

            int mseconds;
            if (int.TryParse(value, out mseconds))
                return TimeSpan.FromMilliseconds(mseconds);

            return TimeSpan.Parse(value);
        }

        private static Match Match(string input, string unit)
        {
            return Regex.Match(input, string.Format(@"^\s*(\d+){0}\s*$", unit));
        }
    }
}