using System;
using System.Text.Json;

namespace NotificationPatterneNetCoreSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var verify = new Verifier().Execute();
            Console.WriteLine(JsonSerializer.Serialize(verify));
        }
    }
}
