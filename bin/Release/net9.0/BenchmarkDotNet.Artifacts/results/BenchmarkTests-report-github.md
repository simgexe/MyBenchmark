```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4602/23H2/2023Update/SunValley3)
Intel Core i7-10750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2


```
| Method               | Mean          | Error       | StdDev        | Gen0      | Gen1      | Gen2      | Allocated    |
|--------------------- |--------------:|------------:|--------------:|----------:|----------:|----------:|-------------:|
| JsonSerialize        |    117.500 μs |   2.3479 μs |     4.1122 μs |    8.7891 |         - |         - |      55896 B |
| JsonDeserialize      |    314.206 μs |   3.8414 μs |     3.2078 μs |   22.4609 |    6.8359 |         - |     144889 B |
| LINQ_Sum             |      4.555 μs |   0.0364 μs |     0.0323 μs |         - |         - |         - |         40 B |
| Parallel_ForEach     |    249.908 μs |   4.6687 μs |     4.1387 μs |   15.1367 |    3.4180 |         - |      93149 B |
| GarbageCollectorTest | 46,632.072 μs | 926.0149 μs | 1,739.2806 μs | 1687.5000 | 1687.5000 | 1687.5000 | 1048617645 B |
