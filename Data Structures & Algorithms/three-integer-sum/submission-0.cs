public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
            Array.Sort(nums); // space complexity: O(1)
            Dictionary<(int, int), int> keyValuePairs = new();
            int left = 0, right = nums.Length - 1, sum = 0;
            List<List<int>> ThreeSum = new();
            int i = 0;
            for (; i < nums.Length; i++)
            {

                left = i + 1; right = nums.Length - 1;
                while (left < right)
                {
                    sum = nums[i] + nums[left] + nums[right];
                    if (sum == 0)
                    {
                        Console.WriteLine($"Found: {nums[i]} + {nums[left]} + {nums[right]}");
                        if (!keyValuePairs.ContainsKey((nums[left], nums[right])))
                        {
                            keyValuePairs[(nums[left], nums[right])] = nums[i];
                            ThreeSum.Add(new List<int> { nums[i], nums[left], nums[right] });
                        }
                        left++; right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else if (sum > 0)
                    {
                        right--;
                    }
                }

            }
            return ThreeSum;
    }
}
