public class Solution {
    public int[][] KClosest(int[][] points, int k) {
            var priorityQueue = new PriorityQueue<(int, int), int>();
            var returning = new int[k][];
            foreach (var aries in points)
            {
                priorityQueue.Enqueue((aries[0], aries[1]), (aries[0] *         aries[0] + aries[1] * aries[1]));
            }

            for (int j = 0; j < k; j++)
            {
                var (x, y) = priorityQueue.Dequeue();
                returning[j] = new int[] { x, y };
            }

            return returning;
    }
}
