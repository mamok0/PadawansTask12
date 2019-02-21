using System;
using System.Text.RegularExpressions;

namespace PadawansTask12
{
    public static class StringExtension
    {
        public static bool AllCharactersAreUnique(string source)
        {
            if (source == null)
                throw new ArgumentNullException();
            if (source.Length == 0)
                throw new ArgumentException();
            for(int i=0; i < source.Length; i++)
            {
                Regex character = new Regex(@source.Substring(i, 1));
                if (character.Matches(source).Count > 1)
                return false;
            }
            return true;
        }
    }
}