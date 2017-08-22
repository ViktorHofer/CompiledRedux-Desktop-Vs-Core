``` ini

BenchmarkDotNet=v0.10.9, OS=Windows 10 Redstone 2 (10.0.15063)
Processor=Intel Core i7-6600U CPU 2.60GHz (Skylake), ProcessorCount=4
Frequency=2742192 Hz, Resolution=364.6718 ns, Timer=TSC
.NET Core SDK=2.0.0
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  Job-SZIPGA : .NET Framework 4.7 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2102.0
  Job-RLJDTR : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT

Jit=RyuJit  Platform=X64  InvocationCount=1  
LaunchCount=1  TargetCount=3  UnrollFactor=1  
WarmupCount=1  

```
 | Method | Runtime |  Toolchain |    Mean |    Error |   StdDev |       Gen 0 |      Gen 1 |      Gen 2 |  Allocated |
 |------- |-------- |----------- |--------:|---------:|---------:|------------:|-----------:|-----------:|-----------:|
 |     Do |     Clr |    Default | 16.23 s |  8.862 s | 0.5007 s | 386666.6667 | 66000.0000 | 11000.0000 | 2972.99 MB |
 |     Do |    Core | CoreCsProj | 31.58 s | 16.680 s | 0.9425 s | 387666.6667 | 67000.0000 | 12666.6667 |   356.5 MB |
