using ConfigSync;
using Microsoft.Extensions.Configuration;

class Program
{
    static void Main()
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        var sync = new ConfigSynchronizer(config)
            .FromJson("appsettings.json"); //Testing

        var diffs = sync.GetDifferences();
        foreach (var diff in diffs)
        {
            Console.WriteLine($"Difference: {diff.Key} - {diff.Value}");
        }
    }
}