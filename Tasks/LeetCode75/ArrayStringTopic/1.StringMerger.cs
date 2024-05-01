using System.Text;

namespace Tasks.LeetCode75.ArrayStringTopic;

public class PartReversStringMerger
{
    public string MergeAlternately1(string word1, string word2)
    {
        int m = word1.Length;
        int n = word2.Length;
        var builder = new StringBuilder();

        int i = 0;
        int j = 0;

        while (i < m || j < n)
        {
            if (i < m)
            {
                builder.Append(word1[i]);
                i++;
            }

            if (j < n)
            {
                builder.Append(word2[j]);
                j++;
            }
        }
        return builder.ToString();
    }

    public string MergeAlternately2(string word1, string word2)
    {
        var longer = word1.Length > word2.Length ? word1.Length : word2.Length;

        var builder = new StringBuilder();
        for (var i = 0; i < longer; i++)
        {
            if (i < word1.Length) builder.Append(word1[i]);
            if (i < word2.Length) builder.Append(word2[i]);
        }
        return builder.ToString();
    }
}