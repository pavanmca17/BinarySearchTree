using System;
using System.Collections.Generic;
using System.Linq;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree");
            Console.WriteLine("Please Enter the Starting Value for randoming number genertation Range");
            int startNumber = int.Parse(Console.ReadLine());           
            Console.WriteLine("Please Enter the Ending Value for randoming number genertation Range");
            int endNumber = int.Parse(Console.ReadLine());        
            Random rnd = new Random();
            List<int> numbers = Enumerable.Range(startNumber, endNumber).OrderBy(_ => rnd.Next()).ToList();
          

            Tree tree = new Tree();
            for (int i = 0; i < numbers.Count(); i++)
            {
                tree.Add(numbers[i]);              
            }

            // get refernece to the root node
            var root = tree.ReturnRoot();
            
            //Call to In-Order
            Console.WriteLine("InOrder");
            tree.Inorder(root);

            //Call to Descendingorder
            Console.WriteLine("Descendingorder");
            tree.Descendingorder(root);

            Console.WriteLine("Preorder");
            tree.Preorder(root);

            Console.WriteLine("Postorder");
            tree.Postorder(root);

          
            Console.ReadKey();
        }
    }
}
