namespace NArms.Config.Deserializers.Default
{
    using System;

    internal class DefaultEnumDeserializer : IDeserializer
    {
        private const string DefaultValueSubstitute = "@Default";

        public DefaultEnumDeserializer()
        {
        }

        public object Deserialize(Type type, string value)
        {
            if (value == DefaultValueSubstitute)
                return Activator.CreateInstance(type);
            return Enum.Parse(type, value);
        }
    }
}