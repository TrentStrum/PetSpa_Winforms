using System.Globalization;

namespace TT.Common.Extensions
{
    public static class ExtensionMethods
    {
        public static bool IsNumeric(this string source) => !string.IsNullOrEmpty(source) && source.All(char.IsDigit);

        public static bool ContainsAny(this string source, params string[] needles) => needles.Any(needle => source.Contains(needle));

        /// <summary>Returns the value of <strong>this</strong> object converted to the specified type.</summary>
        /// <typeparam name="T">The Type being converted to.</typeparam>
        /// <param name="value">The value being converted.</param>
        /// <returns></returns>
        public static T As<T>(this object value) => value.As<T>(default);

        /// <summary>Returns the value of <strong>this</strong> object converted to the specified type.</summary>
        /// <typeparam name="T">The Type being converted to.</typeparam>
        /// <param name="value">The value being converted.</param>
        /// <param name="defaultValue">The default value to return if 'value' is NULL.</param>
        /// <returns></returns>
        public static T As<T>(this object value, T defaultValue)
        {
            try
            {
                var toType = typeof(T);
                if (value == null || value == DBNull.Value || Equals(value, defaultValue)) return defaultValue;
                if (value is string)
                {
                    if (toType == typeof(Guid))
                    {
                        return As(new Guid(Convert.ToString(value, CultureInfo.CurrentCulture)), defaultValue);
                    }
                    else if (string.IsNullOrEmpty(value as string) && toType != typeof(string))
                    {
                        return As(null, defaultValue);
                    }
                    else if (toType.IsEnum)
                    {
                        if (Enum.IsDefined(toType, value))
                        {
                            return (T)Enum.Parse(toType, value.ToString());
                        }
                        else if ((value as string).IsNumeric())
                        {
                            var intValue = Convert.ToInt32(value);
                            return intValue.As<T>();
                        }
                    }
                    else if (toType == typeof(bool))
                    {
                        if ((new[] { "1", "TRUE", "YES" }).Contains(value.ToString().ToUpper()))
                        {
                            return As(true, defaultValue);
                        }
                        else if ((new[] { "0", "FALSE", "NO" }).Contains(value.ToString().ToUpper()))
                        {
                            return As(false, defaultValue);
                        }
                    }
                    else if (toType == typeof(decimal) && (value as string).ContainsAny("$", ",", " "))
                    {
                        return As(value.ToString().Replace("$", "").Replace(",", "").Replace(" ", ""), defaultValue);
                    }
                }
                else
                {
                    if (typeof(T) == typeof(string))
                    {
                        return As(Convert.ToString(value, CultureInfo.CurrentCulture), defaultValue);
                    }
                }

                if (toType.IsGenericType && toType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
                {
                    toType = Nullable.GetUnderlyingType(toType);
                }

                var canConvert = toType is IConvertible || toType.IsValueType && !toType.IsEnum;
                return canConvert ? (T)Convert.ChangeType(value, toType, CultureInfo.CurrentCulture) : (T)value;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return defaultValue;
            }
        }
    }
}
