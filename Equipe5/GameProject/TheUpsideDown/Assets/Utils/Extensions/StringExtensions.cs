using System.Collections.Generic;

namespace Assets.Utils.Extensions
{
    public static class StringExtensions
    {
        public static string ToCamelCase(this string value)
        {
            var words = value.Split(' ');
            var result = new List<string>();

            foreach (var word in words)
                result.Add(word.ToNameCase());

            return string.Join(" ", result);
        }


        public static string ToNameCase(this string value)
        {
            return char.ToUpperInvariant(value[0]) + value.Substring(1).ToLower();
        }
    }
}
