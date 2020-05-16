namespace _1.ExtensionMethodSubstring
{
    using System;
    using System.Text;
    using _1.ExtensionMethodSubstring.Extensions;

    public class ExtensionMethodSubstring
    {
        static void Main()
        {
            StringBuilder stringBuilder = new StringBuilder("Cvetelina");
            Console.WriteLine(stringBuilder.Substring(2, 3)); 
        }
    }
}
