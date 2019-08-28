## ORM Benchmark

This is a simple benchmark to compare ORMs, initial version compares `Insight.Database`, `Dapper` and `ADO.net`

## Latest Results

``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.18362
Intel Core i7 CPU 860 2.80GHz (Nehalem), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.1.801
  [Host]     : .NET Core 2.1.12 (CoreCLR 4.6.27817.01, CoreFX 4.6.27818.01), 64bit RyuJIT
  Job-QXVGCB : .NET Core 2.1.12 (CoreCLR 4.6.27817.01, CoreFX 4.6.27818.01), 64bit RyuJIT

InvocationCount=100  IterationCount=5  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
|           Method |     Mean |     Error |    StdDev | Rank |
|----------------- |---------:|----------:|----------:|-----:|
|  Dapper_GetUsers | 1.621 ms | 0.3148 ms | 0.0818 ms |    1 |
| Insight_GetUsers | 1.655 ms | 0.3453 ms | 0.0897 ms |    1 |
|     ADO_GetUsers | 1.842 ms | 0.1283 ms | 0.0333 ms |    2 |
