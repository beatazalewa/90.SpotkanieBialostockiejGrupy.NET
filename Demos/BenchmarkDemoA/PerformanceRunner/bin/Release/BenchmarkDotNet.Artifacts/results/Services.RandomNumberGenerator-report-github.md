``` ini

BenchmarkDotNet=v0.11.1, OS=Windows 10.0.17134.590 (1803/April2018Update/Redstone4)
Intel Core i9-8950HK CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3324.0


```
|          Method |     Mean |     Error |    StdDev |
|---------------- |---------:|----------:|----------:|
| GetRandomNumber | 7.395 ns | 0.0963 ns | 0.0901 ns |
