namespace Tasks.Daily.April2024;

public static class PrimeFractionFinder
{
    public static int[] KthSmallestPrimeFraction1(int[] arr, int k)
    {
        int len = arr.Length;
        int i = 0;
        int j = len - 1;

        List<(float, int[])> output = new();

        while (i < j)
        {
            output.Add(((float)arr[i] / arr[j], new int[] { arr[i], arr[j] }));
            j--;
            if (i == j & i + 1 < len)
            {
                i++;
                j = len - 1;
            }
        }

        output = output.OrderBy(x => x.Item1).ToList();

        return len == 2 ? output[k - 1].Item2 : output[k].Item2;
    }

    public static int[] KthSmallestPrimeFraction2(int[] arr, int k)
    {
        int n = arr.Length;
        double low = 0, high = 1;

        while (low < high)
        {
            double mid = low + (high - low) / 2;

            int[] res = GetFractionsLessThanMid(arr, k, n, mid);

            if (res[0] == k) return new int[] { arr[res[1]], arr[res[2]] };
            else if (res[0] > k) high = mid;
            else low = mid;
        }

        return new int[] { };
    }

    public static int[] GetFractionsLessThanMid(int[] arr, int k, int n, double mid)
    {
        double maxLessThanMid = 0.0;

        int x = 0, y = 0, total = 0, j = 1;

        for (int i = 0; i < n - 1; i++)
        {
            while (j < n && arr[i] > arr[j] * mid)
            {
                j++;
            }

            if (j == n) break;

            total += (n - j);
            double fraction = (double)arr[i] / arr[j];

            if (fraction > maxLessThanMid)
            {
                maxLessThanMid = fraction;
                x = i;
                y = j;
            }
        }

        return new int[] {total, x, y };
    }

}

