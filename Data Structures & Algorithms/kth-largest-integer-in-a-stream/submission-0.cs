public class KthLargest {
    public int k;
    public PriorityQueue<int, int> minHeap;
    public KthLargest(int k, int[] nums) {
        this.k = k;
        this.minHeap = new PriorityQueue<int, int>();
        foreach(int num in nums){
            Add(num);
        }
    }
    
    public int Add(int val) {
        minHeap.Enqueue(val, val);
        if(minHeap.Count > k){
            minHeap.Dequeue();
        }
        return minHeap.Peek();
    }
}
