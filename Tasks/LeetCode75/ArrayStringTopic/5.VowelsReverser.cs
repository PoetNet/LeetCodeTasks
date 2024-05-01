using System;
using System.Text;

namespace Tasks.LeetCode75.ArrayStringTopic;

public class VowelsReverser
{
    public string ReverseVowels1(string s)
    {
        var vowelsInTheString = new Stack<char>();
        var vowels = new HashSet<char> { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };
        var indexesOfVowels = new HashSet<int>();
        var result = new StringBuilder(s);

        for (var i = 0; i < s.Length; i++)
        {
            if (vowels.Contains(s[i]))
            {
                vowelsInTheString.Push(s[i]);
                indexesOfVowels.Add(i);
            }
        }

        for (var i = 0; i < s.Length; i++)
        {
            if (indexesOfVowels.Contains(i))
            {
                result[i] = vowelsInTheString.Pop();
            }
        }

        return result.ToString();
    }

    public string ReverseVowels(string s)
    {
        var vowels = new HashSet<char> { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };
        int left = 0, right = s.Length - 1;
        var result = new StringBuilder(s);

        while (left < right)
        {
            if (!vowels.Contains(s[left]))
            {
                ++left;
                continue;
            }

            if (!vowels.Contains(s[right]))
            {
                --right;
                continue;
            }

            (result[left], result[right]) = (result[right--], result[left++]);
        }

        return result.ToString();
    }

}
