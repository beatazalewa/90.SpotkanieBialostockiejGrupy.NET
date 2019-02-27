``` ini

BenchmarkDotNet=v0.11.1, OS=Windows 10.0.17134.285 (1803/April2018Update/Redstone4)
Intel Core i9-8950HK CPU 2.90GHz (Max: 1.50GHz), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3163.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3163.0


```
| Method | Number |      Mean |     Error |    StdDev |
|------- |------- |----------:|----------:|----------:|
| **Square** |      **1** | **0.0168 ns** | **0.0217 ns** | **0.0275 ns** |
| **Square** |      **2** | **0.0500 ns** | **0.0386 ns** | **0.0502 ns** |
