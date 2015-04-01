namespace NArms.Config.Deserializers.Default
{
    using System;

    internal class DefaultEnumDeserializer : IDeserializer
    {
        private const string DefaultValueSubstitute = "@Default";

        private readonly bool _isNullable;

        public DefaultEnumDeserializer(bool isNullable)
        {
            _isNullable = isNullable;
        }

        public object Deserialize(Type type, string value)
        {
            try
            {
                if (value == DefaultValueSubstitute)
                    return Activator.CreateInstance(type);

                return Enum.Parse(type, value);
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