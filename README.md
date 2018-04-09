# LazyLogging

``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.309 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i5-4690 CPU 3.50GHz (Haswell), 1 CPU, 4 logical and 4 physical cores
Frequency=3410078 Hz, Resolution=293.2484 ns, Timer=TSC
  [Host]     : .NET Framework 4.7.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2633.0
  DefaultJob : .NET Framework 4.7.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2633.0


```
|        Method |       Mean |     Error |    StdDev |     Gen 0 | Allocated |
|-------------- |-----------:|----------:|----------:|----------:|----------:|
| DirectLogging | 956.573 us | 4.6295 us | 3.8659 us | 2550.7813 | 8035099 B |
|   LazyLogging |   4.379 us | 0.0191 us | 0.0170 us |         - |       0 B |
