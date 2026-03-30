public class Solution {
    public int LengthOfLongestSubstring(string s) {
            int left = 0, right = 0, totalMax = 0;
            List<char> uniqueInts = new List<char>();

            while (right < s.Length)
            {
                while (uniqueInts.Contains(s[right]))
                {
                    uniqueInts.Remove(s[left]);
                    left++;
                }

                uniqueInts.Add(s[right]);

                totalMax = Math.Max(totalMax, uniqueInts.Count);

                right++;
            }

            return totalMax;
    }
}
