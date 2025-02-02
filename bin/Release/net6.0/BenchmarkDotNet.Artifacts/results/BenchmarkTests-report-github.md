```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4751/23H2/2023Update/SunValley3)
Intel Core i7-10750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2


```
| Method               | Mean          | Error       | StdDev      | Median        | Gen0      | Gen1      | Gen2      | Allocated    |
|--------------------- |--------------:|------------:|------------:|--------------:|----------:|----------:|----------:|-------------:|
| JsonSerialize        |    172.426 μs |   2.3184 μs |   2.1686 μs |    172.014 μs |    8.7891 |         - |         - |      56080 B |
| JsonDeserialize      |    497.833 μs |   8.1827 μs |  10.0491 μs |    498.285 μs |   22.4609 |    5.8594 |         - |     145041 B |
| LINQ_Sum             |      9.581 μs |   0.1438 μs |   0.1274 μs |      9.560 μs |         - |         - |         - |         40 B |
| Parallel_ForEach     |    329.658 μs |   7.2418 μs |  21.3527 μs |    335.900 μs |   15.1367 |    3.4180 |         - |      93834 B |
| GarbageCollectorTest | 13,628.627 μs | 266.6509 μs | 346.7215 μs | 13,589.010 μs | 1718.7500 | 1718.7500 | 1718.7500 | 1048617651 B |
