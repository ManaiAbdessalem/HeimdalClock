using ClockServices;
using Microsoft.Extensions.DependencyInjection;

var builder = new ServiceCollection()
    .AddScoped<IClockService, ClockService>()
    .BuildServiceProvider();

IClockService clockService = builder.GetService<IClockService>();

Console.WriteLine("Give hour:");

bool isNumeric = int.TryParse(Console.ReadLine(), out int hour);
if (!isNumeric || hour < 0)
{
    Console.WriteLine($"the hour input must be a positive number");
    Console.ReadLine();
    return;
}

Console.WriteLine("Give minutes:");

isNumeric = int.TryParse(Console.ReadLine(), out int minute);
if (!isNumeric || minute < 0)
{
    Console.WriteLine($"the minute input must be a positive number");
    Console.ReadLine();
    return;
}
Console.WriteLine($"Angle: {clockService.GetClockAngle(hour, minute)}");
Console.ReadLine();