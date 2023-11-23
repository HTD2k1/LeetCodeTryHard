

namespace DebugLeetCodeLocally.ArrayAndHashing;

public class ProductExceptSelfSolution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] result = new int[nums.Length];
        result[0] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            result[i] = result[i - 1] * nums[i - 1];
        }

        int tempRight = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            result[i] *= tempRight;
            tempRight *= nums[i];
        }
        return result;
    }
    
}
