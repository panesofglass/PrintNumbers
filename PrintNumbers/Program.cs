// See https://aka.ms/new-console-template for more information
using PrintNumbersLib;

var values = PrintNumbers.All(int.MaxValue);

foreach (var value in values)
{
    Console.WriteLine(value);
}

