using System;
using System.Threading.Tasks;

namespace Ynab.Net.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string accessToken = "be3c6d712e2e1938b3172ce8660708f6e9e11786122383bea8606b458cf12909";
            YnabClient client = new YnabClient(new AccessToken(accessToken));
            string response = client.GetUser().Result;
            Console.WriteLine(response);

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}
