namespace Tasks.LeetCode75.ArrayStringTopic;

public class ProductExceptSelfCalculator
{
    public int[] ProductExceptSelf1(int[] nums)
    {
        int[] result = new int[nums.Length];

        int prefix = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = prefix;
            prefix *= nums[i];
        }
        
        int postfix = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            result[i] *= postfix;
            postfix *= nums[i];
        }

        return result;
    }

    public int[] ProductExceptSelf2(int[] nums)
    {
        int len = nums.Length;

        int[] left = new int[len];
        left[0] = 1;

        int[] right = new int[len];
        right[len - 1] = 1;
        
        for (int i = 1; i < len; i++)
        {
            left[i] = left[i - 1] * nums[i - 1];
        }

        for (int i = len - 1; i > 0; i--)
        {
            if (i != len - 1) right[i] = right[i + 1] * nums[i + 1];
        }

        for (int i = 0; i < len; i++)
        {
            left[i] = left[i] * right[i];
        }

        return left;
    }

    public int[] ProductExceptSelf3(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];

        result[0] = 1;
        for (int i = 1; i < n; i++)
        {
            result[i] = result[i - 1] * nums[i - 1];
        }

        int rightProduct = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            result[i] += rightProduct;
            rightProduct *= nums[i];
        }

        return result;
    }
}
