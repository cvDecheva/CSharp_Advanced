namespace _1.ExtensionMethodSubstring.Extensions
{
    using System.Text;

    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder stringBuilder, int index, int length)
        {
            return new StringBuilder(stringBuilder.ToString().Substring(index, length));
        }
    }
}
