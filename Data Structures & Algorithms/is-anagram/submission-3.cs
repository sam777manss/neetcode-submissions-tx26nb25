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

            return char1.SequenceEqual(char2);
    }
}
