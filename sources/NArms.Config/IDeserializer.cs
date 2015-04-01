namespace NArms.Config
{
    using System;

    public interface IDeserializer
    {
        object Deserialize(Type type, string value);
    }
}