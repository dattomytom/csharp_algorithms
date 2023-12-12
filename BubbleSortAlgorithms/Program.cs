﻿using BenchmarkDotNet.Running;
using BubbleSortAlgorithms;

Console.WriteLine("Hello, World!");
var summary = BenchmarkRunner.Run<BubbleSortMethods>();

