public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
                    Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!keyValuePairs.ContainsKey(nums[i]))
                {
                    int increase = 1;
                    keyValuePairs.Add(nums[i], increase);
                    for (int j = 1 + i; j < nums.Length; j++)
                    {
                        if (nums[i] == nums[j])
                        {
                            increase = increase + 1;
                            keyValuePairs[nums[i]] = increase;
                        }
                    }
                }
            }

            keyValuePairs =  keyValuePairs.OrderByDescending(x => x.Value).Take(k).ToDictionary(x => x.Key, x => x.Value);
            int[] OutputList = new int[k];
            int temp = 0;
            foreach(var i in keyValuePairs)
            {
                OutputList[temp] = i.Key;
                temp++;
            }
            return OutputList;
    }
}
