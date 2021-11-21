using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunBSTBenchmark();
            CreateandRunBST();
            Console.ReadKey();
        }

        private static void RunBSTBenchmark()
        {
            var summary = BenchmarkRunner.Run<BSTBenchmark>();
        }

        private static void CreateandRunBST()
        {
            Console.WriteLine("Binary Search Tree");
            Console.WriteLine("Please Enter the Starting Offset for random number genertation");
            int startNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Number of elements(Range) for random number genertation");
            int endNumber = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            List<int> numbers = Enumerable.Range(startNumber, endNumber).OrderBy(_ => rnd.Next()).ToList();


            // TimeSpan timeSpan = new TimeSpan();

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

            //Call to Preorder
            Console.WriteLine("Preorder");
            tree.Preorder(root);

            //Call to Postorder
            Console.WriteLine("Postorder");
            tree.Postorder(root);


            Console.ReadKey();
        }
    }
}
