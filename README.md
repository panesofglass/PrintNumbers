# PrintNumbers

## Requirements

| #  | Requirement | Change # |
| -: | :---------- | -------: |
| 1  | Print the numbers from 1 to 100 | |
| 2  | For numbers evenly divisible by 3, print Ryan | |
| 3  | For numbers evenly divisible by 5, print Riley | |
| 4  | For numbers evenly divisible by both 3 and 5, print RyanRiley | |
| 5  | Each number should print on its own line | |
| 6  | Allow the caller to specify a different upper bound, e.g. 1 .. n | 1 |
| 7  | Create a library that can be consumed in other .NET applications | 2 |
| 8  | Verify the behavior with tests | 2 |
| 9  | Allow caller to pass an arbitrary number (0-n) of number/word pairs | 3 |
| 10 | Number should be tested for even divisibility | 3 |
| 11 | Order of passed pairs should be used to determine precedence | 3 |
| 12 | Rules should compose, e.g. rules for 2 and 3 should both apply for the 6th item | 3 |

## Build and Run

```powershell
dotnet build
dotnet test
# Specify -- $upperBound to print something other than 100 numbers
dotnet run --project sample\PrintNumbers [-- $upperBound]
```

## Design Considerations

The library should expose a single, public method that accepts an optional `upperBound` parameter and an ordered list of rules, which could also be optional.
The requirement to retain input order suggests a data structure that retains the original order of items.
Any of `(TDivisor, TName)[]`, `List<(TDivisor, TName)>`,  or `OrderedDictionary` would work, though the latter would require additional work.
An `IReadOnlyDictionary<TDivisor, TName>` would more clearly communicate and ensure the dictionary was not modified but would not guarantee the order.
For this exercise, I'm choosing to go with the clearer communication over guaranteeing order, which should be retained while executing.
This should leave guarantees about the order of rules to the caller.

The iteration uses `int`, or `Int32`, which would allow an upper bound of a little more than 2 billion values.
This could be doubled with a `UInt32` since we don't need negative numbers.
Additional iteration can be reached with `UInt64`` or `BigInteger`, if necessary.

## Additional Notes

I marked one test to skip as it verifies iteration to `Int32.MaxValue`, which takes approx. 3 minutes on my machine.
This test should verify the max allowed iteration length based on the current implementation.
Feel free to remove the `Skip` to run the test.

