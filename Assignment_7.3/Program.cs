// Assignment 7.3.1
Console.WriteLine("----Assignment 7.3.1----");
BinarySearchTree bst = new BinarySearchTree();
bst.AddNode(new TreeNode(15));
bst.AddNode(new TreeNode(7));
bst.AddNode(new TreeNode(20));
bst.AddNode(new TreeNode(10));
bst.AddNode(new TreeNode(14));

string result = (bst.FindVal(10) == null) ? "Node not found" : "Node found!";
Console.WriteLine(result);
result = (bst.FindVal(45) == null) ? "Node not found" : "Node found!";
Console.WriteLine(result);