public class Solution {

    public string Encode(IList<string> strs) {
            string strsConcated = string.Empty;

            string strsList = null;
            for(int i = 0; i < strs.Count; i++)
            {
                strsList += strs[i].Length + "#" + strs[i];
            }            
            return strsList;
    }

    public List<string> Decode(string s) {
        if(s == null)
        {
            return new List<string>();
        }
        List<string> result = new List<string>();
        int i = 0;

        while (i < s.Length)
        {
            int j = i;

            // 1️ Find '#'
            while (s[j] != '#')
            {
                j++;
            }

            // 2️ Extract length
            int length = int.Parse(s.Substring(i, j - i));

            // 3️ Move pointer after '#'
            i = j + 1;

            // 4️ Extract string of given length
            string word = s.Substring(i, length);
            result.Add(word);

            // 5️ Move pointer after word
            i = i + length;
        }

        return result;
   }
}
