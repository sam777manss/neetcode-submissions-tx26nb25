public class Solution {
    public int CharacterReplacement(string s, int k) {
            int left = 0, right = 0, windowSize = 1, maxFreq = 1, maxAnswer = 0;            
            Dictionary<char, int> CharacterCounts = new Dictionary<char, int>();  // Character and how many times it appeared.

            while (right < s.Length)
            {
                if (CharacterCounts.ContainsKey(s[right]))
                {
                    CharacterCounts[s[right]] = CharacterCounts[s[right]] + 1;
                }
                else
                {
                    CharacterCounts.Add(s[right], 1);
                }

                maxFreq = CharacterCounts.Values.Max();
                windowSize = right - left + 1;
                if (windowSize - maxFreq <= k)
                {
                    maxAnswer = Math.Max(maxAnswer, windowSize);

                }
                else
                {
                    CharacterCounts[s[left]] = CharacterCounts[s[left]] - 1;
                    left++;
                }
                right++;
            }

        return maxAnswer;     
    }
}
