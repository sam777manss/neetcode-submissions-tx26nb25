public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
            int index1 = -1, index2 = -1;
            int i = 0, j = 0;
            while (i < numbers.Length)
            {
                while (j < numbers.Length)
                {
                    if (i != j)
                    {
                        if (numbers[i] + numbers[j] == target && i < j)
                        {
                            index1 = i + 1;
                            index2 = j + 1;
                            break;
                        }
                    }
                    j++;
                }
                if (index1 != -1 && index2 != -1)
                    break;
                i++;
                j = 0;
            }
        return new int[] { index1, index2 };   
    }
}
