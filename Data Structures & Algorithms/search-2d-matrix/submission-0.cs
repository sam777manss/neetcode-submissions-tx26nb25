public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
            List<int> arryInt = new List<int>();
            foreach(var rowData in matrix)
            {
                foreach (var item in rowData)
                {
                    arryInt.Add(item);
                }
            }

            int left = 0, right = arryInt.Count - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arryInt[mid] == target)
                    return true;
                else if (arryInt[mid] > target)
                    right = mid - 1;
                else if (arryInt[mid] < target)
                    left = mid + 1;
            }
            return false;
    }
}
