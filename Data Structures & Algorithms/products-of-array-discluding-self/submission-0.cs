public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int product = 1;
                for (int j = 0; j < nums.Length; j++)
                {
                    if(i != j)
                    {
                        product *= nums[j];
                    }
                }
                result.Add(product);
            }
            return result.ToArray();
    }
}
