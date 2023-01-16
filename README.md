# String Concatenation Performance

Strings and string concatenation is one of the most used concepts in software development 
([C# Guide](https://learn.microsoft.com/en-us/dotnet/csharp/how-to/concatenate-multiple-strings)).

## String literals
   Concatenation of literals is performed at compile-time, not run-time.
   So, when we use plus operator, there's no run-time performance cost regardless of the number of strings involved.
   
   [Benchmark source code](Benchmarks/StringLiteralsBenchmark.cs)

|                 Method |        Mean | Ratio |   Gen0 | Allocated | Alloc Ratio |
|----------------------- |------------:|------:|-------:|----------:|------------:|
|          Plus operator |   0.0047 ns | 0.000 |      - |         - |        0.00 |
| One-line (Hard to read)|   0.0218 ns | 0.000 |      - |         - |        0.00 |
|    Raw string literals |   0.0061 ns | 0.000 |      - |         - |        0.00 |
|          `string.Join` | 356.1937 ns | 1.000 | 0.3190 |    1336 B |        1.00 |
|        `string.Concat` | 482.1497 ns | 1.354 | 0.3500 |    1464 B |        1.10 |

`string.Join` and `string.Concat` aren't sutable for string literals concatenation, and must be avoided. 

The best one is [Raw string literals](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11#raw-string-literals) that intrduced in C# 11. It's more readable than `+` operator and also, easier to edit.


## String formatting
- Small length
 
- Medium length

- Long length

## Culture in string formatting 


## `string.Join` vs `string.Concat`

