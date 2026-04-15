public class Solution {
        public int[] DailyTemperatures(int[] temperature)
        {
            int currentTemperature = default;
            int[] arrayResult = new int[temperature.Length];
            int j = 0, i = 0;
            while (i < temperature.Length)
            {
                currentTemperature = temperature[i];
                while (currentTemperature >= temperature[j] && j < temperature.Length - 1)
                    j++;
                if (currentTemperature < temperature[j])
                {
                    arrayResult[i] = j - i;
                }
                i++;
                j = i;
            }
            return arrayResult;
        }
}
