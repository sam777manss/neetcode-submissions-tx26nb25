public class Solution {
    public int Search(int[] nums, int target) {
            int left = 0, right = nums.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] == target)
                    return mid;
                if (nums[left] <= nums[mid])
                {
                    if (target < nums[mid] && target >= nums[left])
                        right = mid - 1;
                    else
                        left = mid + 1;
                }
                else if (nums[right] > nums[mid])
                {
                    if (target <= nums[right] && target > nums[mid])
                        left = mid + 1;
                    else
                        right = mid - 1;
                }
            }

            return -1;
    }
}
