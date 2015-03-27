namespace NArms.Config.Deserializers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DeserializersRegistryBase : IDeserializersRegistry
    {
        private readonly IDictionary<Func<Type, bool>, IDeserializer> _deserializers
            = new Dictionary<Func<Type, bool>, IDeserializer>();

        protected void RegisterDeserializer<T>(IDeserializer deserializer)
        {
            _deserializers.Add(x => x == typeof(T), deserializer);
        }

        protected void RegisterDeserializer(Func<Type, bool> predicate, IDeserializer deserializer)
        {
            _deserializers.Add(predicate, deserializer);
        }

        public virtual object Deserialize(string value, Type propertyType)
        {
            var deserializer = _deserializers
                .Where(x => x.Key(propertyType))
                .Select(x => x.Value)
                .FirstOrDefault();
            if (deserializer == null)
                throw new NotImplementedException();

            return deserializer.Deserialize(propertyType, value);
        }
    }
}