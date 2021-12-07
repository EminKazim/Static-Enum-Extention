using Static__extention__enum.Helpers;
using System;

namespace Static__extention__enum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Cavid muellim 100 yazacaq mene";
            Console.WriteLine(word.MatchCount("a"));

        }
    }
}
