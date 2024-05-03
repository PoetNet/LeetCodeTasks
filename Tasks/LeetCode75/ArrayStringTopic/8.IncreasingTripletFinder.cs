namespace Tasks.LeetCode75.ArrayStringTopic;

public class IncreasingTripletFinder
{
    public bool IncreasingTriplet(int[] nums)
    {
        int first = Int32.MaxValue;
        int second = Int32.MaxValue;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] <= first) first = nums[i];
            else if (nums[i] <= second) second = nums[i];
            else return true;
        }

        return false;
    }
}
