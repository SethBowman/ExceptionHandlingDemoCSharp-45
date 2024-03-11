using System.Reflection;

var numbers = new int[] { 1, 2, 3, 4, 5 };

//try-catch block

try
{
    //try to do something
    Console.WriteLine(numbers[5]);
}
catch (IndexOutOfRangeException e)
{
    //if we are thrown an exception, we catch it
    Console.WriteLine($"That was not an index that exists. {e.Message}");
}
catch (Exception e)
{
    //umbrella catch, catches all errors we may have missed
    Console.WriteLine(e.Message);
}

Console.WriteLine("Continue on..");

try
{
    Console.WriteLine("Please give me a number:");

    var userNumber = int.Parse(Console.ReadLine());

    Console.WriteLine(userNumber);
}
catch(FormatException e)
{
    Console.WriteLine($"Failed to parse. {e.Message}");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    //optional
    //the finally block happens no matter what
    Console.WriteLine("Happnes no matter what");
}

Console.WriteLine("Continue on..");

var strNumbers = new string[] { "12", "2", "twelve", "88", "ten", "100", "five", "fifty", "333" };
var realNumbers = new List<int>();


foreach(var number in strNumbers)
{
    try
    {
        var parsedNumber = int.Parse(number);
        realNumbers.Add(parsedNumber);
    }
    catch(FormatException e)
    {
        Console.WriteLine($"Could not parse {number}. {e.Message}");
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

Console.WriteLine("Parsed Numbers:");

foreach(var number in realNumbers)
{
    Console.WriteLine(number);
}


