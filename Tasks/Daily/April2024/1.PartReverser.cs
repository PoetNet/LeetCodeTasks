namespace Tasks.Daily.April2024;

public class PartReverser
{
    public string ReversePrefix1(string word, char ch)
    {
        var chIndex = word.IndexOf(ch);
        if (chIndex == -1 || chIndex == 0) return word;

        var charArray = word.ToCharArray();
        int left = 0;
        int right = chIndex;

        while (left < right)
        {
            char temp = charArray[left];
            charArray[left] = charArray[right];
            charArray[right] =
                temp; // is 5% (64мс/61мс) slower: `(charArray[left], charArray[right]) = (charArray[right], charArray[left]);` 
            left++;
            right--;
        }

        return new string(charArray);
    }

    public string ReversePrefix2(string word, char ch) // is 5% slower than first too
    {
        var arr = word.ToCharArray();
        var idx = word.IndexOf(ch);
        Array.Reverse(arr, 0, idx + 1);
        return new string(arr);
    }
}