``` ini

BenchmarkDotNet=v0.11.1, OS=Windows 10.0.17134.590 (1803/April2018Update/Redstone4)
Intel Core i9-8950HK CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3324.0


```
|                    Method |      Mean |     Error |    StdDev |    Median |
|-------------------------- |----------:|----------:|----------:|----------:|
|          SumUsingForLoops |  72.70 ms |  1.466 ms |  3.368 ms |  71.43 ms |
| SumUsingForLoopsAndString | 110.68 ms |  1.435 ms |  1.272 ms | 110.69 ms |
|              SumUsingLinq | 639.46 ms | 12.647 ms | 29.312 ms | 630.66 ms |
