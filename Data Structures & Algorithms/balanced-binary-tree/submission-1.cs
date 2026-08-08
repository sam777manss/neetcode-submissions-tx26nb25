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
    public bool isbalanced = true;
    public bool IsBalanced(TreeNode root) {
            TreeBalance(root);
            return isbalanced;
    }

    public int TreeBalance(TreeNode node)
    {
        if (node == null)
            return 0;

        var left = TreeBalance(node.left);
        var right = TreeBalance(node.right);

        if (Math.Abs(left - right) > 1)
            isbalanced = false;
        return 1 + Math.Max(left, right);
    }
}
