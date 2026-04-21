public class Solution {
        public int CarFleet(int target, int[] position, int[] speed)
        {
            Dictionary<int, int> keyValuePairs = new();
            for (int j = 0; j < position.Length; j++)
            {
                keyValuePairs.Add(position[j], speed[j]);
            }
            keyValuePairs = keyValuePairs.OrderByDescending(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            double fleet = 0, currentTime = 0, currentPosition = 0, currentSpeed = 0, lastTime = 0;
            foreach (var keyValuePairs1 in keyValuePairs)
            {
                currentPosition = keyValuePairs1.Key;
                currentSpeed = keyValuePairs1.Value;
                currentTime = (target - currentPosition) / currentSpeed;
                if (currentTime > lastTime)
                {
                    lastTime = currentTime;
                    fleet += 1;
                }
            }
            return Convert.ToInt32(fleet);
        }
}
