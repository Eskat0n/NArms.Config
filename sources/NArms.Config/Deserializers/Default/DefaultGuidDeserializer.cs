namespace NArms.Config.Deserializers.Default
{
    using System;

    internal class DefaultGuidDeserializer : IDeserializer
    {
        private readonly bool _isNullable;

        public DefaultGuidDeserializer(bool isNullable)
        {
            _isNullable = isNullable;
        }

        public object Deserialize(Type type, string value)
        {
            try
            {
                return new Guid(value);
            }
            catch
            {
                return _isNullable
                    ? (object) null
                    : Guid.Empty;
            }
        }
    }
}