using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Static__extention__enum.Helpers
{
    public static class Extention
    {


        public static int MatchCount(this string str, string pattern)
        {

            int matches = Regex.Matches(str, pattern).Count;
            return matches;

        }
    }
}

