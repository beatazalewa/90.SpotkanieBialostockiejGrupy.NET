``` ini

BenchmarkDotNet=v0.11.1, OS=Windows 10.0.17134.285 (1803/April2018Update/Redstone4)
Intel Core i9-8950HK CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
  [Host]       : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3163.0
  LegacyJitX86 : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3163.0
  RyuJitX64    : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3163.0

Runtime=Clr  

```
|     Method |          Job |       Jit | Platform |          Mean |      Error |     StdDev |        Median |
|----------- |------------- |---------- |--------- |--------------:|-----------:|-----------:|--------------:|
| EmptyArray | LegacyJitX86 | LegacyJit |      X86 |     0.0924 ns |  0.0453 ns |  0.1137 ns |     0.0378 ns |
| EightBytes | LegacyJitX86 | LegacyJit |      X86 |     2.5573 ns |  0.1122 ns |  0.2916 ns |     2.5384 ns |
|   SomeLinq | LegacyJitX86 | LegacyJit |      X86 | 1,217.0330 ns | 24.2021 ns | 61.6020 ns | 1,212.2022 ns |
| EmptyArray |    RyuJitX64 |    RyuJit |      X64 |     0.0088 ns |  0.0201 ns |  0.0331 ns |     0.0000 ns |
| EightBytes |    RyuJitX64 |    RyuJit |      X64 |     2.9908 ns |  0.1281 ns |  0.3756 ns |     2.8523 ns |
|   SomeLinq |    RyuJitX64 |    RyuJit |      X64 | 1,118.5837 ns | 21.9018 ns | 39.4935 ns | 1,114.2790 ns |
