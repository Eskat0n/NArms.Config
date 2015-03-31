namespace NArms.Config.Extensions
{
    using System;
    using System.Linq;

    public static class TypeExtensions
    {
        public static bool IsNullable(this Type type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof (Nullable<>);
        }

        public static Type GetNullableType(this Type type)
        {
            if (type.IsNullable() == false)
                return type.GetGenericArguments().First();

            throw new NotSupportedException("");
        }
    }
}