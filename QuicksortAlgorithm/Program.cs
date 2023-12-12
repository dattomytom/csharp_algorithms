// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using QuickSort;
using System.Linq;

Console.WriteLine("Hello, World!");
//for(int i=0; i< QuickSort.QuickSortMethods.SampleArrays().ToList().Count; i++)
//{
//    QuickSortMethods.ReadArray(QuickSortMethods.SampleArrays().ToList()[i]);
//}
var summary = BenchmarkRunner.Run<QuickSortMethods>();