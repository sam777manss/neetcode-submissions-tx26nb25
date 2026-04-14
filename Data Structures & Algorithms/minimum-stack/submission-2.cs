    public class MinStack
    {
        public List<int> array = new();
        public MinStack()
        {
            //array = new List<int>() { 1, 2, 3, 4, 5 };
        }

        public void Push(int val)
        {
            array.Add(val);
        }

        public void Pop()
        {
            if (array.Count > 0)
            {
                array.RemoveAt(array.Count - 1);
            }
        }

        public int Top()
        {
            //var top1 = array.LastOrDefault();
            var top = array.Count != 0 ? array[^1] : default;
            return top;
        }

        public int GetMin()
        {
            var Min = array.Min();
            return Min;
        }
    }