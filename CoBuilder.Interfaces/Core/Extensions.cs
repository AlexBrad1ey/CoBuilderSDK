using System;
using System.Reflection;
using System.Text;

namespace CoBuilder.Service
{

    public static class Extensions
    {
        public static T DeepCopy<T>(this T obj)
        {
            if (obj == null)
                throw new ArgumentNullException("Object cannot be null");
            return (T)Process(obj);
        }

        private static object Process(object obj)
        {
            if (obj == null)
                return null;
            var type = obj.GetType();
            if (type.IsValueType || type == typeof(string))
            {
                return obj;
            }
            else if (type.IsArray)
            {
                Type elementType = Type.GetType(
                     type.FullName.Replace("[]", string.Empty));
                var array = obj as Array;
                Array copied = Array.CreateInstance(elementType, array.Length);
                for (int i = 0; i < array.Length; i++)
                {
                    copied.SetValue(Process(array.GetValue(i)), i);
                }
                return Convert.ChangeType(copied, obj.GetType());
            }
            else if (type.IsClass)
            {
                object toret = Activator.CreateInstance(obj.GetType());
                FieldInfo[] fields = type.GetFields(BindingFlags.Public |
                            BindingFlags.NonPublic | BindingFlags.Instance);
                foreach (FieldInfo field in fields)
                {
                    object fieldValue = field.GetValue(obj);
                    if (fieldValue == null)
                        continue;
                    field.SetValue(toret, Process(fieldValue));
                }
                return toret;
            }
            else
                throw new ArgumentException("Unknown type");
        }

        public static string ReplaceAllSpaces(this string input, string replacement)
        {
            var builder = new StringBuilder();
            bool continuousSpace = false;
            foreach (var c in input)
            {
                if (!continuousSpace && char.IsWhiteSpace(c))
                {
                    builder.Append(replacement);
                    continuousSpace = true;
                }
                else if (!char.IsWhiteSpace(c))
                {
                    builder.Append(c);
                    continuousSpace = false;
                }
            }
            return builder.ToString();
        }

    }
}
