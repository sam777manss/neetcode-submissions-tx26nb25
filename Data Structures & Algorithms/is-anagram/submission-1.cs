public class Solution {
    public bool IsAnagram(string s, string t) {
            if(s.Length != t.Length)
            {
                return false;
            }
            char[] char1 = s.ToCharArray();
            char[] char2 = t.ToCharArray();

            for(int i = 0; i < char1.Length; i++){
                for(int j = 1 + i; j < char1.Length; j++)
                {
                    if ( (int)char1[i] > (int)char1[j] )
                    {
                        char c = char1[i];
                        char1[i] = char1[j];
                        char1[j] = c;
                    }
                }
            }
            for (int i = 0; i < char1.Length; i++)
            {
                for (int j = 1 + i; j < char2.Length; j++)
                {
                    if ((int)char2[i] > (int)char2[j])
                    {
                        char c = char2[i];
                        char2[i] = char2[j];
                        char2[j] = c;
                    }
                }
            }

            for(int i = 0; i < char1.Length; i++)
            {
                if(char1[i] != char2[i])
                {
                    return false;
                }
            }
            return true;
    }
}
