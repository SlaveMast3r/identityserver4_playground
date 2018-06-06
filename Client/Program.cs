using IdentityModel.Client;
using System;
using System.Threading.Tasks;

namespace Client
{
    public class Program
    {
        public static void Main(string[] args) => MainAsync().GetAwaiter().GetResult();

        private static async Task MainAsync()
        {
            // discover endpoints from the metadata by calling Auth server hosted on 5000 port
            var discoveryClient = await DiscoveryClient.GetAsync("http://localhost:5000");
            if (discoveryClient.IsError)
            {
                Console.WriteLine(discoveryClient.Error);
                Console.ReadKey();
                return;
            }

            // request the token from the Auth server
            var tokenClient = new TokenClient(discoveryClient.TokenEndpoint, "ro.client", "secret");
            //var response = await tokenClient.RequestClientCredentialsAsync("api1");
            var response = await tokenClient.RequestResourceOwnerPasswordAsync("alice", "password", "api1");

            if (response.IsError)
            {
                Console.WriteLine(response.Error);
                Console.ReadKey();
                return;
            }

            Console.WriteLine(response.Json);
            Console.ReadKey();
        }

    }
}
