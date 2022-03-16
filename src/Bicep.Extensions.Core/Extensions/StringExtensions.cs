using static System.Linq.Enumerable;

namespace Bicep.Extensions.Core.Extensions
{
    public static class StringExtensions
    {
        public static string Indent(this string value, int indent)
            => $"{string.Join("", Range(1, 2 * indent).Select(i => ' '))}{value}";

        public static string[] Indent(this string[] value, int indent)
        {
            var content = new List<string>();

            foreach (var item in value)
            {
                content.Add(item.Indent(indent));
            }

            return content.ToArray();
        }

    }
}
