```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4751/23H2/2023Update/SunValley3)
Intel Core i7-10750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 7.0.20 (7.0.2024.26716), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.20 (7.0.2024.26716), X64 RyuJIT AVX2


```
| Method               | Mean         | Error      | StdDev       | Gen0      | Gen1      | Gen2      | Allocated    |
|--------------------- |-------------:|-----------:|-------------:|----------:|----------:|----------:|-------------:|
| JsonSerialize        |    155.46 μs |   1.706 μs |     1.424 μs |    8.7891 |         - |         - |      55896 B |
| JsonDeserialize      |    441.75 μs |   3.665 μs |     3.249 μs |   22.9492 |    7.3242 |         - |     144856 B |
| LINQ_Sum             |     10.19 μs |   0.176 μs |     0.327 μs |         - |         - |         - |         40 B |
| Parallel_ForEach     |    261.34 μs |   4.986 μs |     4.664 μs |   15.1367 |    3.4180 |         - |      93161 B |
| GarbageCollectorTest | 46,385.27 μs | 925.480 μs | 1,890.511 μs | 1687.5000 | 1687.5000 | 1687.5000 | 1048617674 B |
