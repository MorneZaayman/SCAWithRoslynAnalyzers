// See https://aka.ms/new-console-template for more information
var currentDateTime = DateTime.Now;

if (currentDateTime.DayOfWeek == DayOfWeek.Saturday || currentDateTime.DayOfWeek == DayOfWeek.Sunday)
{
    Console.WriteLine("It is the weekend!");
}
else
{
    Console.WriteLine("It is a week day!");
}