using System.Collections.Generic;

public class PContainsRedundancy
{
    public bool Process(int[] nums)
    {
        int size = nums.Length;
        HashSet<int> NumbersSet = new HashSet<int>();

        for (int i = 0; i < size; i++)
        {
            if (NumbersSet.Contains(nums[i]))
            {
                return true;
            }
            else
            {
                NumbersSet.Add(nums[i]);
            }
        }
        return false;
    }

}