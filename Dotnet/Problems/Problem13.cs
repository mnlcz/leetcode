using System.Text.RegularExpressions;

namespace Problems;

public sealed partial class Problem13
{
    // https://leetcode.com/problems/roman-to-integer/description/
    public int RomanToInt(string s)
    {
        var number = 0;

        foreach (var l in s)
            number += _table[l];

        return Fix(s, number);
    }

    private static readonly Dictionary<char, int> _table = new()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    private static int Fix(string s, int number)
    {
        var iv = Regex.Matches(s, "IV").Count;
        var ix = Regex.Matches(s, "IX").Count;
        var xl = Regex.Matches(s, "XL").Count;
        var xc = Regex.Matches(s, "XC").Count;
        var cd = Regex.Matches(s, "CD").Count;
        var cm = Regex.Matches(s, "CM").Count;

        number -= iv * 2;
        number -= ix * 2;
        number -= xl * 20;
        number -= xc * 20;
        number -= cd * 200;
        number -= cm * 200;

        return number;
    }
}
