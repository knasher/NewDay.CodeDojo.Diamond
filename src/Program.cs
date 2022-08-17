using NewDay.CodeDojo.Diamond;

if (args.Length == 0)
{
    Console.WriteLine("No argument provided, please specify letter (A-Z)");
    return;
}

try
{
    Console.WriteLine(new Diamond(args[0].ToCharArray().First()).Print());
}
catch (ArgumentOutOfRangeException)
{
    Console.WriteLine("Argument not accepted, please specify letter (A-Z)");
}