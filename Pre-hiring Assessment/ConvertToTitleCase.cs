using System;
using System.Globalization;

namespace ConvertStringToTitleCase
{
    class StringToTitleCase
    {
        static void Main(string[] args)
        {
            var textinfo = new cultureInfo("en-US", false).TextInfo;

            var textInfo = CultureInfo.CurrentCulture.TextInfo;

            Console.WriteLine(textinfo.ToTitleCase("the lord of the rings"));
        }
    }
}