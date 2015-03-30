namespace NArms.Config.Deserializers.Default
{
    using System;
    using System.Linq;

    public class DefaultFlagDeserializer : IDeserializer
    {
        public object Deserialize(Type type, string value)
        {
            var flagValues = value.Split(new[] {"|", ",", ";", " "},
                                         StringSplitOptions.RemoveEmptyEntries);

            return flagValues.Aggregate(0, (c, v) => c | (int) Enum.Parse(type, v));
        }
    }
}