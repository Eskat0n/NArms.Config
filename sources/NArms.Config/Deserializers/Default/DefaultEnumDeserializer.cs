namespace NArms.Config.Deserializers.Default
{
    using System;

    internal class DefaultEnumDeserializer : IDeserializer
    {
        public DefaultEnumDeserializer()
        {
        }

        public object Deserialize(Type type, string value)
        {
            return Enum.Parse(type, value);
        }
    }
}