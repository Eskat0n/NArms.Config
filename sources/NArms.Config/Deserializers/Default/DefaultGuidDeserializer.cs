namespace NArms.Config.Deserializers.Default
{
    using System;

    internal class DefaultGuidDeserializer : IDeserializer
    {
        public object Deserialize(string value)
        {
            try
            {
                return new Guid(value);
            }
            catch
            {
                return Guid.Empty;
            }
        }
    }
}