```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4602/23H2/2023Update/SunValley3)
Intel Core i7-10750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2


```
| Method               | Mean          | Error       | StdDev      | Median        | Gen0      | Gen1      | Gen2      | Allocated    |
|--------------------- |--------------:|------------:|------------:|--------------:|----------:|----------:|----------:|-------------:|
| JsonSerialize        |    178.898 μs |   3.5363 μs |   4.7209 μs |    178.340 μs |    8.7891 |         - |         - |      56080 B |
| JsonDeserialize      |    505.797 μs |   9.8411 μs |  26.6059 μs |    496.718 μs |   22.9492 |    5.8594 |         - |     145040 B |
| LINQ_Sum             |      9.554 μs |   0.1827 μs |   0.2103 μs |      9.591 μs |         - |         - |         - |         40 B |
| Parallel_ForEach     |    318.733 μs |   6.3358 μs |  16.4675 μs |    321.223 μs |   15.1367 |    2.9297 |         - |      93526 B |
| GarbageCollectorTest | 13,311.903 μs | 258.7113 μs | 229.3408 μs | 13,264.566 μs | 1718.7500 | 1718.7500 | 1718.7500 | 1048617680 B |
