public class Solution {
    public int LastStoneWeight(int[] stones) {
        var stonesList = new PriorityQueue<int, int>();
        foreach (int st in stones)
        {
            stonesList.Enqueue(st, -st);
        }

        while(stonesList.Count > 1)
        {
            var y = stonesList.Dequeue();
            var x = stonesList.Dequeue();

            if (x < y)
                stonesList.Enqueue(y - x, -(y - x));
        }
        return stonesList.Count == 1 ? stonesList.Dequeue() : 0; 
    }
}
