namespace Tasks.LeetCode75.ArrayStringTopic;

public class Gardener
{
    public bool CanPlaceFlowers1(int[] flowerbed, int n)
    {
        int count = 0;
        for (int i = 0; i < flowerbed.Length; i++)
        {
            bool emptyLeftPlot = false;
            bool emptyRightPlot = false;

            if (flowerbed[i] == 0)
            {
                emptyLeftPlot = (i == 0) || flowerbed[i - 1] == 0;
                emptyRightPlot = (i == flowerbed.Length - 1) || flowerbed[i + 1] == 0;
            }

            if (emptyLeftPlot && emptyRightPlot)
            {
                flowerbed[i] = 1;
                count++;
                if (count >= n)
                {
                    return true;
                }
            }
        }

        return count >= n;
    }

    public bool CanPlaceFlowers2(int[] flowerbed, int n)
    {
        int i = 0;
        while (i < flowerbed.Length && n > 0)
        {
            if (flowerbed[i] == 0 &&
                (i == 0 || flowerbed[i - 1] == 0) &&
                (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
            {
                n--;
                i += 2;
            }
            else i++;
        }

        return n == 0;
    }
}
