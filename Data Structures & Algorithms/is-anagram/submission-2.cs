public class Solution {
    public bool IsAnagram(string s, string t) {
            if(s.Length != t.Length)
            {
                return false;
            }
            char[] char1 = s.ToCharArray();
            char[] char2 = t.ToCharArray();

            Array.Sort(char1);
            Array.Sort(char2);

            for (int i = 0; i < char1.Length; i++)
            {
                if(char1[i] != char2[i])
                {
                    return false;
                }
            }
            return true;
    }
}
