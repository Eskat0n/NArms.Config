namespace NArms.Config.Deserializers.Default
{
    using System;
    using System.Linq;

    public class DefaultFlagDeserializer : IDeserializer
    {
        private readonly bool _isNullable;

        public DefaultFlagDeserializer(bool isNullable)
        {
            _isNullable = isNullable;
        }

        public object Deserialize(Type type, string value)
        {
            try
            {
                var flagValues = value.Split(new[] {"|", ",", ";", " "},
                                             StringSplitOptions.RemoveEmptyEntries);

                return flagValues.Aggregate(0, (c, v) => c | (int) Enum.Parse(type, v));
            }
            catch (Exception)
            {
                return _isNullable
                    ? null
                    : Activator.CreateInstance(type);
            }
        }
    }
}