using System.Text.RegularExpressions;

namespace Tasks.LeetCode75.ArrayStringTopic;

public class WordsReverser
{
    public string ReverseWordsWithRegex(string s)
    {
        s = Regex.Replace(s,@"\s+", " ");
        var wordsArray = s.Split(' ');

        var left = 0;
        var right = wordsArray.Length - 1;

        while (left < right)
        {
            var temp = wordsArray[left];
            wordsArray[left] = wordsArray[right];
            wordsArray[right] = temp;

            left++;
            right--;
        }

        return String.Join(' ', wordsArray).Trim();
    }

    public string ReverseWords(string s)
    {
        string[] words = s.Split(" ");
        List<string> result = new List<string>();
        for (int i = words.Length - 1; i>= 0; i--)
        {
            if (!string.IsNullOrWhiteSpace(words[i]))
            {
                result.Add(words[i]);
            }
        }

        return string.Join(' ', result);
    }
}
