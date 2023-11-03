```

BenchmarkDotNet v0.13.8, macOS Sonoma 14.0 (23A344) [Darwin 23.0.0]
Apple M1 Pro, 1 CPU, 10 logical and 10 physical cores
.NET SDK 7.0.306
  [Host]     : .NET 7.0.9 (7.0.923.32018), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 7.0.9 (7.0.923.32018), Arm64 RyuJIT AdvSIMD


```
| Method     | Mean     | Error    | StdDev   | Gen0   | Allocated |
|----------- |---------:|---------:|---------:|-------:|----------:|
| SortString | 22.75 ns | 0.052 ns | 0.047 ns | 0.0127 |      80 B |
| HashString | 62.47 ns | 0.090 ns | 0.075 ns | 0.0408 |     256 B |
