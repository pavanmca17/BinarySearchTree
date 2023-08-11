using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Tree
    {
        public Node top;
        public Tree()
        {
            top = null;
        }

        public Tree(int initval)
        {
            top = new Node(initval);
        }

        public void Add(int value)
        {
            //non-recursive add
            if(top ==  null)
            {

                Node newNode = new Node(value);
                top = newNode;
                return;
            }


            Node currentNode = top;
            bool isadded = false;
            do
            {
                // If value to be inserted is less than currentnodes value 
                if (value < currentNode.value)
                {
                    // go left
                    // Check if left node of current node is null
                    // if so insert the new node 
                    if(currentNode.left == null)
                    {
                        Node newNode = new Node(value);
                        currentNode.left = newNode;
                        isadded = true;
                    }
                    // if left node of current node is not null 
                    // assign point currnode to its left subtree
                    else
                    {
                        currentNode = currentNode.left;
                    }
                }

                // If value to be inserted is grater than currentnodes value 
                if (value >= currentNode.value)
                {
                    // go right
                    // Check if right node of current node is null
                    // if so insert the new node 
                    if (currentNode.right == null)
                    {
                        Node newNode = new Node(value);
                        currentNode.right = newNode;
                        isadded = true;
                    }
                    // if right node of current node is not null 
                    // assign point currnode to its right subtree
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }
              // loop thru till element is added - checked used isadded flag
            } while (!isadded);
              
        }

        public Node ReturnRoot()
        {
            return top;
        }

        //An inorder traversal visits all the nodes in a BST in ascending order
        //of the node key values.
        // Display the elements in ascending order
        public void Inorder(Node Root)
        {
            if (Root != null)
            {
                Inorder(Root.left);
                Console.WriteLine(Root.value + " ");
                Inorder(Root.right);
            }
        }

        //preorder traversal visits the root node first,
        //followed by the nodes in the subtrees under the left child of the root,
        //followed by the nodes in the subtrees under the right child of the root
        public void Preorder(Node Root)
        {
            if (Root != null)
            {
                Console.WriteLine(Root.value + " ");
                Preorder(Root.left);
                Preorder(Root.right);
            }
        }

        //A postorder traversal,
        //the method first recurses over the left subtrees and then over the right subtrees.
        public void Postorder(Node Root)
        {
            if (Root != null)
            {
                Postorder(Root.left);
                Postorder(Root.right);
                Console.WriteLine(Root.value + " ");
            }
        }

        // Display the BST Elements in descending order 
        public void Descendingorder(Node Root)
        {
            if (Root != null)
            {
                Descendingorder(Root.right);
                Console.WriteLine(Root.value + " ");
                Descendingorder(Root.left);
                
            }
        }

        public void flatten(Node node)
        {
            // return if root is null
            if (node == null)
                return;

            // if it is a leaf node
            if (node.left == null &&  node.right == null)
                return;
        }

    }
}
