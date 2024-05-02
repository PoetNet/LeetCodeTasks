namespace Tasks.Daily.April2024;

public class MaxKFinder
{
    public int FindMaxK1(int[] nums)
    {
        int max = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > max && nums[i] > 0 &&
                nums.Contains(0 - nums[i]))
            {
                max = nums[i];
            }
        }

        return max != 0 ? max : -1;
    }

    public int FindMaxK2(int[] nums)
    {
        int result = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > result && nums[i] > 0 && 
                nums.Contains(-nums[i]))
            {
                result = nums[i];
            }
        }

        return result;
    }
}
