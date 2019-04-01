using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Ynab.Net.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            string accessToken = configuration.GetSection("personal-access-token").Value;
            YnabClient client = new YnabClient(new AccessToken(accessToken));
            string response = client.GetUser().Result;
            Console.WriteLine(response);

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}
