class BinarySearchTree
{
    public TreeNode? root;
    private int height;

    public BinarySearchTree(TreeNode root)
    {
        this.root = root;
        height = 1;
    }

    public BinarySearchTree()
    {
        root = null;
        height = 0;
    }

    private int GetHeight(TreeNode? node)
    {
        if (node == null) return 0;
        else return Math.Max(GetHeight(node.left), GetHeight(node.right)) + 1;
    }

    public void AddNode(TreeNode node) {
        Console.WriteLine($"Adding {node.val} to tree...");
        if(root == null)
        {
            root = node;
            return;
        }
        TreeNode? checkNode = root;
        while (checkNode != null) {
            if(node.val <= checkNode.val)
            {
                if(checkNode.left != null)
                {
                    checkNode = checkNode.left;
                    continue;
                }
                checkNode.left = node;
                return;
            } else
            {
                if(checkNode.right != null)
                {
                    checkNode = checkNode.right;
                    continue;
                }
                checkNode.right = node;
                return;
            }
        }

    }

    public TreeNode? FindVal(int n)
    {
        Console.WriteLine($"Searching for {n}...");
        if (root == null) return null;
        TreeNode? checkNode = root;
        while (checkNode != null)
        {
            if(checkNode.val == n) return checkNode;
            checkNode = (n <= checkNode.val) ? checkNode.left : checkNode.right;
        }
        return null;
       
    }
}

