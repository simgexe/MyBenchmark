```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4602/23H2/2023Update/SunValley3)
Intel Core i7-10750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 7.0.20 (7.0.2024.26716), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.20 (7.0.2024.26716), X64 RyuJIT AVX2


```
| Method               | Mean         | Error      | StdDev     | Gen0      | Gen1      | Gen2      | Allocated    |
|--------------------- |-------------:|-----------:|-----------:|----------:|----------:|----------:|-------------:|
| JsonSerialize        |    157.49 μs |   3.074 μs |   3.417 μs |    8.7891 |         - |         - |      55896 B |
| JsonDeserialize      |    443.51 μs |   8.214 μs |   7.684 μs |   22.9492 |    7.3242 |         - |     144856 B |
| LINQ_Sum             |     10.25 μs |   0.201 μs |   0.319 μs |         - |         - |         - |         40 B |
| Parallel_ForEach     |    268.14 μs |   4.322 μs |   3.609 μs |   15.1367 |    3.4180 |         - |      93259 B |
| GarbageCollectorTest | 43,884.69 μs | 667.420 μs | 591.650 μs | 1687.5000 | 1687.5000 | 1687.5000 | 1048618160 B |
