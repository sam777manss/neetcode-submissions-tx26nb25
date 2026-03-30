public class Solution {
    public bool IsAnagram(string s, string t) {
            List<int> arr1 = new List<int>();
            List<int> arr2 = new List<int>();

            if (s.Length != t.Length)
            {
                return false;
            }
            foreach (char c in s)
            {
                arr1.Add((int)c);
            }
            foreach (char c in t)
            {
                arr2.Add((int)c);
            }

            for (int i = 0; i < arr1.Count; i++)
            {
                for (int j = 1 + i; j < arr1.Count; j++)
                {
                    if (arr1[i] > arr1[j])
                    {
                        int temp = arr1[i]; // big
                        arr1[i] = arr1[j]; // small
                        arr1[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arr2.Count; i++)
            {
                for (int j = 1 + i; j < arr2.Count; j++)
                {
                    if (arr2[i] > arr2[j])
                    {
                        int temp = arr2[i]; // big
                        arr2[i] = arr2[j]; // small
                        arr2[j] = temp;
                    }
                }
            }

            for(int i = 0; i < arr1.Count; i++)
            {
                if(arr1[i] != arr2[i])
                {
                    return false;
                }
            }
            return true;
    }
}
