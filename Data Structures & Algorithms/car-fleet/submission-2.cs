public class Solution {
        public int CarFleet(int target, int[] position, int[] speed)
        {
            int n = position.Length;
            var cars = new (int pos, int speed)[n];
            for (int j = 0; j < n; j++)
            {
                cars[j] = (position[j], speed[j]);
            }
            Array.Sort(cars, (a, b) => b.pos.CompareTo(a.pos));
            int fleet = 0;
            double currentTime = 0, lastTime = 0;
            for (int i = 0; i < n; i ++)
            {
                currentTime = (double)(target - cars[i].pos) / cars[i].speed;
                if (currentTime > lastTime)
                {
                    lastTime = currentTime;
                    fleet += 1;
                }
            }
            return fleet;
        }
}
