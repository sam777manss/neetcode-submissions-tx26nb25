public class Solution {
    public bool CheckInclusion(string s1, string s2) {
            if (s1.Length > s2.Length) return false;

            Dictionary<char, int> s1Dic = new Dictionary<char, int>();
            Dictionary<char, int> s2Dic = new Dictionary<char, int>();

            for (int i = 0; i < s1.Length; i++)
            {
                s1Dic[s1[i]] = s1Dic.GetValueOrDefault(s1[i]) + 1;
                s2Dic[s2[i]] = s2Dic.GetValueOrDefault(s2[i]) + 1;
            }

            int left = 0;
            int right = s1.Length;

            if (CompareDictionary(s1Dic, s2Dic)) return true;

            while (right < s2.Length)
            {
                // Add entering character
                s2Dic[s2[right]] = s2Dic.GetValueOrDefault(s2[right]) + 1;

                // Remove leaving character — fix: do this BEFORE comparing
                s2Dic[s2[left]] = s2Dic[s2[left]] - 1;
                left++;
                right++;

                if (CompareDictionary(s1Dic, s2Dic)) return true;
            }

            return false;        
    }
    public static bool CompareDictionary(Dictionary<char, int> s1Dic, Dictionary<char, int> s2Dic)
    {
        foreach (var kvp in s1Dic)
        {
            if (s2Dic.GetValueOrDefault(kvp.Key) != kvp.Value)
                return false;
        }
        return true;
    }
}
