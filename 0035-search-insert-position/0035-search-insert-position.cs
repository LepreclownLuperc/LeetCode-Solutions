public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int index = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (target > nums[i])
                index++;
            else
                return index;
        }
        return index;
    }
}