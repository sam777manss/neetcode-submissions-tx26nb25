public class Solution {
    public int MaxProfit(int[] prices) {
            int MaxProfit = 0, i = 0, j = 1;
            if(prices.Length > 1)
            {
                int left = prices[i], right = prices[j];

                while (j < prices.Length)
                {
                    right = prices[j];
                    if (right <= left)
                    {
                        left = right;
                    }
                    else
                    {
                        MaxProfit = right - left > MaxProfit ? right - left : MaxProfit;
                    }
                    j++;
                }
                return MaxProfit;
            }
            else
            {
                return MaxProfit;
            }      
    }
}
