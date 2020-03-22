using System;
using System.Globalization;

namespace EserciziStringhe
{
    public class MetodiStringhe
    {
        public static bool AreEquals(string s1, string s2)
        {
            if (s1 == s2)
                return true;
            else
                return false;
        }

        public static bool ContainsDoubleChar(string s)
        {
            string a = "A";
            string e = "E";
            string i = "I";
            string o = "O";
            string u = "U";
            if (s.Contains(a) || s.Contains(e) || s.Contains(i) || s.Contains(o) || s.Contains(u))
                return true;
            else
                return false;
        }

        public static string Convert(string s)
        {
            string titleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(s);
            return (titleCase);
        }
    }
}
