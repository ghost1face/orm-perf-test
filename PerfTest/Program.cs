using BenchmarkDotNet.Running;
using System;

namespace PerfTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ORMTests>();
        }
    }
}
