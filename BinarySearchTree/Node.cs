using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
      
        public int Value { get; set; }

        public Node left { get; set; }

        public Node right { get; set; }

        public Node(int val)
        {
            Value = val;
            left = null;
            right = null;

        }

    }
}
