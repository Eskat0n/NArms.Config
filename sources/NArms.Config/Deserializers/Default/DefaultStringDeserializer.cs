namespace NArms.Config.Deserializers.Default
{
    using System;

    internal class DefaultStringDeserializer : IDeserializer
    {
        public object Deserialize(Type type, string value)
        {
            return value;
        }
    }
}