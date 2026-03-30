public class Solution {
    public int[] TwoSum(int[] nums, int target) {
            for(int i = 0; i < nums.Length; i++)
            {
                int firstNumber = nums[i]; // 4
                for (int j = 1 + i; j < nums.Length; j++)
                {
                    if(nums[j] + firstNumber == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[] { };
    }
}
