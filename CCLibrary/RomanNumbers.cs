

using System;
using System.Collections.Generic;

namespace CCLibrary
{
    public class RomanNumbers
    {
        public RomanNumbers()
        {
                
        }

        public string Translate(int arabic)
        {
            var arabicToRoman = new Dictionary<int, string>()
            {
               { 1,"I" },
               { 4,"IV" },
               { 5,"V" },
               { 9,"IX" },
               { 10,"X" },
            };

            if (arabicToRoman.ContainsKey(arabic))
                return arabicToRoman[arabic];

            if (arabic > 10)
            {
                return "X" + Translate(arabic - 10);
            }

            if (arabic > 5)
            {
                return "V" + Translate(arabic - 5);
            }

            if (arabic > 1)
            {
                return "I" + Translate(arabic - 1);
            }

            return "";
        }
    }
}
