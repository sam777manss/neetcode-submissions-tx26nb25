public class Solution {
    public int MaxArea(int[] heights) {
            int largetArea = 0, right = heights.Length - 1, height = 0, length = 0;
            for(int i = 0; i < heights.Length; i++)
            {                
                right = (heights.Length - 1);
                while(right > i)
                {
                    height = (heights[i] > heights[right]) == true ? heights[right] : heights[i];
                    length = right - i;

                    if (largetArea < height * length)
                    {
                        largetArea = height * length;
                    }
                    right--;
                }
            }
            
            return largetArea;
    }
}
