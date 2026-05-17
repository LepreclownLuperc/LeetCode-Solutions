public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int resultIndex = nums.IndexOf(target);
        if(resultIndex == -1)
        {
            if(target > nums[nums.Length - 1])
                return resultIndex = nums.Length;
            else if(target < nums[0])
                return resultIndex = 0;
        
            for(int i = 0; i < nums.Length - 1; i++)
            {
                if(target < nums[i + 1])
                {
                    return resultIndex = i + 1;

                }
            }
        }
        return resultIndex;
    }
}