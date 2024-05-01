namespace Tasks.LeetCode75.ArrayStringTopic;

public class GreatestCommonDivisor
{
    // BruteForce
    public bool Valid(string str1, string str2, int k)
    {
        int len1 = str1.Length;
        int len2 = str2.Length;

        if (len1 % k > 0 || len2 % k > 0)
        {
            return false;
        }

        string baseStr = str1.Substring(0, k);
        return str1.Replace(baseStr, "").Length == 0 &&
               str2.Replace(baseStr, "").Length == 0;
    }

    public string GcdOfStringsBruteForce(string str1, string str2)
    {
        int len1 = str1.Length;
        int len2 = str2.Length;

        for (int i = Math.Min(len1, len2); i >= 0; i--)
        {
            if (Valid(str1, str2, i))
            {
                return str1.Substring(0, i);
            }
        }

        return String.Empty;
    }

    //Recursive
    public string GcdOfStringsRecursive(string str1, string str2)
    {
        if (!(str1 + str2).Equals(str2 + str1)) return string.Empty;

        int gcdLength = Gcd(str1.Length, str2.Length);
        return str1.Substring(0, gcdLength);
    }

    public static int Gcd(int x, int y)
    {
        if (y == 0) return x;

        return Gcd(y, x % y);
    }
}
