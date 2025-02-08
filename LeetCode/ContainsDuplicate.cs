public class Solution
{
    public bool containsDuplicate(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + i; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                    return 1;
            }
        }
        return 0;
    }
}