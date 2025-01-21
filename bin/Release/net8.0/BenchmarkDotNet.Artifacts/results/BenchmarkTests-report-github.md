```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4602/23H2/2023Update/SunValley3)
Intel Core i7-10750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2


```
| Method               | Mean          | Error       | StdDev        | Gen0      | Gen1      | Gen2      | Allocated    |
|--------------------- |--------------:|------------:|--------------:|----------:|----------:|----------:|-------------:|
| JsonSerialize        |    134.235 μs |   2.5946 μs |     3.7212 μs |    8.7891 |         - |         - |      55896 B |
| JsonDeserialize      |    401.864 μs |   6.1218 μs |     8.9732 μs |   22.9492 |    7.3242 |         - |     144888 B |
| LINQ_Sum             |      4.637 μs |   0.0923 μs |     0.1026 μs |         - |         - |         - |         40 B |
| Parallel_ForEach     |    252.845 μs |   4.3778 μs |     3.8808 μs |   15.1367 |    3.4180 |         - |      93046 B |
| GarbageCollectorTest | 46,967.296 μs | 937.2115 μs | 1,914.4749 μs | 1687.5000 | 1687.5000 | 1687.5000 | 1048617663 B |
