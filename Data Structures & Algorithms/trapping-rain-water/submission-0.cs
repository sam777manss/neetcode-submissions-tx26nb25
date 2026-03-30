public class Solution {
    public int Trap(int[] height) {
        int left = 0, right = height.Length - 1;
        int leftMax = 0, rightMax = 0;
        int totalWater = 0;

        while (left <= right)
        {
            if (height[left] <= height[right])
            {
                if (height[left] >= leftMax)
                    leftMax = height[left];       // new left wall found
                else
                    totalWater += leftMax - height[left]; // gap — add water
                left++;
            }
            else
            {
                if (height[right] >= rightMax)
                    rightMax = height[right];     // new right wall found
                else
                    totalWater += rightMax - height[right];
                right--;
            }
        }
        return totalWater;  // = 9 for your input        
    }
}
