public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int low = 1, high = piles.Max(), answer = 0;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            int hours = HoursTaken(piles, mid);
            if (hours <= h)
            {
                answer = mid;
                high = mid - 1;
            }
            else if(hours > h)
            {
                low = mid + 1;
            }
        }
        return answer; 
    }

    public static int HoursTaken(int[] arrInt, int mid)
    {
        int i = 0, TotalHours = 0, hour = 0;
        while(i < arrInt.Length)
        {
            hour = Convert.ToInt32(Math.Ceiling((double)arrInt[i] / mid));
            TotalHours = hour + TotalHours;
            i++;
        }
        return TotalHours;
    }
}
