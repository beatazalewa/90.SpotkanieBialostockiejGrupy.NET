``` ini

BenchmarkDotNet=v0.11.1, OS=Windows 10.0.17134.590 (1803/April2018Update/Redstone4)
Intel Core i9-8950HK CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
  [Host]       : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3324.0
  LegacyJitX86 : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3324.0
  RyuJitX64    : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0

Runtime=Clr  

```
|          Method |          Job |       Jit | Platform |        Mean |      Error |     StdDev |      Median |  Gen 0 | Allocated |
|---------------- |------------- |---------- |--------- |------------:|-----------:|-----------:|------------:|-------:|----------:|
|      EmptyArray | LegacyJitX86 | LegacyJit |      X86 |   0.1022 ns |  0.0580 ns |  0.0886 ns |   0.0905 ns |      - |       0 B |
|      EightBytes | LegacyJitX86 | LegacyJit |      X86 |   3.3369 ns |  0.2827 ns |  0.8156 ns |   3.2129 ns | 0.0038 |      20 B |
| SimpleLinqQuery | LegacyJitX86 | LegacyJit |      X86 | 715.5248 ns | 13.2697 ns | 12.4125 ns | 721.8456 ns | 0.0486 |     256 B |
|      EmptyArray |    RyuJitX64 |    RyuJit |      X64 |   0.1745 ns |  0.0512 ns |  0.0427 ns |   0.1724 ns |      - |       0 B |
|      EightBytes |    RyuJitX64 |    RyuJit |      X64 |   2.5845 ns |  0.1757 ns |  0.5127 ns |   2.4090 ns | 0.0051 |      32 B |
| SimpleLinqQuery |    RyuJitX64 |    RyuJit |      X64 | 624.4960 ns | 12.2310 ns | 14.5601 ns | 624.0734 ns | 0.0601 |     384 B |
