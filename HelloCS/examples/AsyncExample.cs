using System;
using System.Net.Http;
using System.Threading.Tasks;

public static class AsyncExample
{
    public static async Task Run()
    {
        using var http = new HttpClient();
        var urls = new[] { "https://example.com", "https://example.org" };

        Console.WriteLine("Starting downloads...");
        var tasks = new Task<string>[urls.Length];
        for (int i = 0; i < urls.Length; i++)
            tasks[i] = http.GetStringAsync(urls[i]);

        var results = await Task.WhenAll(tasks);
        for (int i = 0; i < results.Length; i++)
            Console.WriteLine($"{urls[i]} length: {results[i].Length}");
    }
}
