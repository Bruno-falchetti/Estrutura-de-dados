using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trees;

Console.WriteLine("Agora com arvores");

TreeNode<int> tree = new TreeNode<int>();
tree.Root = new TreeNode<int> { Data = 100 };

tree.Root.Children = new List<TreeNode<int>>(){
new tree.TreeNode<int> { Data = 50, Parent = tree.Root };
new tree.TreeNode<int> { Data = 1, Parent = tree.Root };
new tree.TreeNode<int> { Data = 150, Parent = tree.Root };
};

tree.Root.Children[2].Children = new List<TreeNode<int>>()
{
    new tree.TreeNode<int> { Data = 30, Parent = tree.Root.Children[2] };
    new tree.TreeNode<int> { Data = 5, Parent = tree.Root.Children[2] };
    new tree.TreeNode<int> { Data = 11, Parent = tree.Root.Children[2] };

};
tree.Root.Children[3].Children = new List<TreeNode<int>>()
{
    new tree.TreeNode<int> { Data = 70, Parent = tree.Root.Children[3] };
    new tree.TreeNode<int> { Data = 61, Parent = tree.Root.Children[3] };
};