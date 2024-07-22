// See https://aka.ms/new-console-template for more information
using PrintNumbersLib;

var values = PrintNumbers.All(100);

foreach (var value in values)
{
    Console.WriteLine(value);
}

