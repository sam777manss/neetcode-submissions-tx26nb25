public class Solution {
    public bool IsPalindrome(string s) {
            char[] charArray = s.ToCharArray();
            List<char> cleanArray = new List<char>();
            for (int i = 0; i < charArray.Length; i++)
            {
                char c = charArray[i];
                if  (
                        c >= '0' && c <= '9' ||
                        c >= 'A' && c <= 'Z' ||
                        c >= 'a' && c <= 'z'
                    )
                {
                    cleanArray.Add(c);
                }
            }
            string clearString = new string(cleanArray.ToArray());
            clearString = clearString.ToLower();
            int j = clearString.Length - 1;
            bool isPalindrome = true;
            for (int i = 0; i < (clearString.Length / 2); i++)
            {
                if(clearString[i] != clearString[j])
                {
                    isPalindrome = false;
                }
                j--;
            }
        return isPalindrome;
    }
}
