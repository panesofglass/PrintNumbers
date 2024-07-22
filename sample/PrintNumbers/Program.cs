// See https://aka.ms/new-console-template for more information
using PrintNumbersLib;

// Try to parse any initial parameter as an integer to use as an upper bound.
// If no parameter is provided or it cannot be parsed as an integer, use the default of 100.
int upperBound = args.Length > 0 && int.TryParse(args[0], out upperBound) ? upperBound : 100;

// Retrieve the enumerable sequence of formatted values for the range 1 .. upperBound.
var values = PrintNumbers.All(upperBound);

// Print each value on its own line.
foreach (var value in values)
{
    Console.WriteLine(value);
}

