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
    public int MaxDepth(TreeNode root) {
        return MaxDepthFunc(root, 0);
    }

    public int MaxDepthFunc(TreeNode root, int depth) {
        if (root == null) return depth;
        depth++;
        int leftDepth = MaxDepthFunc(root.left, depth);
        int rightDepth = MaxDepthFunc(root.right, depth);
        depth = Math.Max(leftDepth, rightDepth);
        return depth;
    }
}
