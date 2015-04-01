namespace NArms.Config.Deserializers.Default
{
    using System;
    using System.Linq;

    public class DefaultBoolDeserializer : IDeserializer
    {
        private static readonly string[] TrueValues = {"yes", "true", "y"};
        private static readonly string[] FalseValues = {"no", "false", "n"};

        private readonly bool _isNullable;

        public DefaultBoolDeserializer(bool isNullable)
        {
            _isNullable = isNullable;
        }

        public object Deserialize(Type type, string value)
        {
            try
            {
                var lowerValue = value.ToLowerInvariant();

                if (TrueValues.Contains(lowerValue))
                    return true;
                if (FalseValues.Contains(lowerValue))
                    return false;

                throw new NotSupportedException();
            }
            catch
            {
                return _isNullable
                    ? (object)null
                    : false;
            }
        }
    }
}