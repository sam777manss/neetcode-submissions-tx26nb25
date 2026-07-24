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
    public static int diameter = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        diameter = 0;
        Height(root);      // compute heights and update diameter
        return diameter;   // return diameter
    }
    private int Height(TreeNode root)
    {
        if (root == null)
            return 0;

        int left = Height(root.left);
        int right = Height(root.right);

        diameter = Math.Max(diameter, left + right);

        return 1 + Math.Max(left, right);
    }
}
