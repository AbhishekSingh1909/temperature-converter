using System.Text.RegularExpressions;
using TemperatureConverter.src;

var input = "";

Console.WriteLine(" \r\t Convert Temprature  ");
Console.WriteLine("1. Enter valid temprature vlaue in format '{degree} {C|F}'.");
Console.WriteLine("2. Enete exit to stop the applcation");
do
{
    var pattern = @"^-?\.?\d+\.?\d*\s[CF]$";
    Console.WriteLine("Please enter a temperature value and its unit of measurement (F or C):");
    input = Console.ReadLine();
    if (input == "exit")
    {
        break;
    }
    
    var match = Regex.IsMatch(input??"", pattern);
    if (match)
    {
        var result = ConvertTemprature.TempConvert(input ?? "");
        Console.WriteLine($"{input} = {result}");
    }
    else {
        Console.Write("Invalid input. ");
    }
    
} while (true);
Console.WriteLine("Program terminated");
Environment.Exit(0);


