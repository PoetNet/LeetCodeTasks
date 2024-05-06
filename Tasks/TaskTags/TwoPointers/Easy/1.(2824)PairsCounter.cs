namespace Tasks.Daily.April2024;

public static class PairsCounter
{
    public static int CountPairs1(IList<int> nums, int target)
    {
        int n = nums.Count;

        int left = 0;
        int right = n - 1;

        int pairsCount = 0;
        while (left < n)
        {
            if (left >= 0 && left < right &&
                nums[left] + nums[right] < target)
            {
                pairsCount++;
                right--;
            }
            else if (right <= left)
            {
                left++;
                right = n - 1;
            }
            else
            {
                right--;
            }
        }

        return pairsCount;
    }

    public static int CountPairs2(IList<int> nums, int target)
    {
        IList<int> sortedNums = nums.OrderBy(nums => nums).ToList();

        int pairsCount = 0;
        int left = 0;
        int right = nums.Count - 1;

        while (left < right)
        {
            if (sortedNums[left] + sortedNums[right] < target)
            {
                pairsCount+= right - left;
                left++;
            }
            else
            {
                right--;
            }
        }

        return pairsCount;
    }

    public static int CountPairs3MyBest(IList<int> nums, int target)
    {
        Sort(nums);

        int pairsCount = 0;
        int left = 0;
        int right = nums.Count - 1;

        while (left < right)
        {
            if (nums[left] + nums[right] < target)
            {
                pairsCount+= right - left;
                left++;
            }
            else
            {
                right--;
            }
        }

        return pairsCount;
    }

    public static void Sort<T>(IList<T> list) where T : IComparable<T>
    {
        if (list == null || list.Count <= 1)
            return;

        QuickSortRecursive(list, 0, list.Count - 1);
    }

    private static void QuickSortRecursive<T>(IList<T> list, int low, int high) where T : IComparable<T>
    {
        if (low < high)
        {
            int partitionIndex = Partition(list, low, high);
            QuickSortRecursive(list, low, partitionIndex - 1);
            QuickSortRecursive(list, partitionIndex + 1, high);
        }
    }

    private static int Partition<T>(IList<T> list, int low, int high) where T : IComparable<T>
    {
        T pivot = list[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (list[j].CompareTo(pivot) <= 0)
            {
                i++;
                Swap(list, i, j);
            }
        }

        Swap(list, i + 1, high);
        return i + 1;
    }

    private static void Swap<T>(IList<T> list, int i, int j)
    {
        T temp = list[i];
        list[i] = list[j];
        list[j] = temp;
    }
}
