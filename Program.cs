
using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Jobs;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
[MemoryDiagnoser] 
public class Program
{
    static void Main(string[] args)
    {
        
        BenchmarkRunner.Run<BenchmarkTests>();
    }
}

[MemoryDiagnoser] 
public class BenchmarkTests
{
    private List<Data> testData;

    public BenchmarkTests()
    {
        
        testData = new List<Data>();
        for (int i = 0; i < 1000; i++)
        {
            testData.Add(new Data { Id = i, Name = $"Item{i}" });
        }
    }

    [Benchmark]
    public string JsonSerialize()
    {
        return JsonSerializer.Serialize(testData);
    }

    [Benchmark]
    public List<Data> JsonDeserialize()
    {
        var json = JsonSerializer.Serialize(testData);
        return JsonSerializer.Deserialize<List<Data>>(json);
    }

    [Benchmark]
    public int LINQ_Sum()
    {
        return testData.Sum(item => item.Id);
    }

    [Benchmark]
    public List<Data> Parallel_ForEach()
    {
        var result = new List<Data>();
        object lockObj = new object();

        Parallel.ForEach(testData, item =>
        {
            lock (lockObj)
            {
                result.Add(new Data { Id = item.Id, Name = item.Name.ToUpper() });
            }
        });

        return result;
    }

    [Benchmark]
    public void GarbageCollectorTest()
    {
        var garbageData = new List<byte[]>();
        for (int i = 0; i < 1000; i++)
        {
            garbageData.Add(new byte[1024 * 1024]); 
        }
        garbageData.Clear();
        GC.Collect();
    }
}

public class Data
{
    public int Id { get; set; }
    public string Name { get; set; }
}
