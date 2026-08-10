/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {    
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        // subRoot is empty → it is considered a subtree
            if (subRoot == null)
                return true;

            // root is empty but subRoot isn't
            if (root == null)
                return false;

            // If values match, check whether the ENTIRE trees match
            if (root.val == subRoot.val && IsSameTree(root, subRoot))
                return true;

            // Otherwise, search left and right
            return IsSubtree(root.left, subRoot) ||
                IsSubtree(root.right, subRoot);   
    }

        private bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;

            if (p == null || q == null)
                return false;

            if (p.val != q.val)
                return false;

            return IsSameTree(p.left, q.left) &&
                   IsSameTree(p.right, q.right);
        }
}
