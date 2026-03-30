public class Solution {
    public bool hasDuplicate(int[] nums) {
            int len = nums.Length;
            for(int i = 0; i < len; i++)
            {
                for (int j = 1 + i; j < len; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        return true;
                    }                    
                }
            }
            return false;
    }
}