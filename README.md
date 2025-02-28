﻿# 📌 Benchmark Tests - .NET Performance Analysis

This project uses **BenchmarkDotNet** to analyze the performance of various operations, including **JSON serialization, LINQ operations, parallel loops, and memory management** across different **.NET versions (6, 7, 8, 9)**.

---

## 🚀 Technologies Used

- **.NET Core / .NET 6+ / .NET 7+ / .NET 8+ / .NET 9+**
- **BenchmarkDotNet** (For performance benchmarking)
- **System.Text.Json** (For JSON serialization/deserialization)
- **LINQ** (For data operations)
- **Parallel.ForEach** (For parallel processing)
- **Garbage Collector (GC)** (For memory management)

---

## 📂 Project Structure

```
/BenchmarkProject
│── BenchmarkTests.cs  # Benchmark methods
│── Program.cs         # Main file to run the tests
│── Data.cs            # Data class for testing
│── README.md          # Project documentation
│── BenchmarkProject.csproj # .NET project file
```

---

## ⚡ Benchmark Tests

This project performs the following tests:

| Test Name            | Description |
|---------------------|-------------|
| `JsonSerialize`     | Converts a `List<Data>` object **to JSON format**. |
| `JsonDeserialize`   | Converts a JSON string **back to a list of objects**. |
| `LINQ_Sum`         | Uses **LINQ** to calculate the sum of all ID values. |
| `Parallel_ForEach`  | Uses `Parallel.ForEach` to **convert all item names to uppercase**. |
| `GarbageCollectorTest` | **Allocates memory** and then calls **GC.Collect() to trigger garbage collection**. |

---

## 🔄 Comparing .NET Versions

This benchmark aims to compare performance differences across **.NET 6, 7, 8, and 9**. To achieve this, update the **target framework** in the project file (`BenchmarkProject.csproj`):

1. Open `BenchmarkProject.csproj`
2. Modify the `<TargetFramework>` element:

   ```xml
   <TargetFramework>net6.0</TargetFramework>  <!-- Change this to net7.0, net8.0, or net9.0 -->
   ```
3. Restore dependencies and rerun the benchmarks.

```sh
dotnet restore
dotnet run -c Release
```

---

## 💻 How to Run the Tests

### 1️⃣ Clone the Repository and Install Dependencies

First, clone this project to your local machine and restore dependencies:

```sh
git clone https://github.com/simgexe/MyBenchmark.git
cd MyBenchmark
dotnet restore
```

### 2️⃣ Run the Benchmark Tests

To start the benchmark tests, run the following command:

```sh
dotnet run -c Release
```

> ⚠️ **BenchmarkDotNet requires running in 'Release' mode for accurate results.**

Once the tests are complete, **BenchmarkDotNet** will display the results in the console.

---

## 📊 Sample Benchmark Results

```sh
| Method             | Mean      | Allocated |
|-------------------|----------|----------|
| JsonSerialize    | 5.214 ms  | 123 KB   |
| JsonDeserialize  | 7.892 ms  | 140 KB   |
| LINQ_Sum         | 0.334 ms  | 0 KB     |
| Parallel_ForEach | 10.152 ms | 500 KB   |
| GarbageCollectorTest | 3.124 ms | 1024 KB |
```


