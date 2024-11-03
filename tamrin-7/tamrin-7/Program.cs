using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


var input = Console.ReadLine();
         
var matn = @"\b0\d{9}\b";

var matches = Regex.Matches(input, matn);
var validNumbers = new List<string>();

foreach (Match match in matches)
{
    var number = match.Value;

    var distinctDigits = new HashSet<char>(number);
    if (distinctDigits.Count > 1)
    {
        validNumbers.Add(number);
    }
}
        
        
Console.WriteLine("Valid phone numbers:");
foreach (var number in validNumbers)
{
    Console.WriteLine(number);
}

