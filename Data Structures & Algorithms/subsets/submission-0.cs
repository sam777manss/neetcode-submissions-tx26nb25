public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        Backtrack(0, new List<int>(), nums, result);
        return result;
    }

    private void Backtrack(int index, List<int> current, int[] nums,        List<List<int>> result)
    {
        // Add the current subset
        result.Add(new List<int>(current));

        for (int i = index; i < nums.Length; i++)
        {
            // Choose
            current.Add(nums[i]);

            // Explore
            Backtrack(i + 1, current, nums, result);

            // Undo / Backtrack
            current.RemoveAt(current.Count - 1);
        }
    }
}
