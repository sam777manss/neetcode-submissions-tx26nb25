public class Solution {
    public int LongestConsecutive(int[] nums) {
            nums = nums.OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(",", nums));
            int consecutiveSequence1 = 0;
            int consecutiveSequence2 = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                { consecutiveSequence1++; consecutiveSequence2++; }
                else if ((nums[i]) == (nums[i - 1] + 1))
                {
                    consecutiveSequence1++;
                }
                else if ((nums[i]) != (nums[i - 1] + 1))
                {
                    if ((nums[i]) == (nums[i - 1]))
                        continue;
                    if (consecutiveSequence1 > consecutiveSequence2)
                    {
                        consecutiveSequence2 = consecutiveSequence1;
                    }
                    consecutiveSequence1 = 1;
                }

            }
            consecutiveSequence2 = consecutiveSequence2 >= consecutiveSequence1 ? consecutiveSequence2 : consecutiveSequence1;
            return consecutiveSequence2;
    }
}
