namespace Tasks.Daily.April2024;

public class MaxKFinder
{
    public int FindMaxK(int[] nums)
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
