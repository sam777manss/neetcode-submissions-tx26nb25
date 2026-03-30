public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
                    if (strs.Length < 1)
            {
                return new List<List<string>>{ new List<string> {""} };
            }
            if (strs.Length == 1)
            {
                if(strs[0] == "")
                {
                    return new List<List<string>> { new List<string> { "" } };
                }
                else
                {
                    return new List<List<string>> { new List<string> { strs[0] } };
                }
            }
            List<List<string>> strList = new List<List<string>>();
            List<string> strList2 = new List<string>();
            List<string> LastList = new List<string>();

            for (int i = 0; i < strs.Length; i++)
            {
                strList2.Add(strs[i]);
            }

            for (int i = 0; i < strList2.Count; i++)
            {
                LastList = new();
                LastList.Add(strList2[i]);
                char[] parent = strList2[i].ToCharArray();
                Array.Sort(parent);
                for (int j = 1 + i; j < strList2.Count; j++)
                {
                    char[] subsequent = strList2[j].ToCharArray();
                    Array.Sort(subsequent);
                    if (parent.SequenceEqual(subsequent))
                    {
                        LastList.Add(strList2[j]);
                        strList2.RemoveAt(j);
                        j = j - 1;
                    }
                }
                strList.Add(LastList);
            }

            return strList;
    }
}
