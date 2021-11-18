using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
      
        public int value { get; set; }

        public Node left { get; set; }

        public Node right { get; set; }

        public Node(int val)
        {
            value = val;
            left = null;
            right = null;

        }

    }
}
