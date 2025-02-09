public class ContainsDuplicateSolution
{
    public bool containsDuplicate(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + i; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                    return true;
            }
        }
        return false;
    }

    public bool containsDuplicate2(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();

        foreach(int num in nums)
        {
            set.Add(num);
        }

        if (nums.Length != set.Count) return true;
        return false;
    }
}
