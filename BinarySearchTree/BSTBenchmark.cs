using BenchmarkDotNet.Attributes;
using BinarySearchTree;
using System;
using System.Collections.Generic;
using System.Linq;

public class BSTBenchmark
{
   
    private static readonly Tree treeProcess = new Tree();

    [Benchmark]
    public void Benchmark()
    {
        int startNumber = 10;
        int endNumber = 20;
        Random rnd = new Random();
        List<int> numbers = Enumerable.Range(startNumber, endNumber).OrderBy(_ => rnd.Next()).ToList();
                
        for (int i = 0; i < numbers.Count(); i++)
        {
            treeProcess.Add(numbers[i]);
        }

        var root = treeProcess.ReturnRoot();
        treeProcess.Inorder(root);
    }
}