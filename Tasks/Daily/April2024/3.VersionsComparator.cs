namespace Tasks.Daily.April2024;

public class VersionsComparator
{
    public int CompareVersion1(string version1, string version2)
    {
        int i = 0, j = 0;

        while (i < version1.Length || j < version2.Length)
        {
            int num1 = 0, num2 = 0;

            while (i < version1.Length && version1[i] != '.')
            {
                num1 = num1 * 10 + (version1[i] - '0');
                i++;
            }

            while (j < version2.Length && version2[j] != '.')
            {
                num2 = num2 * 10 + (version2[j] - '0');
                j++;
            }

            if (num1 < num2) return -1;
            if (num1 > num2) return 1;

            i++;
            j++;
        }

        return 0;
    }

    public int CompareVersion2(string version1, string version2)
    {
        var split1 = version1.Split('.');
        var split2 = version2.Split('.');

        int i = 0, j = 0;
        while (i < split1.Length || j < split2.Length)
        {
            int one = i < split1.Length ? Int32.Parse(split1[i]) : 0;
            int two = i < split2.Length ? Int32.Parse(split2[i]) : 0;

            i++;
            j++;

            if (one == two) continue;

            return one < two ? -1 : 1;
        }

        return 0;
    }
}
